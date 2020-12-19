using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isCourseWork
{
    internal class Adapter_Aggregator : IDisposable
    {
        private List<Adapter> _adaptersList = new List<Adapter>();

        private Keys.KeyStorage _keyStorage = new Keys.KeyStorage();
        internal Keys.KeyStorage KeyStorage
        {
            set { _keyStorage = value; }
        }
        //--------------------------------------------------------------------service
        internal bool IsAdapterAdded(string adapterName)
        {
            /*if (
                _adaptersList.Any(ad => ad.platformName.Equals(adapterName))
            ) return true;
            return false;*/
            return _adaptersList.Any( ad => ad.platformName.Equals(adapterName) );
        }
        internal Adapter FindAdapter(string adapterName)
        {
            return _adaptersList.Find(
                ad => ad.platformName.Equals(adapterName)
                );
        }
        //---------------------------------------------------------------------KeyStorage
        internal void KeyStorageSetName(string name)
        {
            _keyStorage._ksName = name;
        }
        internal string KeyStorageGetName()
        {
            return _keyStorage._ksName;
        }
        internal void SetHashedPass(byte[] hashedPass)
        {
            _keyStorage.HashedPass = hashedPass;
        }
        internal bool IsPassHashRight(byte[] hashedPassToCheck)
        {
            return _keyStorage.IsPassHashRight(hashedPassToCheck);
        }
        internal void AddOrRewriteKeySet(string platformName, byte[] apiEncoded, byte[] secretEncoded)
        {
            _keyStorage.AddOrRewriteKeySet(platformName, apiEncoded, secretEncoded);
        }
        internal bool DelKeySet(string platformName)
        {
            return _keyStorage.DelKeySet(platformName);
        }
        internal void AllPlacesFillFromKS(string passwordORIGINAL, System.Windows.Forms.Form owner)
        {
            _keyStorage.AllPlacesFillFromKS(passwordORIGINAL, owner);
        }
        //------------------------------------------------------------file IO
        internal void LoadKeyStorageFrFile(Stream stream)
        {
            FileIOSerializer.load(ref _keyStorage, stream);
        }
        internal void SaveKeyStorageToFile(Stream stream)
        {
            FileIOSerializer.save(_keyStorage, stream);
        }
        //---------------------------------------------------------------Adapters
        internal bool AddAdapter(string adapterName, string pKey, string sKey)
        {
            if (
                !_adaptersList.Any(//do not forget ! (negate)
                (Adapter ad) => ad.platformName.Equals(adapterName)
                )
            )
            {
                switch (adapterName)
                {
                    case Adapter.NAME_TEST: _adaptersList.Add(new AdapterTest(pKey, sKey)); break;
                    case Adapter.NAME_BINANCE: _adaptersList.Add(new AdapterBinance(pKey, sKey)); break;
                    case Adapter.NAME_ETHERSCAN: _adaptersList.Add(new AdapterEtherscan(pKey, sKey)); break;
                    default: return false;
                }
                return true;
            }//if
            else return false;
        }
        internal bool DelAdapter(string adapterName)
        {
            Adapter a = FindAdapter(adapterName);
            if (a != null) 
            { 
                a.Dispose();
                _adaptersList.Remove(a);
                return true;
            }
            return false;
        }
        internal bool Del_ALL_Adapters()
        {
            try
            {
                _adaptersList.ForEach(a => a.Dispose());
                _adaptersList.Clear();
                return true;
            }
            catch {}
            return false;
        }
        private bool Process(string adapterName, char mode)
        {
            Adapter ad = FindAdapter(adapterName);
            if (ad != null)
            {
                switch(mode)
                {
                    case 'i': return ad.Init();
                    case 'c': return ad.CheckCon();
                    case 'b': return ad.GetBalances();
                }
            }
            return false;
        }
        internal bool Init(string adapterName) { return Process(adapterName, 'i'); }
        internal bool CheckCon(string adapterName) { return Process(adapterName, 'c'); }
        internal bool GetBalances(string adapterName) { return Process(adapterName, 'b'); }
        internal bool GetPrices(string adapterName, out int successAssestCnt)//???
        {
            Adapter ad = FindAdapter(adapterName);
            if (ad != null)
            {
                successAssestCnt = ad.GetPrices();
                return true;
            }
            successAssestCnt = 0;
            return false;
        }
        internal bool CalcPortfolio(string adapterName, out decimal portfolioPrice)//???
        {
            Adapter ad = FindAdapter(adapterName);
            if (ad != null)
            {
                portfolioPrice = ad.CalcPortfolio();
                return true;
            }
            portfolioPrice = 0;
            return false;
        }
        //-------------------------------------------
        internal void MassInit()
        {
            _adaptersList.ForEach(ad => ad.Init());
        }
        internal void MassCheckCon()
        {
            _adaptersList.ForEach(
                (Adapter ad) => { ad.CheckCon(); }
                );
        }
        internal void MassGetBalances() 
        {
            _adaptersList.ForEach( ad => ad.GetBalances() );
        }
        internal void MassGetPrices()
        {
            _adaptersList.ForEach(
                (Adapter ad) => { ad.GetPrices(); }
                );
        }
        internal void MassCalcPortfolio()
        {
            _adaptersList.ForEach(
                (Adapter ad) => { ad.CalcPortfolio(); }
                );
        }
        //-------------------------------------------------
        internal Dictionary<string, List<DataOneAsset>> RequestEngine(List<string> assets, List<string> adapters)
        {
            Dictionary<string, List<DataOneAsset>> res = new Dictionary<string, List<DataOneAsset>>();
            List<DataOneAsset> tempAssetsList = new List<DataOneAsset>();

            foreach (string anAdapter in adapters)
            {
                if( _adaptersList.Any(ad => ad.platformName.Equals(anAdapter)) )
                {
                    Adapter findedAd = _adaptersList.Find( ad => ad.platformName.Equals(anAdapter) );

                    foreach(string anAsset in assets)
                    {
                        DataOneAsset findedAsset = findedAd.assetList.Find(doa => doa.Asset.Equals(anAsset));
                        if (findedAsset != null)
                        {
                            //Console.WriteLine('\n' + aPlatform);
                            //Console.WriteLine(findedAsset.ToString());
                            tempAssetsList.Add(findedAsset);
                        }
                    }
                    res.Add(findedAd.platformName, tempAssetsList);
                    //tempAssetsList.Clear();
                }
            }//for
            return res;
        }//method
        //-----
        public void Dispose()
        {
            _adaptersList.ForEach( ad => ad.Dispose() );
            _adaptersList.Clear();
        }
        //-------------------------------------------
    }
}

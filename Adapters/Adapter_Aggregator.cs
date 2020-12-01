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
        private List<Adapter> adaptersList = new List<Adapter>();

        internal List<string> fillablePlatforms = new List<string>();
        internal List<string> fillableAssets = new List<string>();

        private Keys.KeyStorage _keyStorage = new Keys.KeyStorage();
        //--------------------------------------------------------------------service
        internal bool IsAdapterAdded(string adapterName)
        {
            if (
                adaptersList.Any(
                //(Adapter ad) => ad.platformName.Equals(Enum.GetName(typeof(Adapter.supportedAdapters), adapterEnum))
                (Adapter ad) => ad.platformName.Equals(adapterName)
                )
            ) return true;
            return false;
        }
        internal Adapter FindAdapter(string adapterName)
        {
            return adaptersList.Find(
                ad => ad.platformName.Equals(adapterName)
                );
        }
        //internal List<string> GetAdapterNames
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
        internal void LoadKeyStorageFrFile(Stream stream)
        {
            FileIOSerializer.load(ref _keyStorage, stream);
        }//!!!!!!
        internal void SaveKeyStorageToFile(Stream stream)
        {
            FileIOSerializer.save(_keyStorage, stream);
        }
        //---------------------------------------------------------------Adapters
        internal bool AddAdapter(string adapterName, string pKey, string sKey)
        {
            if (
                !adaptersList.Any(//do not forget ! (negate)
                (Adapter ad) => ad.platformName.Equals(adapterName)
                )
            )
            {
                switch (adapterName)
                {
                    case Adapter.NAME_TEST: adaptersList.Add(new AdapterTest(pKey, sKey)); break;
                    case Adapter.NAME_BINANCE: adaptersList.Add(new AdapterBinance(pKey, sKey)); break;
                    case Adapter.NAME_ETHERSCAN: adaptersList.Add(new AdapterEtherscan(pKey, sKey)); break;
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
                adaptersList.Remove(a);
                return true;
            }
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
        /*internal void MassAddAdapters()//add new adapters here
        {
            foreach(Keys.OneKeySet oks in _keyStorage._keySetList)
            {

            }
        }*/
        internal void MassInit()
        {
            adaptersList.ForEach(ad => ad.Init());
        }
        internal void MassCheckCon()
        {
            adaptersList.ForEach(
                (Adapter ad) => { ad.CheckCon(); }
                );
        }
        internal void MassGetBalances() 
        {
            adaptersList.ForEach( ad => ad.GetBalances() );
        }
        internal void MassGetPrices()
        {
            adaptersList.ForEach(
                (Adapter ad) => { ad.GetPrices(); }
                );
        }
        internal void MassCalcPortfolio()
        {
            adaptersList.ForEach(
                (Adapter ad) => { ad.CalcPortfolio(); }
                );
        }
        //-------------------------------------------------
        internal void FillPlatformsAndAssetsNames()
        {
            fillablePlatforms.Clear();
            //adapters.ForEach( (Adapter a) => platforms.Add(a.platformName) );
            foreach (var adapter in adaptersList)
            {
                fillablePlatforms.Add(adapter.platformName);
                foreach(var dataAsset in adapter.assetList)
                {
                    fillableAssets.Add(dataAsset.Asset);
                }
            }

        }
      
        internal Dictionary<string, List<DataOneAsset>> RequestEngine(List<string> assets, List<string> adapters)
        {
            Dictionary<string, List<DataOneAsset>> res = new Dictionary<string, List<DataOneAsset>>();
            List<DataOneAsset> tempAssetsList = new List<DataOneAsset>();

            foreach (string anAdapter in adapters)
            {
                if( adaptersList.Any(ad => ad.platformName.Equals(anAdapter)) )
                {
                    Adapter findedAd = adaptersList.Find( ad => ad.platformName.Equals(anAdapter) );

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
            adaptersList.ForEach( ad => ad.Dispose() );
            adaptersList.Clear();
            fillablePlatforms.Clear();
            fillableAssets.Clear();
        }
        //-------------------------------------------
    }
}

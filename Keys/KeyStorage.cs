using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isCourseWork.Keys
{
    [Serializable()]
    class KeyStorage
    {
        internal string _ksName;
        private byte[] _hashedPass;
        internal byte[] HashedPass//set, check
        {
            set { _hashedPass = value; }
        }
        private List<OneKeySet> _keySetList = new List<OneKeySet>();//add, del, rewrite
        //-----------------------------------------------------------------------
        internal bool IsPassHashRight(byte[] hashedPassToCheck)
        {
            return hashedPassToCheck.SequenceEqual(_hashedPass);
        }
        //-------------------------------------------------------------------
        internal void AddOrRewriteKeySet(string platformName, byte[] apiEncoded, byte[] secretEncoded)
        {
            OneKeySet oks = _keySetList.Find(ks => ks._platformName.Equals(platformName));
            if (oks != null)
            {
                oks._apiEncoded = apiEncoded;
                oks._secretEncoded = secretEncoded;
            }
            else _keySetList.Add(new OneKeySet(platformName, apiEncoded, secretEncoded));
        }
        internal bool DelKeySet(string platformName)
        {
            OneKeySet oks = _keySetList.Find(ks => ks._platformName.Equals(platformName));
            if (oks != null)
            {
                _keySetList.Remove(oks);
                return true;
            }
            return false;
        }
        //-----------------------------------------------------------
        internal Adapter GetBuiledAdapter(string adapterName, string passwordORIGINAL)
        {
            OneKeySet finded_oks = _keySetList.Find(oks => oks._platformName.Equals(adapterName));
            if (null == finded_oks) return null;

            if(!Сryptography.GetSha512(passwordORIGINAL).SequenceEqual(_hashedPass)) return null;

            byte[] bytedPass = Сryptography.PassToByte16Arr(passwordORIGINAL);

            string api = Сryptography.DecryptStringFromBytes_Aes(finded_oks._apiEncoded, bytedPass);
            string sec = Сryptography.DecryptStringFromBytes_Aes(finded_oks._secretEncoded, bytedPass);
            switch (finded_oks._platformName)
            {
                case Adapter.NAME_TEST: return new AdapterTest(api, sec);
                case Adapter.NAME_BINANCE: return new AdapterBinance(api, sec);
                case Adapter.NAME_ETHERSCAN: return new AdapterEtherscan(api, sec);
            }
            return null;
        }//m
        internal void AllPlacesFillFromKS(string passwordORIGINAL, System.Windows.Forms.Form mainForm)
        {
            if (!Сryptography.GetSha512(passwordORIGINAL).SequenceEqual(_hashedPass)) return;
            FormMain fm = mainForm as FormMain;
            if (null == fm) return;

            byte[] bytedPass = Сryptography.PassToByte16Arr(passwordORIGINAL);

            foreach (OneKeySet oks in _keySetList)
            {
                string api = Сryptography.DecryptStringFromBytes_Aes(oks._apiEncoded, bytedPass);
                string sec = Сryptography.DecryptStringFromBytes_Aes(oks._secretEncoded, bytedPass);

                switch (oks._platformName)
                {
                    case Adapter.NAME_TEST: fm.AddAdapterInAllPlaces(Adapter.NAME_TEST, api, sec, passwordORIGINAL); break;
                    case Adapter.NAME_BINANCE: fm.AddAdapterInAllPlaces(Adapter.NAME_BINANCE, api, sec, passwordORIGINAL); break;
                    case Adapter.NAME_ETHERSCAN: fm.AddAdapterInAllPlaces(Adapter.NAME_ETHERSCAN, api, sec, passwordORIGINAL); break;
                }
            }
        }//m
    }//c
}

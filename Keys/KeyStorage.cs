using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isCourseWork.Keys
{
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
    }//c
}

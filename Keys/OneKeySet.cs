using System;

namespace isCourseWork.Keys
{
    [Serializable()]
    class OneKeySet
    {
        internal string _platformName;
        internal byte[] _apiEncoded;
        internal byte[] _secretEncoded;

        internal OneKeySet(string platformName, byte[] apiEncoded, byte[] secretEncoded)
        {
            _platformName = platformName;
            _apiEncoded = apiEncoded;
            _secretEncoded = secretEncoded;
        }
    }//c
}

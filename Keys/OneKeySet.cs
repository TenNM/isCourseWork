using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isCourseWork.Keys
{
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

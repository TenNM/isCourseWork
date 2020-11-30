using System;
using System.Collections.Generic;

namespace isCourseWork
{
    internal abstract class Adapter : IDisposable
    {
        private protected string api;
        private protected string secret;
        internal List<DataOneAsset> assetList = new List<DataOneAsset>();
        //
        internal string platformName = "";
        internal const decimal SATOSHI = 0.0000_0001m;
        internal decimal minShowableBalance = 0.00001m;
        internal uint requestCooldown = 10;
        //
        internal const string NAME_TEST = "Test";
        internal const string NAME_BINANCE = "Binance";
        internal const string NAME_ETHERSCAN = "Etherscan";
        //
        internal static string[] GetSupportedAdapters()
        {
            string[] arr = { NAME_TEST, NAME_BINANCE, NAME_ETHERSCAN };
            return arr;
        }
        abstract internal bool Init();
        abstract internal bool CheckCon();
        abstract internal bool GetBalances();
        abstract internal int GetPrices();
        abstract internal decimal CalcPortfolio();
        abstract public void Dispose();
    }
}

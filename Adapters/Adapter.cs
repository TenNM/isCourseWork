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
        internal static uint requestCooldown = 10;
        //
        internal const string NAME_TEST = "Test";
        internal const string NAME_BINANCE = "Binance";
        internal const string NAME_ETHERSCAN = "Etherscan";
        //
        internal const string ASSET_TEST1 = "TEST1";
        internal const string ASSET_ETH = "ETH";
        internal const string ASSET_ETC = "ETC";
        internal const string ASSET_BTC = "BTC";
        internal const string ASSET_LTC = "LTC";
        internal static readonly List<string> hotAssets
            = new List<string> { ASSET_TEST1, ASSET_ETH, ASSET_ETC, ASSET_BTC, ASSET_LTC };
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

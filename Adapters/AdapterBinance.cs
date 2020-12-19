using Binance.Net;
using Binance.Net.Objects.Spot;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Logging;
using System;
using System.Collections.Generic;
using System.IO;

namespace isCourseWork
{
    internal class AdapterBinance : Adapter
    {
        internal decimal btcUsdtPrice;
        private BinanceClient binanceClient;//v2
        //----------------------------------------------------------------
        internal AdapterBinance(string api, string secret)
        {
            this.api = api;
            this.secret = secret;
            platformName = "Binance";
        }
        //---------------------------------------------------------------------
        override internal bool Init()
        {
            try
            {
                BinanceClient.SetDefaultOptions(new BinanceClientOptions()
                {
                    ApiCredentials = new ApiCredentials(api, secret),
                    LogVerbosity = LogVerbosity.None,
                    LogWriters = new List<TextWriter> { Console.Out }
                });
                binanceClient = new BinanceClient();//v2
                return true;
            }
            catch
            {
                return false;
            }
        }
        override internal bool CheckCon()
        {
            try
            {
                var check = binanceClient.Ping();
                return check.Success;
            }
            catch
            {
                return false;
            }
        }
        override internal bool GetBalances()
        {
            assetList.Clear();

            try
            {
                var accInfo = binanceClient.GetAccountInfo();
                //---
                if (!accInfo.Success) return false;
                //---
                var balances = accInfo.Data.Balances;
                foreach (var v in balances)
                {
                    assetList.Add(new DataOneAsset(v.Asset, v.Total, 0, 0));//-1?
                }
                return accInfo.Success;
            }
            catch { return false; }
        }
        override internal int GetPrices()
        {
            int successAssetsCnt = 0;
            int errorAssetsCnt = 0;
  
            try
            {
                btcUsdtPrice = binanceClient.GetPrice("BTCUSDT").Data.Price;
                foreach (var v_asset in assetList)//!!!
                {
                    if (v_asset.Asset.Equals(ASSET_BTC))//???????
                    {
                        v_asset.Price = btcUsdtPrice;
                        continue;
                    }
                    if (v_asset.TotalAssetBalance > minShowableBalance)
                    {
                        //
                        var gettedData = binanceClient.GetPrice(v_asset.Asset + "BTC");
                        if (gettedData.Success)
                        {
                            successAssetsCnt++;
                            v_asset.Price = gettedData.Data.Price;
                        }
                        else errorAssetsCnt++;
                    }
                    
                }
            }
            catch { }
            //
            return successAssetsCnt;
        }
        override internal decimal CalcPortfolio()
        {
            decimal sum = 0;
            foreach (var v in assetList)
            {
                if (v.Asset.Equals(ASSET_BTC))
                {
                    v.Worth = v.TotalAssetBalance * btcUsdtPrice;
                    continue;
                }
                v.Worth = v.TotalAssetBalance * v.Price * btcUsdtPrice;
                sum += v.Worth;
            }
            return sum;
        }
        public override void Dispose()
        {
            binanceClient.Dispose();
        }
        //-----------------------------------------------------------------------
    }
}

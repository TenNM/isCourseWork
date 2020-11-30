using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isCourseWork
{
    class AdapterTest : Adapter
    {
        //internal new string platformName = "Test";
        //-------------------------------------------------------------
        internal AdapterTest(string api, string secret)
        {
            this.api = api;
            this.secret = secret;
            platformName = "Test";
        }
        //-----------------------------------------------------
        override internal bool Init()
        {
            return true;
        }
        override internal bool CheckCon()
        {
            return true;
        }
        override internal bool GetBalances()
        {
            assetList.Add(new DataOneAsset("TEST1", 10));
            assetList.Add(new DataOneAsset("TEST2", 20));
            assetList.Add(new DataOneAsset("TEST3", 30));
            //dataPortfolioList.Add(new DataOneAsset("BTC", 100500));
            //dataPortfolioList.Add(new DataOneAsset("ETH", 9000));
            return true;
        }
        override internal int GetPrices()
        {
            int successAssetsCnt = 0;
            foreach (var v in assetList)
            {
                v.Price = v.TotalAssetBalance + 1;
                successAssetsCnt++;
            }
            return successAssetsCnt;
        }
        override internal decimal CalcPortfolio()
        {
            decimal sum = 0;
            foreach (var v in assetList)
            {
                v.Worth = v.TotalAssetBalance * v.Price;
                sum += v.Worth;
            }
            return sum;
        }
        public override void Dispose()
        {
            return;  
        }
        //---------------------------------------------------
    }
}

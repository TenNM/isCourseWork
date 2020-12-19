namespace isCourseWork
{
    class AdapterTest : Adapter
    {
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

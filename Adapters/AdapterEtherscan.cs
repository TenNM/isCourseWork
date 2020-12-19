using EtherscanApi.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace isCourseWork
{
    class AdapterEtherscan : Adapter
    {
        EtherScanClient etherScanClient;
        WebClient web;
        //---------------------------------------------
        internal AdapterEtherscan(string api, string secret)
        {
            this.api = api;
            this.secret = secret;
            platformName = "Etherscan";
        }
        //-------------------------------------------------
        override internal bool Init()
        {
            web = new WebClient();
            etherScanClient = new EtherScanClient(api);
            if (etherScanClient != null) return true;
            return false;
        }
        override internal bool CheckCon()
        {
            string url = $"https://api.etherscan.io/api?module=stats&action=ethsupply&apikey={api}";
            string responseString = web.DownloadString(url);
            JObject jObject = JObject.Parse(responseString);
            if ("1" == jObject["status"].ToString())
            {
                return true;
            }
            return false;
        }
        override internal bool GetBalances()
        {
            var balanceResponce = etherScanClient.GetEtherBalance(secret);
            decimal decBal = balanceResponce.Result;
            assetList.Add(new DataOneAsset("ETH", decBal));
            return true;
        }
        override internal int GetPrices()
        {
            int successAssetsCnt = 0;
            foreach (var v in assetList)
            {
                v.Price = GetPrice();
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
            etherScanClient = null;
            web.Dispose();
        }
        //-----
        private decimal GetPrice()
        {
            try
            {
                //string url = "https://api.etherscan.io/api?module=stats&action=ethprice&apikey=YourApiKeyToken";
                string url = $"https://api.etherscan.io/api?module=stats&action=ethprice&apikey={api}";
                string responseString = web.DownloadString(url);
                //string responseString = "{\"status\":\"1\",\"message\":\"OK-Missing/Invalid API Key, rate limit of 1/5sec applied\",\"result\":{\"ethbtc\":\"0.02853\",\"ethbtc_timestamp\":\"1605446996\",\"ethusd\":\"457.79\",\"ethusd_timestamp\":\"1605446995\"}}";

                JObject jObject = JObject.Parse(responseString);
                if ("1" == jObject["status"].ToString())
                {
                    JToken result = jObject["result"];
                    JToken ethusd = result["ethusd"];
                    var price = ethusd.ToObject(typeof(decimal));
                    if (price is decimal) return (decimal)price;
                }
            }//t
            catch { }

            return -1;
        }//m
        //-------------------------------------------------
    }
}

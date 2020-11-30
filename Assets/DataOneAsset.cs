namespace isCourseWork
{
    internal class DataOneAsset
    {
        internal string Asset;
        internal decimal TotalAssetBalance;
        internal decimal Price;
        internal decimal Worth;

        internal DataOneAsset(string asset, decimal total)
        {
            this.Asset = asset;
            this.TotalAssetBalance = total;
        }
        internal DataOneAsset(string asset, decimal totalAssetBalance, decimal price, decimal worth)
        {
            this.Asset = asset;
            this.TotalAssetBalance = totalAssetBalance;
            this.Price = price;
            this.Worth = worth;
        }
        public override string ToString()
        {
            return
                this.Asset + " " +
                this.TotalAssetBalance + " " +
                this.Price + " " +
                this.Worth;
        }
        //-----------------------------------------------------------------
    }
}

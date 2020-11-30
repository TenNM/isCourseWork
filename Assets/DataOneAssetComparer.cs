using System.Collections.Generic;

namespace isCourseWork
{
    class DataOneAssetComparer : IComparer<DataOneAsset>
    {
        public int Compare(DataOneAsset dp1, DataOneAsset dp2)
        {
            if (dp1.Worth > dp2.Worth)
                return -1;
            else if (dp1.Worth < dp2.Worth)
                return 1;
            else
                return 0;
        }
    }
}

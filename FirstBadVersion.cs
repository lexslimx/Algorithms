using System;
namespace Algorithms
{
    internal class FirstBadVersion
    {
        public int FindirstBadVersion(int n)
        {
            for(int i = 1; i <= n; i++){
                if(IsBadVersion(i)) return i;
            }    
            return 0;
        }

        bool IsBadVersion(int version){

            return false;
        }
    }
}
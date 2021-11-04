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

        public int FindirstBadVersioWithBinarySearch(int n)
        {

            int left = 1;
            int right = n;            
            while(left < right){
                int mid = left + (right-left)/2;
                if(!IsBadVersion(mid)){
                    left = mid+1; //SEAERCH RIGHT
                }
                else{
                    right = mid;
                }
            }

            return left;
        }

        bool IsBadVersion(int version){

            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StringCompression
    {

        //abaasass => aba2sas2
        //abc = abc
        //abaabbbc => aba2b3c
        public String compress(String message)
        {
            StringBuilder result = new StringBuilder();
            var arr = message.ToCharArray();
            int sum = 1;
            for (int i = 0; i < message.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    sum++;
                }
                else
                {
                    //ommit single count repetition
                    if(sum == 1)
                    {
                        result.Append(arr[i]);
                    }
                    else{
                        result.Append(arr[i]);
                        result.Append(sum);
                    }
                    
                    sum = 1;
                }
            }
            if(sum == 1)
            {
                result.Append(arr[message.Length - 1]);
            }
            else
            {
                result.Append(arr[message.Length - 1]);
                result.Append(sum);
            }           

            //check if string was compressed at all
            if(result.Length <= message.Length)
            {
                return result.ToString();
            }
            else
            {
                return message;
            }
        }
    }
}

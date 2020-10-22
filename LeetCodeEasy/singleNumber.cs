using System;
using System.Collections.Generic;

namespace LeetCodeEasy
{
    public class singleNumber
    {
        public int SingleNumber(int[] nums) {
            Array.Sort(nums);
            Dictionary<int, int> counter =
                new Dictionary<int, int>();
            var single = 0;
            foreach(int value in nums){
                bool keyExists = counter.ContainsKey(value);
                if( keyExists ){
                    counter[value] = 2;
                }
                else{
                    counter.Add(value, 1);
                }
            }
            foreach(KeyValuePair<int, int> entry in counter){
                if(entry.Value == 1){
                    single = entry.Key;
                }
            }
            return single;
        }
        
    }
}
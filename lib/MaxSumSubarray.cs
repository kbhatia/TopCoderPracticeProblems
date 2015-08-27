//find maximum subarray

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            int[] B = new int[] {1,-3,5,-2,9,-8,-6,4};
            
            int[]C = MaxSum(B);
            
            for(int i=0; i <C.Length; i++)
            {
                Console.WriteLine(C[i]);
            }

        }
        
        public static int[] MaxSum(int[] A)
        {
            int sum = 0;
            int maxSum =0;
            int a =0;
            int b=0;
            int s=0;
            List<int> subList = new List<int>();
            
            for(int i= 0; i<A.Length; i++)
            {
                sum += A[i];
                if (sum > maxSum)
                {
                        maxSum = sum;
                        a = s;
                        b = i;
                        
                }
                if (sum < 0)
                {
                    sum=0;
                    s = i + 1;
                }                                 
            }            
            for(int j = a; j <b+1; j++)
            {
                subList.Add(A[j]);
            }
            
            return subList.ToArray();
        }
    }
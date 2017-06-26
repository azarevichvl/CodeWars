using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu.StrCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            //Console.Write(Program.Kata.FriendOrFoe(names));


            //Console.Write(Program.Kata.Find(new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 }));
            //Console.WriteLine(Program.Kata.FindEvenIndex(new int[] {1,2,3,4,3,2,1}));
            Console.WriteLine(Program.Kata.CountBits(10));
            Console.ReadKey();

        }

        public static class Kata
        {

            public static int CountBits(int n)
            {
                int count = 0;
                while (n > 1)
                {
                    if (n % 2 != 0) { 
                        count++;
                        
                    }
                    n = n/2;
                    if (n == 1) { count++; }
                }
                return count;
            }

            public static int FindEvenIndex(int[] arr)
            {
                int indx = -1;
                int i, fullSum = 0;
                foreach (int s in arr)
                {
                    fullSum += s;
                }

                int currSum = 0;

                for (i = 0; i < arr.Length; i++)
                {
                    
                    fullSum -= arr[i];
                    if (currSum == fullSum) { indx = i; break; };
                    currSum += arr[i];

                }

                return indx;
            }

            public static int Find(int[] integers)
            {
                int oddCount = 0, evenCount = 0;
                int ans = 0;
                foreach (int b in integers)
                {
                    if ((b % 2) == 0) { oddCount++; }
                    else
                    {
                        evenCount++;
                    }
                }

                for (int i = 0; i < integers.Length; i++)
                {
                    if ((evenCount > 1)&&(integers[i] % 2 == 0)) { ans = integers[i]; }
                    if ((oddCount > 1) && (integers[i] % 2 != 0)) { ans = integers[i]; }
                }

                return ans;
            }

            public static long rowSumOddNumbers(long n)
            {
                long res = 1;
                long temp = 1;
                for (long i = 1; i < n; i++)
                {
                    temp *= 2;
                    res += temp;
                }
                //Console.WriteLine("Res = {0}",res);

                temp = 0;
                long ans = res;
                for (long i = 1; i < n; i++ )
                {
                    ans += res;
                    temp += temp + 2;
                };




                return ans + temp;
                // TODO
            }
            public static int SecondTask(int p0, double percent, int aug, int p)
            {
                int res = p0;
                int yearNumber = 0;

                //if (percent >= 1)
                {
                    percent = percent / 100;
                }

                while (res < p)
                {
                    res += (int)(res * percent) + aug;
                    yearNumber++;
                    Console.WriteLine(res);
                }

                return yearNumber;
            }

            public static IEnumerable<string> FriendOrFoe(string[] names)
            {
                int i = 0, friendsCount = 0;
                foreach (string s in names)
                {
                    if (s.Length == 4)
                    {
                        //myFriendsNames[i] = s;
                        friendsCount++;
                    }
                }
                string[] myFriendsNames = new string[friendsCount];
                foreach (string st in names)
                {
                    if (st.Length == 4)
                    {
                        myFriendsNames[i] = st;
                        i++;
                    }
                };

                return myFriendsNames;
            }
        }
    }
}


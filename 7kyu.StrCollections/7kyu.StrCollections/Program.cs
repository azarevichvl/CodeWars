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
            Console.Write(Program.Kata.Find(new int[] = {2;6;8;-10;3} ));
            Console.ReadKey();

        }

        public static class Kata
        {

            public static int Find(int[] integers)
            {
                return -1;
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


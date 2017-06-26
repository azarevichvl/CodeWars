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

            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Console.Write(Program.Kata.FriendOrFoe(names));
            Console.ReadKey();

        }

        public static class Kata
        {
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


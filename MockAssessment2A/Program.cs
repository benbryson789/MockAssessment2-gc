using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MockAssessment2A
{
    class Program
    {
        static void Main(string[] args)
        {
            AddStarWarsCharacters();

        }

        public static void AddStarWarsCharacters()
        {
            /*
            var names = new[] { "George", "Karen", "Yoda", "Grace", "Harriet" };
            var index = -1;
            var item = "Yoda";

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == item)
                {
                    index = i;
                    break;
                }
            }


            Console.WriteLine(index);
            */





            Dictionary<int, string> test = new Dictionary<int, string>()
        {
            {10, "val1"},
            {20, "val2"},
            {50, "val1"},
            {100, "val3"},
            {150, "val1"}
        };

           // var maxKeyOnValue = test.Where(c => c.Value.Equals("val1")).Select(x => x.Key).Max();
            //returns 150
           // Console.WriteLine(maxKeyOnValue);

        }
    }
}

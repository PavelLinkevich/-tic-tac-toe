using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Helper
    {
        public static int[] UserInput()
        {
            string inputUser = Console.ReadLine();
            string[] stringArray = inputUser.Split(' ');
            var intArray = stringArray.Select(x => int.Parse(x)).ToArray();
            if (intArray.Count() < 2) { Play.i = 0; }
            return intArray;
        }
    }
}

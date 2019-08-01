using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Play
    {
        public static int i = 1;
        public void NewGame()
        {
            while (true)
            {
            var playingField = new PlayingField(Configuration.Height, Configuration.Width);
                FullMove(playingField);
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        public void MakeStep(PlayingField playingField, char playerSymbol)
        {
            int[] coordinate = Helper.UserInput();
            int y;
            int x;
            if (coordinate.Count() < 2)
            {
                y = coordinate[0] - 1;
                x = coordinate[0] - 1;
            }
            else
            {
                y = coordinate[0] - 1;
                x = coordinate[1] - 1;
            }
            playingField.Сoordinator('X', x, y);
        }
        public void FullMove(PlayingField playingField)
        {
            while (true)
            {
                Console.WriteLine("ход " + /*PlayerName + */ "1 игрока");
                playingField.PrintField();
                Console.WriteLine("укажите столбик и ряд через пробел:");
                MakeStep(playingField,'X');
                chekWin(playingField);

                Console.WriteLine("ход " + /*PlayerName + */ "2 игрока");
                playingField.PrintField();
                Console.WriteLine("укажите столбик и ряд через пробел:");
                MakeStep(playingField,'0');
                chekWin(playingField);
            }
        }
        public bool chekWin(PlayingField playingField)
        {
            if (playingField.CheckWin('X'))
            {
                Console.WriteLine("ход 1 игрока");
                playingField.PrintField();
                Console.WriteLine("Победа 1 игрока");
                Console.ReadKey(true);
                Console.Clear();
                playingField.firstPlayerToWin++;
                playingField.CounterWins();
                return true;
            }
            else { return false; }
        }  
    }
}

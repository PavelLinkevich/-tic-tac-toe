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
            PlayingField playingField = new PlayingField(Configuration.Height, Configuration.Width);//Переменовать
            //playingField.field = new char[];//?
            while (true)
            {
                playingField.FieldCleaning(playingField.field);
                FullMove();
                playingField.FieldCleaning(playingField.field);
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        public void FullMove()
        {
            PlayingField playingField = new PlayingField(Configuration.Height, Configuration.Width);
            while (true)
            {
                Console.WriteLine("ход " + /*PlayerName + */ "1 игрока");
                playingField.PrintField(playingField.field);
                PlayersStep(playingField.field, 'X');
                Console.Clear();

                if (playingField.CheckWin('X') == true)
                {
                    Console.WriteLine("ход 1 игрока");
                    playingField.PrintField(playingField.field);
                    Console.WriteLine("Победа 1 игрока");
                    Console.ReadKey(true);
                    Console.Clear();
                    playingField.firstPlayerToWin++;
                    playingField.CounterWins();
                    break;
                }
                Console.WriteLine("ход " + /*PlayerName + */ "2 игрока");
                playingField.PrintField(playingField.field);
                PlayersStep(playingField.field, 'O');
                Console.Clear();

                if (playingField.CheckWin('X') == true)
                {
                    Console.WriteLine("ход 2 игрока");
                    playingField.PrintField(playingField.field);
                    Console.WriteLine("Победа 2 игрока");
                    Console.ReadKey(true);
                    Console.Clear();
                    playingField.firstPlayerToWin++;
                    Console.WriteLine(playingField.firstPlayerToWin);
                    playingField.CounterWins();
                    break;
                }
            }
        }
        public void PlayersStep(char[,] field, char playerSymbol)//Принимает числа через пробел и указывает кординату x
        {
            Console.WriteLine("укажите столбик и ряд через пробел:");
            var coordinate=Helper.UserInput();
            int y = coordinate[0] - 1;
            int x = coordinate[i] - 1;
            field[x, y] = playerSymbol;//переименовать
        }       
    }
}

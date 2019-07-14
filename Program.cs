using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TicTacToe
{
    class Program
    {
        static int a;
        static int b;
        public static char[,] field;
        char Firstplaersumbol;

        static void Main(string[] args)
        {
            CreatePlayingField();
            Console.ReadKey(true);
        }
        static void CreatePlayingField()
        {
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            Console.WriteLine("Выберите размер поля");
            a = b = UserInput();
            field = new char[a, b];
            PrintField(field);
            TwoPlayers();
        }
        static int UserInput()
        {
            return int.Parse(Console.ReadLine())-1;
        }        
        static void TwoPlayers()
        {

            while ( true)
            {
                Console.WriteLine("ход 1 игрока");                
                PlayersStep(field,'X');
                PrintField(field);
                if (Win('X') == true)
                {
                    Console.WriteLine("Победа 1 игрока");
                    break;
                }
                Console.WriteLine("ход 2 игрока");
                PlayersStep(field, 'O');
                PrintField(field);
                if (Win('O') == true)
                {
                    Console.WriteLine("Победа 2 игрока");
                    break;
                }
            }
        }
        static void PlayersStep(char[,] field,char Firstplaersumbol)//Доработаю
        {
            Console.WriteLine("укажите столбик:");
            int move2 = UserInput();

            Console.WriteLine("укажите ряд:");
            int move = UserInput();

            field[move, move2] = Firstplaersumbol;
        }
        static void PrintField(char[,] field)//Доработаю
        {
            for (int t = 0; t < a; t++)
            {
                Console.Write(" |");

                for (int y = 0; y < b; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }
        }      
        static bool Win(char plaerSumbol)
        {

            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[p, i - 2] == plaerSumbol && field[p, i - 1] == plaerSumbol && field[p, i] == plaerSumbol) { Console.WriteLine("Победа 1 игрока"); return true; }// 3 в ряд
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[i - 2, p] == plaerSumbol && field[i - 1, p] == plaerSumbol && field[i, p] == plaerSumbol) { Console.WriteLine("Победа 1 игрока"); return true; }// 3  по вертикали
                }
            }

            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[i - 2, p - 2] == plaerSumbol && field[i - 1, p - 1] == plaerSumbol && field[i, p] == plaerSumbol) { Console.WriteLine("Победа 1 игрока"); return true; }// 3  по диаганали
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[p - 2, i] == plaerSumbol && field[p - 1, i - 1] == plaerSumbol && field[p, i - 2] == plaerSumbol) { Console.WriteLine("Победа 1 игрока"); return true; }
                }
            }
            return false;
        }        
    }
}

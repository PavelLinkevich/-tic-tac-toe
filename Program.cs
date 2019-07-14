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
            a = b = Parse();
            field = new char[a, b];
            GameField(field);
            Twoplayers();
        }
        static int Parse()
        {
            return int.Parse(Console.ReadLine());

        }
        
        static void Twoplayers()
        {

            while (Win('O') == true || Win('X') == true)
            {
                Console.WriteLine("ход 1 игрока");                
                PlayersMove(field,'X');
                GameField(field);
                if (Win('X') == false)
                {
                    Console.WriteLine("Победа 1 игрока");
                    break;
                }
                Console.WriteLine("ход 2 игрока");
                PlayersMove(field, 'O');
                GameField(field);
                if (Win('O') == false)
                {
                    Console.WriteLine("Победа 2 игрока");
                    break;
                }
            }
        }
        static void PlayersMove(char[,] field,char Firstplaersumbol)//Доработаю
        {
            Console.WriteLine("укажите столбик:");
            int move2 = Parse() - 1;

            Console.WriteLine("укажите ряд:");
            int move = Parse() - 1;

            field[move, move2] = Firstplaersumbol;
        }
        static void GameField(char[,] field)//Доработаю
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
        static bool Win(char Firstplaersumbol)
        {

            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[p, i - 2] == Firstplaersumbol && field[p, i - 1] == Firstplaersumbol && field[p, i] == Firstplaersumbol) { Console.WriteLine("Победа 1 игрока"); return false; }// 3 в ряд
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[i - 2, p] == Firstplaersumbol && field[i - 1, p] == Firstplaersumbol && field[i, p] == Firstplaersumbol) { Console.WriteLine("Победа 1 игрока"); return false; }// 3  по вертикали
                }
            }

            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[i - 2, p - 2] == Firstplaersumbol && field[i - 1, p - 1] == Firstplaersumbol && field[i, p] == Firstplaersumbol) { Console.WriteLine("Победа 1 игрока"); return false; }// 3  по диаганали
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[p - 2, i] == Firstplaersumbol && field[p - 1, i - 1] == Firstplaersumbol && field[p, i - 2] == Firstplaersumbol) { Console.WriteLine("Победа 1 игрока"); return false; }
                }
            }
            return true;
        }        
    }
}

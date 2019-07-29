using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayingField
    {
        public char[,] field;
        //private char[,] field;
        public int firstPlayerToWin;
        public int secondPlayerToWin;
        public static int Width1 { get; set; }// ?
        public static int Height1 { get; set; }
        public PlayingField(int width, int height)
        {
            Width1 = width;
            Height1 = height;
            field = new char[width, height];
        }
        public void PrintField(char[,] field)//Доработаю
        {
            for (int t = 0; t < Width1; t++)
            {
                Console.Write(" |");
                for (int y = 0; y < Height1; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }
        }
        public void FieldCleaning(char[,] field)//Доработаю
        {
            for (int t = 0; t < Width1; t++)
            {
                for (int y = 0; y < Height1; y++)
                {
                    field[t, y] = ' ';
                }
            }
        }
        public bool CheckWin(char plaerSumbol)
        {
            int pastMeaningI;
            int pastMeaningP;

            for (int i = 2; i < 4; i++)
            {
                for (int p = 0; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[p, i - 2] == plaerSumbol && field[p, i - 1] == plaerSumbol && field[p, i] == plaerSumbol) { return true; }// 3 в ряд
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[i - 2, p] == plaerSumbol && field[i - 1, p] == plaerSumbol && field[i, p] == plaerSumbol) { return true; }// 3  по вертикали                   
                }
                for (int p = 2; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[i - 2, p - 2] == plaerSumbol && field[i - 1, p - 1] == plaerSumbol && field[i, p] == plaerSumbol) { return true; }// 3  по диаганали
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[p - 2, i] == plaerSumbol && field[p - 1, i - 1] == plaerSumbol && field[p, i - 2] == plaerSumbol) { return true; }
                }
            }
            return false;
        }
        public void CounterWins()
        {
            Console.WriteLine(firstPlayerToWin + " / " + secondPlayerToWin);
        }
    }
}

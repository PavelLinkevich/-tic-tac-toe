using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace TicTacToe
{
    public class Start
    {
        char Firstplaersumbol;
        static void Main(string[] args)
        {
            Start start = new Start();
            start.InitialScreen();
            Console.ReadKey(true);
        }
        public void InitialScreen()
        {
            Play play = new Play();
            Register register = new Register();
            //Start start = new Start();
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            int initialСhoice;
            Console.WriteLine("1)Играть");
            Console.WriteLine("2)Войти");
            Console.WriteLine("3)Настройки");
            initialСhoice = Helper.UserInput()[0];
            switch (initialСhoice)
            {
                case 1:
                    play.NewGame();
                    break;
                case 2:
                    register.CheckIn();
                    break;
                case 3:
                    register.Options();
                    break;
            }
        }
    }  
    public class Players
    {
        private string Name;
        int KauntWin;
        public Players(string Name, int KauntWin)
        {
            this.Name=Name;
            this.KauntWin = KauntWin;
        }
        //Players Player1 = new Players(Name);
        //Players Player2 = new Players();


    }
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
                    if (field[p, i - 2] == plaerSumbol && field[p, i - 1] == plaerSumbol && field[p, i] == plaerSumbol) { return true;  }// 3 в ряд
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
   public class Register
   {
        public void CheckIn()
        {
            Start start = new Start();
            Console.WriteLine("Имя первого игрока:");
            Players Player1 = new Players(Console.ReadLine(),0); /*(Console.ReadLine());*/
            Console.WriteLine("Имя второго игрока:");
            Players Player2 = new Players(Console.ReadLine(),0);
            //FileStream file1 = new FileStream("E:\\Name\\" + Name + ".txt", FileMode.OpenOrCreate); //создаем файловый поток
            //StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            //writer.Write(width /*fieldSize*/); //записываем в файл
            //writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
            Console.WriteLine("Для возвращения в меню нажмите любую клавишу..");
            Console.ReadKey(true);
            Console.Clear();
            start.InitialScreen();
        }
        public void Options()
        {
            Play play = new Play();
            Start start = new Start();
            Console.WriteLine("Выберите размер поля");
            PlayingField.Width1 = PlayingField.Height1 = Helper.UserInput()[0];
            Console.WriteLine("Для возвращения в меню нажмите любую клавишу...");
            Console.ReadKey(true);
            Console.Clear();
            start.InitialScreen();
        }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Snake
    {
        public int x;
        public int y;

    }

    class Program
    {
        public char[,] Map = new char[12, 32];
        public int[] pos = new int[2] { 5, 16 };
        public int[] befPos = new int[2];
        public int[] fPos = new int[2];
        public int Score = 0;
        public bool isOver = false;

        public void Draw()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    Console.Write("{0}", Map[i, j]);
                }
                Console.WriteLine();
            }
        }
        

        public void Move()
        {
            char direction;
            direction = Console.ReadKey().KeyChar;

            if(direction == 'w')
            {
                pos[0] += 1;
            }
            if (direction == 's')
            {
                pos[0] -= 1;
            }
            if (direction == 'a')
            {
                pos[1] -= 1;
            }
            if (direction == 'd')
            {
                pos[1] += 1;
            }
        }


        public void init()
        {
            for(int i =0; i < 12; i++)
            {
                for(int j = 0; j <32; j++)
                {
                    if (i == 0 || j==0 || i ==11|| j==31)
                    {
                        Map[i,j] = '=';
                    }
                    else
                    {
                        Map[i, j] = ' ';
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.init();
            program.Draw();

        }
    }
}

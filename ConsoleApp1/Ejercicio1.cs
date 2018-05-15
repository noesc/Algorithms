using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ejercicio1
    {
        int n, m;
        int[,] board; // Fills with 0 and 1, white represented by 1 and black by 0 

        public Ejercicio1()
        {
        }

        public bool IsWhite(int row, int col)
        {
            return board[row,col].Equals(0);
                 
        }
    }
}

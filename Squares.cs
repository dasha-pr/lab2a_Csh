using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Csh
{
    class Squares
    {
        Square[] squares;
        internal Square[] Squares_ { get => squares; set => squares = value; }


        public Squares()
        { }

        public Squares(int N)
        {
            Squares_ = new Square[N];
            Random r = new Random();

            for (int i = 0; i < Squares_.Length; i++)
            {
                Squares_[i] = new Square();
                Squares_[i].Side = r.Next(2, 20);
            }
        }

        public void printSquares()
        {
            int i = 1;
            foreach (Square square in Squares_)
            {
                Console.WriteLine("Square " + i++ + ": " + square.Side);
            }
        }

        public double findSquaresArea()
        {
            double average = 0;
            double sum = 0;
           
                for (int i = 0; i < Squares_[i].Side; i++)
                {
                    sum += Squares_[i].getSquare();
                }
                average = sum / 10;
             
            return average;
        }
    }
}

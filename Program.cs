using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Csh
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            square.Side = 4;

            Console.WriteLine("Perimetr: "+square.getPerimetr());
            Console.WriteLine("Diagonal: "+square.getDiagonal());
            Console.WriteLine("Square area: "+square.getSquare());

            Squares squares = new Squares(10);
            squares.printSquares();

            Console.WriteLine("Average of squares area: "+ squares.findSquaresArea());
        }

    }
}

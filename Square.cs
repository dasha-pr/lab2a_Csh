using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Csh
{
    class Square
    {
        private double side;
        public double Side { get => side; set => side = value; }

        public double getPerimetr()
        {
            return Side * 4;
        }
        public double getDiagonal()
        {
            return Math.Sqrt(Side * Side * 2);
        }
        public double getSquare()
        {
            return Side * Side;
        }

    }
}

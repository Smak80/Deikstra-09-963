using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deikstra_09_963
{
    class Vertex
    {
        private double minPathLength = double.PositiveInfinity;
        private Vertex prev = null;
        private int num;
        private static int count = 0;

        public int Num
        {
            get { return num; }
            private set
            {
                num = value;
            }
        }

        public Vertex()
        {
            count++;
            Num = count;
        }

        public static void ResetVerticies()
        {
            count = 0;
        }
    }
}

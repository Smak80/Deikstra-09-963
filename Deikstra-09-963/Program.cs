using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deikstra_09_963
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = Loader.LoadData("data.csv");
                Console.WriteLine(data[3, 2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Проблема с чтением из файла :(");
            }
        }
    }
}

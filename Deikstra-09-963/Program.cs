using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deikstra_09_963
{
    class Program
    {

        static void ShowPath(List<Vertex> path)
        {
            foreach (var v in path)
            {
                Console.Write("{0} ", v.Num);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            try
            {
                var data = Loader.LoadData("data.csv");
                Graph g = new Graph(data);
                int b = 1;
                int e = 6;
                var path = g.GetShortestPath(b, e);
                ShowPath(path);
                Console.WriteLine("Длина кратчайшего пути: {0}", Graph.GetShortestPathLength(path));
                b = 2;
                path = g.GetShortestPath(b, e);
                ShowPath(path);
                Console.WriteLine("Длина кратчайшего пути: {0}", Graph.GetShortestPathLength(path));
            }
            catch (IOException e)
            {
                Console.WriteLine("Проблема с чтением из файла :(");
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так :(");
            }
        }
    }
}

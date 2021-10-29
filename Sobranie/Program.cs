using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobranie
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph<string> graph = new DirectedGraph<string>();
            graph.AddVertex("Boris");
            graph.AddVertex("Rashid");
            graph.AddVertex("OI");
            graph.AddVertex("Lekcus");
            graph.AddVertex("Nach");
            graph.AddEdge("Boris","Rashid");
            graph.AddEdge("Boris", "OI");
            graph.AddEdge("Rashid", "Lekcus");
            graph.AddEdge("Oi", "Nach");
            if (graph.AreAdjacent("Rashid","Boris")) 
            {
                Console.WriteLine("Mozhno");
            }
            else
            {
                Console.WriteLine("Nelzya");
            }
            Console.ReadKey();
        }
    }
}

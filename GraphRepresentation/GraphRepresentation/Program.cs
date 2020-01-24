using System;
using System.Collections.Generic;
// for printing the vertex and the edges we are not using any technique simply prting the array
// here we can also use the map insted of the array (directly the inbuild hashmap) but i wanted to
// make it more generic so i have implemented my own map like array by using hashcode i am creating the index and adding the values

namespace GraphRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> ct = new Dictionary<int, char>();
            ct.GetEnumerator();
            Graph<char> graph = new Graph<char>();
            graph.addEdge('A', 'B', false);
            graph.addEdge('A', 'C', false);
            graph.addEdge('B', 'C', false);
            graph.addEdge('C', 'A', false);
            // graph.print();
            Console.ReadKey();
        }
    }
}

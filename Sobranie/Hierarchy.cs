using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobranie
{
    public interface Graph <T>
    {
        bool AddVertex(T vertex);
        bool DeleteVertex(T vertex);
        bool AddEdge(T v1, T v2);
        bool DeleteEdge(T v1, T v2);
        bool AreAdjacent(T v1, T v2);
       
         
    }
    public interface IPairValue<T>
    {
        T GetFirst();
        T GetSecond();
        bool Contains(T value);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobranie
{
    public abstract class AbstractGraph<T> : Graph<T>
    {
        protected readonly List<T> VertexSet = new List<T>();
        protected readonly List<IPairValue<T>> EdgeSet = new List<IPairValue<T>>();
        public bool DeleteVertex(T vertex)
        {
            if (VertexSet.Contains(vertex))
            {
                return false;
            }
            VertexSet.Remove(vertex);
            return true;
        }
        public abstract bool AddEdge(T v1, T v2);
        public abstract bool DeleteEdge(T v1, T v2);
        public abstract bool AreAdjacent(T v1, T v2);

        public bool AddVertex(T vertex)
        {
            if (VertexSet.Contains(vertex))
            {
                return false;
            }
            VertexSet.Add(vertex);
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobranie
{
    public class DirectedGraph<T> : AbstractGraph<T>
    {
        public override bool AddEdge(T v1, T v2)
        {
            if (!VertexSet.Contains(v1)|| !VertexSet.Contains(v2))
            {
                return false;
            }
            IPairValue<T> pair = new PairValueImplementation<T>(v1, v2);
            if (EdgeSet.Contains(pair))
            {
                return false;
            }
            EdgeSet.Add(pair);
            return true;
        }

        public override bool AreAdjacent(T v1, T v2)
        {
            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
            {
                return false;
            }
            return EdgeSet.Contains(new PairValueImplementation<T>(v1, v2));
        }

        public override bool DeleteEdge(T v1, T v2)
        {
            IPairValue<T> pair = new PairValueImplementation<T>(v1, v2);
            if (EdgeSet.Contains(pair))
            {
                EdgeSet.Remove(pair);
                return true;
            }
            return false;
        }
    }
}

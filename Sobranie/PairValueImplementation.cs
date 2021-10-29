using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobranie
{
    public class PairValueImplementation <T>: IPairValue<T>
    {
        private readonly T t1;
        private readonly T t2;
        public PairValueImplementation(T t1, T t2)
        {
            this.t1 = t1;
            this.t2 = t2;
        }
        public bool Contains (T value)
        {
            return value.Equals(t1) || value.Equals(t2);
        }
        public T GetFirst()
        {
            return t1;
        }
        public T GetSecond()
        {
            return t2;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(PairValueImplementation<T>))
                return false;
            PairValueImplementation<T> tmp = (PairValueImplementation<T>)obj;
            return tmp.Equals(t1) && tmp.Equals(t2);
        }
    }
}

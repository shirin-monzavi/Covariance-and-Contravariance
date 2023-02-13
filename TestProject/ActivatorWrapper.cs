using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ActivatorWrapper<T>
    {
        public T CreateShape()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}

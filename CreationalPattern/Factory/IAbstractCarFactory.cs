using CreationalPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Factory
{
    internal interface IAbstractCarFactory
    {
        public IAbstractCar CreateCar();
    }
}

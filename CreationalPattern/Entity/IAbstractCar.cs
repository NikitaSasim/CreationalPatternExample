using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Entity
{
    internal interface IAbstractCar
    {
        double Weight { get; set; }
        double Length { get; set; }
        double MaxSpeed { get; set; }
    }
}

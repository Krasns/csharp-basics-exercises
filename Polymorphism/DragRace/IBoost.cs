using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    interface IBoost : ICar
    {
        public void UseNitrousOxideEngine()
        {
            currentSpeed += 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    abstract class RangedUnit : Unit
    {
        public virtual float Range { get; protected set; }
    }
}

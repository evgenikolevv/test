using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1 
{
    interface IsportType : IBall, ICourtDimensions
    {
        SportCategory Category { get; }
    }
}

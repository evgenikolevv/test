using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    interface IBall
    {
      int NumberOfPlayers { get; set; }
      string NameOfSport { get; }
      void SportCharacteristics();
    }
}

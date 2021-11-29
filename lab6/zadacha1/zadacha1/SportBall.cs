using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class SportBall : IsportType
    {   
        int Players { get; set; }
        string Sport { get; set; }
        SportCategory SportCategory { get; set; }

        public double width { get; set; }
        public double length { get; set; }

        public SportBall(int players, string sport, SportCategory category)
        {
            Players = players;
            Sport = sport;
            SportCategory = category;
        }

        public SportCategory Category => SportCategory;

        public int NumberOfPlayers { get => Players; set => NumberOfPlayers = Players; }

        public string NameOfSport => Sport;

        public double Length { get => length; set => Length = length; }
        public double Width { get => width; set => Width = width; }

        public void SportCharacteristics()
        {
           Console.WriteLine("Type of sport: " + SportCategory);
        }
    }
}

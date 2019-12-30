using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkConsoleApp
{
    public class Player
    {

        public Player(int id,string name, string team   )
        {
            Id = id;
            Name = name;
            Team = team;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Team { get; private set; }
    }
}

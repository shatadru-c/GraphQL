using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkConsoleApp
{
    public class PlayerRepository
    {
        List<Player> _playerList = new List<Player>();

        public PlayerRepository()
        {
            _playerList.Add(new Player(1, "Virat", "India"));
            _playerList.Add(new Player(2, "Rohit", "India"));
            _playerList.Add(new Player(3, "Steve", "Australia"));
            _playerList.Add(new Player(4, "Pat", "Australia"));
            _playerList.Add(new Player(5, "Ross", "New Zealand"));
            _playerList.Add(new Player(6, "Trent", "New Zealand"));
        }

        public List<Player> GetAll()
        {
            return _playerList;
        }

        public List<Player> GetPlayersFromTeam(string team)
        {
            return _playerList.Where(x_ => string.Equals(x_.Team, team, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

    }
}

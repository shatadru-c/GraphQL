using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkConsoleApp
{
    public class PlayerType : ObjectGraphType<Player>
    {
        public PlayerType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Team);
        }
    }
}

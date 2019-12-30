using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkConsoleApp
{
    public class PlayerQuery : ObjectGraphType
    {

        public PlayerQuery(PlayerRepository repository)
        {
            Field<ListGraphType<PlayerType>>("players",
                resolve: context => repository.GetAll());


            Field<ListGraphType<PlayerType>>("teamPlayers",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "team" }),
                resolve: context => repository.GetPlayersFromTeam(context.GetArgument<string>("team")));
        }
    }
}

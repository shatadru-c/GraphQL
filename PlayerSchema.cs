using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrameworkConsoleApp
{
    public class PlayerSchema: Schema
    {
        public PlayerSchema(IDependencyResolver resolver)
        {
            Query = resolver.Resolve<PlayerQuery>();
            
        }
    }
}

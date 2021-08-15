using LazyUtils;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace Demo
{
    [ApiVersion(2, 1)]
    public class PluginContainer : TerrariaPlugin
    {
        public PluginContainer(Main game) : base(game)
        {
            Order = 100;
        }

        public override void Initialize()
        {
            CommandHelper.Register<BankCommand>("bank");
        }
    }
}

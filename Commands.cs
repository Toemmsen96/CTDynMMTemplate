
using System.Collections.Generic;
using CTDynamicModMenu.Commands;

namespace CTDynMMTemplate.Commands
{internal class Commands
    {
        public static List<CustomCommand> AllCommands { get; } = new List<CustomCommand>
        {
            new AddXP()
        };
    }
}
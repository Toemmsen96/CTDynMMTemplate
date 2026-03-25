// This file is just a template for an example command. 
// It does nothing but display a message when executed. 
// You can copy and modify this file to create your own custom commands.


using CTDynamicModMenu.Commands;


namespace CTDynMMTemplate.Commands
{
    internal class AddXP : CustomCommand
    {
        public override string Name => "Add XP";

        public override string Description => "Adds XP to the player's balance.";
        public override string Format => "/addxp <amount>";
        public override string Category => "Cheats";

        public override void Execute(CommandInput message)
        {
            if (message.Args.Count < 1)
            {
                Plugin.logger.LogInfo("Usage: " + Format);
                return;
            }
            int amount = int.Parse(message.Args[0]);
            CTDynamicModMenu.CTDynamicModMenu.Instance.DisplayMessage($"Added {amount} XP"); 
        }
    }
}
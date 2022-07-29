using Plus.Plugins;
using Plus.HabboHotel.Rooms.Chat.Commands;
using Plus.HabboHotel.GameClients;
using Plus.HabboHotel.Rooms;

namespace SkateboardPlugin;

public class SkateboardPlugin : IPlugin
{
    
    public void Start()
    {
        var pluginInfo = new SkateboardPluginDefinition();
        Logger(pluginInfo.Name + " by " + pluginInfo.Author + " has started.");
    }

    private void Logger(string message) {
        var pluginInfo = new SkateboardPluginDefinition();
        var CYAN = "\u001b[34m";
        var WHITE = "\u001b[37m";
        Console.WriteLine(WHITE + "[" + CYAN + pluginInfo.Name + WHITE + "] " + message);    }

}


public class SkateboardModule : IChatCommand
{
    public string Key => "skateboard";

    public string PermissionRequired => "skateboard_effect_plugin";

    public string Parameters => "";

    public string Description => "Enables the skateboard effect.";

    public async void Execute(GameClient session, Room room, string[] @params)
    {
        var skateboardEffectID = 71;
        session.GetHabbo().Effects().ApplyEffect(skateboardEffectID);
    }
}
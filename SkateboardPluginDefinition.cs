using Plus.Plugins;

namespace SkateboardPlugin
{
    public class SkateboardPluginDefinition : IPluginDefinition
    {
        public string Name => "Skateboard Plugin";
        public string Author => "Harb#9937";
        public Version Version => new(1, 0, 0);
        public Type PluginClass => typeof(SkateboardPlugin);
    }
}
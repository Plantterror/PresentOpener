using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PresentOpener
{
    public class ConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(true)]

        [Label("Disable Processor User Interfaces")]
        [Tooltip("Changes the two processors back into crafting stations. Requires Reload.")]
        [ReloadRequired]
        public bool ChangeTile { get; set; }
    }
}

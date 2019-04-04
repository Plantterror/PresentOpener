using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PresentOpener
{
    public class ConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(false)]

        [Label("Disable Processor User Interfaces")]
        [Tooltip("Changes the two processors back into crafting stations. Requires Reload.")]
        [ReloadRequired]
        public bool ChangeProcessor { get; set; }

        public override void OnLoaded() => PresentOpener.configServer = this;
    }
}

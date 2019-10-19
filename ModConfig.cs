using Newtonsoft.Json;
using System.ComponentModel;
using Terraria;
using Terraria.ModLoader.Config;

namespace PresentOpener
{
    public class PresentOpenChances : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("Reset")]
        [JsonIgnore]
        [Label("Default Present Chances")]
        [Tooltip("Restores the original chances for vanilla items inside Presents.")]
        public bool DefaultPresentChance {
            get => SnowGlobeScale == 1f && CoalScale == 1f && WhistleScale == 1f && RareItemScale == 1f && ToolboxScale == 1f && AntlersScale == 1f && HollyScale == 1f && VanityScale == 1f && FoodScale == 1f && StarAniseScale == 1f && BlockScale == 1f;
            set {
                if (value) {
                    SnowGlobeScale = 1f;
                    CoalScale = 1f;
                    WhistleScale = 1f;
                    RareItemScale = 1f;
                    ToolboxScale = 1f;
                    AntlersScale = 1f;
                    HollyScale = 1f;
                    VanityScale = 1f;
                    FoodScale = 1f;
                    StarAniseScale = 1f;
                    BlockScale = 1f;
                }
            }
        }
        [Header("Configurable Category Scales.")]
        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Snowglobe Chance Scale")]
        public float SnowGlobeScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Coal Chance Scale")]
        public float CoalScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Dog Whistle Scale")]
        public float WhistleScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Rare Items Scale")]
        [Tooltip("Includes Red Ryder, Candy Tools, Fruitcake Chakram, and Hand Warmer.")]
        public float RareItemScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Toolbox Scale")]
        public float ToolboxScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Reindeer Antlers Scale")]
        public float AntlersScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Holly Scale")]
        public float HollyScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Vanity clothes Scale")]
        public  float VanityScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Food Scale")]
        public  float FoodScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Eggnog Scale")]
        public  float EggnogScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Star Anise Scale")]
        public  float StarAniseScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Block Scale")]
		public float BlockScale { get; set; }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            message = "Changes are not allowed while a world is open.";
            return false;
        }
    }
    public class GoodieBagOpenChances : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public const int RegularOpenChance = 1;

        [Header("Reset")]
        [JsonIgnore]
        [Label("Default Goodie Bag Chances")]
        [Tooltip("Restores the original chances for vanilla items inside Goodie Bags.")]
        public bool DefaultGoodieChance
        {
            get => RareItemScale == 1f && RottenEggScale == 1f && PaintingScale == 1f && CostumeScale == 1f; 
            set
            {
                if (value)
                {
                    RareItemScale = 1f;
                    RottenEggScale = 1f;
                    PaintingScale = 1f;
                    CostumeScale = 1f;
                }
            }
        }

        [Header("Configurable Category Scales.")]
        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Rare Items Scale")]
        [Tooltip("Includes Unluckly Yarn and Bat Hook.")]
        public  float RareItemScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Rotten Egg Scale")]
        public  float RottenEggScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Painting Scale")]
        public  float PaintingScale { get; set; }

        [DefaultValue(1f)]
        [Range(0.25f, 4f)]
        [Label("Costume Scale")]
        public float CostumeScale { get; set; }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
			if (Main.dedServ)
			{
				message = "Changes are not allowed on a server.";
				return false;
			}
			else return true;
        }
    }
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace Auralite
{
    public class SlimeMushroom1x1 : ModTile
    {
        public override void SetDefaults()
        {
            {
                Main.tileFrameImportant[Type] = true;
                Main.tileSolid[Type] = false;
                Main.tileMergeDirt[Type] = false;
                Main.tileBlockLight[Type] = true;
                Main.tileLighted[Type] = true;
                TileObjectData.newTile.CopyFrom(TileObjectData.Style1xX);
                drop = mod.ItemType("SlimeMushroom1x1Item");
                AddMapEntry(new Color(0, 255, 20), "Slime Mushroom");
                Main.tileNoAttach[Type] = true;
            }
        }

        public override bool CanExplode(int i, int j)
        {
            return true;
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.2f;
            g = 1.4f;
            b = 0.4f;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            {
                Item.NewItem(i * 16, j * 16, 64, 32, mod.ItemType("SlimeMushroom1x1Item"));
            }
        }
        public virtual bool TileFrame(int i, int j, ref bool resetFrame, ref bool noBreak)
        {
            if (Main.tile[tile.position.X, tile.position.Y] == null)
            {
                WorldGen.KillTile(tile.position.X, tile.position.Y);
            }
        }
    }
}
	


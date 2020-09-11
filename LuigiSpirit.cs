using System.Drawing;

namespace MarioMiner
{
    class LuigiSpirit
    {
        public Bitmap SpriteImage { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Velocity { get; set; }

        public void Draw(Graphics gfx)
        {
            // Draw sprite image on screen           
            gfx.DrawImage(SpriteImage, new RectangleF(X, Y, Width, Height));
        }

    }
}

using System.Drawing;

namespace MarioMiner
{
    class LearnIcon
    {
        public Bitmap LearnImage { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Velocity { get; set; }

        public void Draw(Graphics gfx)
        {
            // Draw sprite image on screen           
            gfx.DrawImage(LearnImage, new RectangleF(X, Y, Width, Height));
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Input;

namespace MarioMiner
{
    class Game
    {
        // ------ VARIABLES ------
        public enum Costs { luigiCost, levelCost }

        private GameSprite playerSprite;
        private bool isStruck;
        private int goldCost, luigiCost, levelCost;
        private int level;
        private Bitmap Background { get; set; }

        public int StoneScore { get; set; }
        public int GoldScore { get; set; }
        public Size Resolution { get; set; }
 
        

        // ------ METHODS ------

        public void Load()
        {
            // Load player setting 
            playerSprite = new GameSprite();
            playerSprite.SpriteImage = Properties.Resources.MarioUp;
            playerSprite.Width = playerSprite.SpriteImage.Width;
            playerSprite.Height = playerSprite.SpriteImage.Height;
            playerSprite.X = 200;
            playerSprite.Y = 170;
            playerSprite.Velocity = 300;

            // Clearing game settings
            StoneScore = 0;
            GoldScore = 0;
            isStruck = false;
            goldCost = 150;
            luigiCost = 1500;
            levelCost = 1000;
            level = 1;
        }

        public void Unload()
        {
            // Unload graphics
            // Turn off game music
        }

        public void Update(TimeSpan gameTime)
        {

            // Move player sprite, when Arrow Keys are pressed on Keyboard
            if ((Keyboard.GetKeyStates(Key.D) & KeyStates.Down) > 0)
            {
                playerSprite.SpriteImage = Properties.Resources.MarioDown;
                isStruck = true;                 
            }
            else if ((Keyboard.GetKeyStates(Key.A) & KeyStates.Down) > 0)
            {
                playerSprite.SpriteImage = Properties.Resources.MarioUp;
                if (isStruck)
                {
                    StoneScore++;
                    isStruck = false;
                }     
            }
            
        }

        public void Draw(Graphics gfx)
        {
            // Draw Background Color
            Background = Properties.Resources.background;
            gfx.DrawImage(Background, new RectangleF(0, 0, 800, 600));

            // Draw Player Sprite
            playerSprite.Draw(gfx);

        }
                
        public void SellStone()
        {
            // Changing stone for gold 
            GoldScore = GoldScore + 100;
            StoneScore = StoneScore - goldCost;
        }
    }
}

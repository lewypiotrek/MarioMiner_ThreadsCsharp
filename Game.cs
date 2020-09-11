using System;
using System.Drawing;
using System.Windows.Input;
using System.Threading;

namespace MarioMiner
{
    class Game
    {
        // ------ VARIABLES ------

        private GameSprite playerSprite;
        private LuigiSpirit lugiSpirite;
        private bool isStruck;
        public int goldCost, luigiCost, levelCost;
        public int level;
        private Bitmap Background { get; set; }
        public int StoneScore { get; set; }
        public int GoldScore { get; set; }
        public Size Resolution { get; set; }

        private Thread lugiThread;
        private ThreadStart luigiThreadDelegate;



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

            lugiSpirite = new LuigiSpirit();
            lugiSpirite.SpriteImage = Properties.Resources.LuigiBlank;
            lugiSpirite.Width = playerSprite.SpriteImage.Width;
            lugiSpirite.Height = playerSprite.SpriteImage.Height;
            lugiSpirite.X = 25;
            lugiSpirite.Y = 310;
            lugiSpirite.Velocity = 300;

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

                // if player already takes pick up we will assign stone score
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

            // Draw Luigi Spirit

            lugiSpirite.Draw(gfx);

        }
                
        public void SellStone()
        {
            // Changing stone for gold 
            GoldScore = GoldScore + 100;
            StoneScore = StoneScore - goldCost;
        }

        public void AutoDigStone()
        {
            // As long as window will be open additional thread will dig stone base on our level
            while(true)
            {
                StoneScore += level;
                Thread.Sleep(1000 / level);
            }

        }

        public void HireLuigi()
        {
            lugiThread = new Thread(LuigiWork);
            lugiThread.IsBackground = true; // to make sure that the thread will be abortet after windows close
            lugiThread.Start();                                 
        }

        private void LuigiWork()
        {
            while(true)
            {
                lugiSpirite.SpriteImage = Properties.Resources.LuigiDown;
                Thread.Sleep(200);
                StoneScore += 300;
                GoldScore -= 150;               
                lugiSpirite.SpriteImage = Properties.Resources.LuigiUp;
                Thread.Sleep(5000);
            }
        }
    }
}

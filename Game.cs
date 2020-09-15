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
        private LearnIcon learnicons;
        private bool isStruck, isLugiWorking;
        public int goldCost, luigiCost, levelCost;
        public int level;
        private Bitmap Background { get; set; }
        public int StoneScore { get; set; }
        public int GoldScore { get; set; }
        public Size Resolution { get; set; }
        private Thread lugiThread;
        public int learnQueueSize = 0;
        public int learnQueueSize2 = 0;
        static public SemaphoreSlim learnSemaphore = new SemaphoreSlim(2);


        // ------ METHODS ------

        public void Load()
        {
            // Load player settings
            playerSprite = new GameSprite();
            playerSprite.SpriteImage = Properties.Resources.MarioUp;
            playerSprite.Width = playerSprite.SpriteImage.Width;
            playerSprite.Height = playerSprite.SpriteImage.Height;
            playerSprite.X = 200;
            playerSprite.Y = 170;
            playerSprite.Velocity = 300;

            // Load Lugi settings
            lugiSpirite = new LuigiSpirit();
            lugiSpirite.SpriteImage = Properties.Resources.LuigiBlank;
            lugiSpirite.Width = playerSprite.SpriteImage.Width;
            lugiSpirite.Height = playerSprite.SpriteImage.Height;
            lugiSpirite.X = 25;
            lugiSpirite.Y = 310;
            lugiSpirite.Velocity = 300;

            // Load learn icons
            learnicons = new LearnIcon();
            learnicons.LearnImage = Properties.Resources.Blank;
            learnicons.Width = 200;
            learnicons.Height = 200;
            learnicons.X = 30;
            learnicons.Y = 210;
            lugiSpirite.Velocity = 300;

            // Clearing game settings
            StoneScore = 0;
            GoldScore = 0;
            isStruck = false;
            isLugiWorking = false;
            goldCost = 150;
            luigiCost = 500;
            levelCost = 1000;
            level = 1;
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

            if (learnQueueSize != 0)
            {
                switch (learnQueueSize)
                {
                    case 1:
                        learnicons.LearnImage = Properties.Resources.learn_1;
                        break;
                    case 2:
                        learnicons.LearnImage = Properties.Resources.learn_2;
                        break;
                    case 3:
                        learnicons.LearnImage = Properties.Resources.learn_3;
                        break;
                    case 4:
                        learnicons.LearnImage = Properties.Resources.learn_4;
                        break;
                }
            }
        }

        public void Draw(Graphics gfx)
        {
            // Draw background image
            Background = Properties.Resources.background;
            gfx.DrawImage(Background, new RectangleF(0, 0, 800, 600));

            // Draw player Sprite
            playerSprite.Draw(gfx);

            // Draw Luigi Spirit
            lugiSpirite.Draw(gfx);

            // Draw icons
            learnicons.Draw(gfx);

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
            // function will create a new thread for lugi
            if(isLugiWorking == false)
            {
                lugiThread = new Thread(LuigiWork);
                lugiThread.IsBackground = true; // to make sure that the thread will be abortet after windows close
                lugiThread.Start();
                isLugiWorking = true;
            }                              
        }

        private void LuigiWork()
        {            
            // Luigi animation, thread intervals, luigi work
            try
            {
                while (true)
                {
                    lugiSpirite.SpriteImage = Properties.Resources.LuigiDown;
                    Thread.Sleep(200);
                    StoneScore += 300;
                    GoldScore -= 150;
                    lugiSpirite.SpriteImage = Properties.Resources.LuigiUp;
                    Thread.Sleep(7000);
                }                
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine("Luigi Work() Line 146: " + (string)abortException.ExceptionState);
            }
        }

        public void AddLearn()
        {
            if(GoldScore > levelCost)
            {
                Thread learnThread = new Thread(Learn);
                learnThread.IsBackground = true;
                learnQueueSize++;
                learnThread.Start();
            }
        }

        public void Learn()
        {
            // There is an option to create 4 thread in the queue but 2 of them will be executed in the one time
            // After semaphore will end first two threads, the next 2 will be started.

            // only 2 threads will be here at once time
            learnSemaphore.Wait();             
            Thread.Sleep(2000 * level);
            // updating stats
            GoldScore -= levelCost;
            levelCost += 300;
            level++;
            // decrease queue size
            learnQueueSize--;
            learnSemaphore.Release();            
        }

                     
    }   //-- class end --         
}   //-- namespace end --

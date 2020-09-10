using System;
using System.Drawing;
using System.Threading.Tasks;

namespace MarioMiner
{
    class GameLoop
    {
        // Game object 
        private Game _myGame;
        // Game status
        public bool Running { get; private set; }

        // ------ METHODS ------

        public void Load(Game gameObj){ _myGame = gameObj; }
        public int GetStone() { return _myGame.StoneScore; }
        public int GetGold() { return _myGame.GoldScore; }
        public void SellStone() { _myGame.SellStone(); }
        public int GetCosts(int costType)
        {
    
            return 0;
        }


        // Main game loop
        // I used async void, this is not recomended, but in this case it is quite safe. I don't have to put this into try catch block
        // all exceptions will be handle inside.
        public async void Start()
        {
            if (_myGame == null)
                throw new ArgumentException("Game not loaded!");

            // Load game content
            _myGame.Load();

            // Set gameloop state
            Running = true;

            // Set previous game time
            DateTime _previousGameTime = DateTime.Now;

            while (Running)
            {
                // Calculate the time elapsed since the last game loop cycle
                TimeSpan GameTime = DateTime.Now - _previousGameTime;
                // Update the current previous game time
                _previousGameTime = _previousGameTime + GameTime;
                // Update the game
                _myGame.Update(GameTime);
                // Update Game at 60fps
                await Task.Delay(8);
            }
        }


        public void Stop()
        {
            Running = false;
            _myGame?.Unload();
        }

        public void Draw(Graphics gfx)
        {
            _myGame.Draw(gfx);
        }
    }
}

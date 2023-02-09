using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF
{
    public class GameState
    {

        public Tama PlayerTama { get; set; }

        private static GameState instance = null;

        public static GameState Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new GameState();
                }
                return instance;
            }
        }

        private GameState()
        {
            
        }
    }
}

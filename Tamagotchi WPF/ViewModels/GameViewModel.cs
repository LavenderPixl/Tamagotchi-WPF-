using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        public string TamaName { get; set; }
        public int TamaLevel { get; set; }
        public GameViewModel() 
        {
            if (GameState.Instance.PlayerTama != null)
            {
            TamaName =  GameState.Instance.PlayerTama.Name;
            TamaLevel =  GameState.Instance.PlayerTama.Level;
            }
        
        }
    }
}

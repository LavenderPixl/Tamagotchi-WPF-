using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        public string tamaName { get; set; }
        public int tamaLevel { get; set; }
        public int tamaXP { get; set; }

        public int maxXP = 100;
        public float multiplier = 1.25f;

        public void LevelUp()
        {
            try
            {
                tamaLevel++;
                tamaXP = 0;
                maxXP = Convert.ToInt32(Math.Round(maxXP * multiplier));
            }
            catch (Exception)
            {
                return;
            }
        }

        public void CheckXP()
        {

            if (tamaXP >= maxXP)
            {
                LevelUp();
            }
        }

        public GameViewModel()
        {
            if (GameState.Instance.PlayerTama != null)
            {
                tamaName = GameState.Instance.PlayerTama.Name;
                tamaLevel = GameState.Instance.PlayerTama.Level;
                tamaXP = GameState.Instance.PlayerTama.XP;
            }
            
            

        }

    }
}

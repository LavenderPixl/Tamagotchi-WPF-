using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class NewGameViewModel : ViewModelBase
    {
        DAL dal = new DAL();
        public int tamaTypeRND { get; set; }

        public Tama yourTama
        {
            get
            {
                return GameState.Instance.PlayerTama;
            }
        }

        public NewGameViewModel()
        {
            RandomCreatureType();
            CreateTama();
        }

        public int RandomCreatureType()
        {
            Random rnd = new Random();
            tamaTypeRND = rnd.Next(0, 4);
            return tamaTypeRND;
        }
        public void CreateTama()
        {
            GameState.Instance.PlayerTama = new Tama("Baby Egg", 1, 0, 100, 100, 100, 100,
            $"../../../TamaIMG/{dal.CreatureTypes[tamaTypeRND]}/Idle.gif", dal.CreatureTypes[tamaTypeRND].ToString());
        }
    }
}

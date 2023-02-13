using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    class AmusementOptionsViewModel : ViewModelBase
    {
        public ObservableCollection<Amusement> VM_AmusementDataBase { get; set; }
        public AmusementOptionsViewModel()
        {
            VM_AmusementDataBase = dal.GetAmusement();
        }
        public void PlayAmusement(int XP)
        {
            GameState.Instance.PlayerTama.XP += XP;
        }
    }
}

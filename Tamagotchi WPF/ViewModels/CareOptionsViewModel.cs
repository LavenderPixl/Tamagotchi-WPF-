using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    class CareOptionsViewModel : ViewModelBase
    {
        public ObservableCollection<Care> VM_CareDataBase { get; set; }
        public CareOptionsViewModel()
        {
            VM_CareDataBase = dal.GetCare();
        }
        public void PlayCare(int XP)
        {
            GameState.PlayerTama.XP += XP;
        }
    }
}

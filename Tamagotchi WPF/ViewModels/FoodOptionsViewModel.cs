using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    class FoodOptionsViewModel : ViewModelBase
    {
        DAL dal = new DAL();
        public ObservableCollection<Food> VM_FoodDataBase { get; set; }
    
    public FoodOptionsViewModel()
        {
            VM_FoodDataBase = dal.GetFood();
        }
    }
}

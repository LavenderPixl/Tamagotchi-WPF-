using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF
{
    public class DAL
    {
        private ObservableCollection<Food> FoodDataBase;
        private ObservableCollection<Food> FoodData;

        private ObservableCollection<Care> CareDataBase;
        private ObservableCollection<Care> CareData;

        private ObservableCollection<Amusement> AmusementDataBase;
        private ObservableCollection<Amusement> AmusementData;

        public DAL()
        {
            FoodDataBase = new ObservableCollection<Food>
            {
                new Food("Dumplings", 50, 0),
                new Food("Sandwich", 50, 0),
                new Food("Sushi", 50, 0),
                new Food("Salad", 40, 0),
                new Food("Chips", 20, 0),
                new Food("Cookies", 10, 0)
            };
            FoodData = new();

            CareDataBase = new ObservableCollection<Care>
            {
                new Care("Bath", 50, 0),
                new Care("Sandbath", 50, 0),
                new Care("Brush fur", 50, 0),
                new Care("Brush teeth", 50, 0),
                new Care("CARE(Not Created)", 50, 0),
                new Care("CARE(Not Created)", 50, 0)
            };
            CareData = new();

            AmusementDataBase = new ObservableCollection<Amusement>
            {
                new Amusement("Bouncy ball", 50, 0),
                new Amusement("Music", 50, 0),
                new Amusement("Teddybear", 50, 0),
                new Amusement("Chewy toy", 50, 0),
                new Amusement("Hide and Seek", 50, 0),
                new Amusement("Roughouse", 50, 0)
            };
            AmusementData = new();
        }

        public string[] CreatureTypes =
            {
                "Bunny",
                "Mantaray",
                "Snake",
                "Teddy"
            };

        public ObservableCollection<Food> GetFood()
        {
            FoodData.Clear();
            foreach (Food p in FoodDataBase)
            {
                FoodData.Add(p);
            }
            return FoodData;
        }
        public ObservableCollection<Care> GetCare()
        {
            CareData.Clear();
            foreach (Care p in CareDataBase)
            {
                CareData.Add(p);
            }
            return CareData;
        }
        public ObservableCollection<Amusement> GetAmusement()
        {
            AmusementData.Clear();
            foreach (Amusement p in AmusementDataBase)
            {
                AmusementData.Add(p);
            }
            return AmusementData;
        }
    }
}

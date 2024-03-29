﻿using System;
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
                new Food("Dumplings", 50, 100),
                new Food("Sandwich", 50, 10),
                new Food("Sushi", 50, 10),
                new Food("Salad", 40, 10),
                new Food("Chips", 20, 10),
                new Food("Cookies", 10, 10)
            };
            FoodData = new();

            CareDataBase = new ObservableCollection<Care>
            {
                new Care("Bath", 50, 100),
                new Care("Sandbath", 50, 10),
                new Care("Brush fur", 50, 10),
                new Care("Brush teeth", 50, 10),
                new Care("CARE(Not Created)", 50, 10),
                new Care("CARE(Not Created)", 50, 10)
            };
            CareData = new();

            AmusementDataBase = new ObservableCollection<Amusement>
            {
                new Amusement("Bouncy ball", 50, 100),
                new Amusement("Music", 50, 10),
                new Amusement("Teddybear", 50, 10),
                new Amusement("Chewy toy", 50, 10),
                new Amusement("Hide and Seek", 50, 10),
                new Amusement("Roughouse", 50, 10)
            };
            AmusementData = new();
        }

        public string[] CreatureTypes =
            {
                "Bunny",
                "Mantaray",
                "Snake",
                "Teddy",
                "Floofer"
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

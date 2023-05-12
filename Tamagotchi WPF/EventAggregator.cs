using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF
{
    public static class EventAggregator
    {
        public static void Broadcast(Type type)
        {
            if (OnTransmittedData != null)
                OnTransmittedData(type);
        }

        public static Action<Type> OnTransmittedData;

        public static void CreateNewGame(Tama tama)
        {
            if (OnTransmittedTama != null)
                OnTransmittedTama(tama);
        }

        public static Action<Tama> OnTransmittedTama;

        public static void UpdateTama(object value, string propertyName)
        {
            if (OnUpdateTama != null)
                OnUpdateTama(value, propertyName);
        }

        public static Action<object, string> OnUpdateTama;
    }
}

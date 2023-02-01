using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

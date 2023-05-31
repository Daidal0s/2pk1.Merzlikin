using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz._28
{
    public class AC
    {
        public event DelegateEventHandler Increased;
        public event DelegateEventHandler Decreased;

        private int _temperature = 0;

        public int Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public AC(int currentTemperature, DelegateEventHandler eventHandler) 
        { 
            _temperature = currentTemperature;
            Increased += eventHandler;
            Decreased += eventHandler;
        }

        public void increaseTemparature(int increaseValueTemperature)
        {
            _temperature += increaseValueTemperature;
            Increased(this, new ACEventArgs("Значение термометра увеличилось на " + increaseValueTemperature, _temperature));
        }
        public void decreaseTemperature(int decreaseValueTemperature) 
        { 
            _temperature -= decreaseValueTemperature;
            Decreased(this, new ACEventArgs("Значение термометра уменьшилось на " + decreaseValueTemperature, _temperature));
        }
    }
}

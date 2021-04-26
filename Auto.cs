using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_hw
{
    class Auto
    {
        //----------------------------- private fields -----------------------------

        private string _brand;
        private string _model;
        private string _engine;
        private string _color;
        private int _fuel;
        private int _maxSpeed;
        private int _nitroValue;

        //----------------------------- get/set methods string -----------------------------

        public string Brand
        {
            get => _brand;
            set
            {
                _brand = value;
            }
        }
        public string Model
        {
            get => _model;
            set
            {
                _model = value;
            }
        }
        public string Engine
        {
            get => _engine;
            set
            {
                _engine = value;
            }
        }

        public string Color
        {
            get => _color;
            set
            {
                _color = value;
            }
        }

        //----------------------------- get/set methods int -----------------------------

        public int GetFuel()
        {
            return _fuel;
        }

        public void SetFuel(int fuel)
        {
            if (fuel < 0)
            {
                throw new Exception(message: "It's even less than have no fuel");
            }
           else if (fuel > 100)
            {
                throw new Exception(message: "U have more than enough fuel");
            }
            _fuel = fuel;
        }

        public int GetSpeed()
        {
            return _maxSpeed;
        }
        public void SetMaxSpeed(int speed)
        {
            if (speed < 0)
            {
                throw new Exception(message: "It's even less than have no speed");
            }
            else if (speed > 900)
            {
                throw new Exception(message: "You car is a rocket? I think not");
            }
            _maxSpeed = speed;
        }

        public int GetNitro()
        {
            return _nitroValue;
        }
        public void SetNitro(int nitro)
        {
            if (nitro < 0)
            {
                throw new Exception(message: "It's even less than have no nitro");
            }
            else if (nitro > 900)
            {
                throw new Exception(message: "U have more than enough nitro");
            }
            _nitroValue = nitro;
        }

        //----------------------------- Constructors -----------------------------

        public Auto(int value)
        {
            _fuel = value;
            _maxSpeed = value;
            _nitroValue = value;
        }

        //----------------------------- Static -----------------------------

        static string brand = "BMW";
        static string model = "M8";
        static int fuel = 100;
    }
}

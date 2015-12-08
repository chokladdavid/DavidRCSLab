using System;

namespace Lab4_2
{
    public class Radio
    {
        private int volume;
        private bool isOn;
        private double frequency;
        static int instanceCount;
        public int ReadInstanceCount
        {
            get { return instanceCount; }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                var validValue = value >= 0 && value <= 100;
                if (validValue)
                    volume = value;
                else
                    throw new Exception("Not a valid value!");
            }
        }
        public bool IsOn
        {
            get { return isOn; }
            set
            {
                if(value == true || value == false)
                    isOn = value;
                else
                    throw new Exception("Not a valid value!");
            }
        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                var vaidValue = value >= 87.6 && value <= 107.8;
                if (vaidValue)
                    frequency = value;
                else
                    throw new Exception("Not a valid value!");
            }
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            Volume = 100;
            IsOn = false;
            Frequency = 87.6;
            instanceCount++;
        }
        public Radio(int volume, double frequency) : this()
        {
            Volume = volume;
            Frequency = frequency;
        }
        public override string ToString()
        {
            return $"Volume: {Volume} IsOn: {IsOn} Frequency: {Frequency}";
        }
    }
}

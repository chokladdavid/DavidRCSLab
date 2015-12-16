using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class MyDoubleType : IComparable<MyDoubleType>
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            DoubleValue = doubleValue;
        }

        public int CompareTo(MyDoubleType myDoubleType)
        {
            return this.DoubleValue.CompareTo(myDoubleType.DoubleValue);
        }


        public static MyDoubleType operator +(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.DoubleValue += myDoubleType2.DoubleValue;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.DoubleValue += tal;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static double operator +(double tal, MyDoubleType myDoubleType)
        {
            tal += (double) myDoubleType.DoubleValue;
            return tal; ;
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.DoubleValue -= myDoubleType2.DoubleValue;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.DoubleValue -= tal;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static double operator -(double tal, MyDoubleType myDoubleType)
        {
            tal -= (double)myDoubleType.DoubleValue;
            return tal; ;
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.DoubleValue /= myDoubleType2.DoubleValue;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.DoubleValue /= tal;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static double operator /(double tal, MyDoubleType myDoubleType)
        {
            tal /= (double)myDoubleType.DoubleValue;
            return tal; ;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.DoubleValue *= myDoubleType2.DoubleValue;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.DoubleValue *= tal;
            return new MyDoubleType(myDoubleType.DoubleValue); ;
        }
        public static double operator *(double tal, MyDoubleType myDoubleType)
        {
            tal *= (double)myDoubleType.DoubleValue;
            return tal; ;
        }
        public static bool operator ==(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.DoubleValue == myDoubleType2.DoubleValue;
        }
        public static bool operator !=(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.DoubleValue != myDoubleType2.DoubleValue;
        }
        public static bool operator <=(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.DoubleValue <= myDoubleType2.DoubleValue;
        }
        public static bool operator >=(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.DoubleValue >= myDoubleType2.DoubleValue;
        }
        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.DoubleValue > myDoubleType2.DoubleValue;
        }
        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.DoubleValue < myDoubleType2.DoubleValue;
        }
        public override string ToString() => $"DoubleValue: {DoubleValue}";
    }
}

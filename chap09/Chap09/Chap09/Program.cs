using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09
{
    class MyClass
    {
        private int iValue;
        private double dZeta;
        private float fPng;
        private string srtVal;
        private int inCode;
        public int IValue 
        {
            get 
            {
                return this.iValue;
            }
            set 
            {
                if (value < 0)
                {
                    this.iValue = 0;
                }
                else if (value > 120)
                {
                    this.iValue = 120;
                }
                else
                {
                    this.iValue = value;
                }
            }
        }

        public MyClass(int iValue)
        {
            IValue = iValue;
        }

        /*public int GetValue()
        {
            return this.iValue;
        }

        public void SetValue(int iValue)
        {
            if (iValue < 0)
            {
                this.value = 0;
            }
            else if (iValue > 120)
            {
                this.iValue = 120;
            }
            else
            {
                this.iValue = value;
            }
        }*/
        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.iValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1200);
            myClass.PrintValue();
            myClass.IValue = 120;
            myClass.PrintValue();
            Console.WriteLine($"{myClass.IValue}℃");

        }  
    }
}

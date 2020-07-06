using System;
using System.Collections.Generic;
using System.Text;

namespace DogGuts.Calculator {

    public class Calculator {
        /// <summary>num²</summary>
        public int Square(int num) => num * num;
        /// <summary>num1 + num2</summary>
        public int Add(int num1, int num2) => num1 + num2;
        /// <summary>num1 * num2</summary>
        public int Multiply(int num1, int num2) => num1 * num2;
        /// <summary>num1 - num2</summary>
        public int Subtract(int num1, int num2) => num1 - num2;
        /// <summary>num1 / num2</summary>
        public float Division(float num1, float num2) => num1 / num2;
                
    }
}

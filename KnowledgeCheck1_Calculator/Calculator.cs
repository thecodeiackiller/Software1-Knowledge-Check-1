using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {

        // We are actually going to make this code even simpler with expression-bodied members
        // Had to look up what EBM's were - though this was lambda expression but its not
        public static float Add(float a, float b) => a + b;
        public static float Substract(float a, float b) => (a - b);
        public static float Multiply(float a , float b) => a * b;
        public static float Divide(float a , float b) => a / b;

        // Now implementing a method do reduce redundancy and abiding by the DRY principle

        public static bool floatParseCheck(string string1, string string2, out float num1, out float num2)
        {
            if(float.TryParse(string1, out num1) &&  float.TryParse(string2, out num2)) return true;
            num1 = 0;
            num2 = 0;
            return false;
        }


    }
}

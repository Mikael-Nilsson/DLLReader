using System;

namespace DLLToRead
{
    public class Class1
    {
        float parm {get; set;}
        public Class1(float parm1) {
            parm = parm1;
        }

        public Class1() {
            parm = 0;
        }

        public float sum(float a, float b) {
            return a + b;
        }

        public float addToParm(float adder) {
            parm += adder;
            return parm;
        }
    }
}

using System;

namespace FinalTest.Tests
{
    public class Calculatrice
    {
        private IOperation[] iTest;


        public Calculatrice(IOperation[] test)
        {
            this.iTest = test;
        }

        public int Calculer(string s1)
        {
            if (iTest[0].PeutCalculer(s1))
            {
                return iTest[0].Calculer(s1);
            }
            else
            {
                return iTest[1].Calculer(s1);

            }


        }
    }
}
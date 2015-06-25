using System;

namespace FinalTest.Tests
{
    public class Somme : IOperation
    {
        public Boolean PeutCalculer(string s1)
        {
            var r = s1.Split('+');
            var result = r.Length > 1;
            return result;
        }

        public int Calculer(string s2)
        {
            var donne = s2.Split('+');
            var result = Convert.ToInt32(donne[0]) + Convert.ToInt32(donne[1]);
            return result;

        }
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest.Tests
{
    public class Multiplication
    {
        public Boolean PeutCalculer(string s1)
        {
            var r = s1.Split('*');
            var result = r.Length > 1;
            return result;

        }

        public int Calculer(string s)
        {
            var donne = s.Split('*');
            var result = Convert.ToInt32(donne[0]) * Convert.ToInt32(donne[1]);
            return result;

        }
    }
}
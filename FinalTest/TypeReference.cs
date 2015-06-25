using System;

namespace FinalTest.Tests
{
    public class TypeReference
    {
        private readonly int _i;
        private object o;

        public TypeReference(int i)
        {
            _i = i;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            TypeReference other = (TypeReference) obj;
            return other.o == this.o;


        }
    }

}
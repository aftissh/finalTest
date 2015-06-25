using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _otherKeyValuePairskeyValuePairs;
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                var requete = _keyValuePairs.Where(nombre => nombre.Value % 2 ==0).Select(nombre => nombre.Value);
                return requete;
            }
        }


    }
}

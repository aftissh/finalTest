using System;
using System.Collections;
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

        public string TexteNombresImpairs
        {
            get
            {
                var requete = _keyValuePairs.Where(nombre => nombre.Value%2 != 0)
                    .OrderByDescending(nombre => nombre.Value)
                    .Select(nombre => nombre.Key)
                    .Aggregate((workingSentence, next) =>
                                                  next + ", " + workingSentence);
                return requete;
            }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                var requete = _keyValuePairs.Where(nombre => nombre.Key.Length>5)
                    .Select(nombre => nombre.Key)
                    .First()
                    //.Aggregate((workingSentence, next) =>
                       //                           next + ", " + workingSentence)
                       ;
                return requete;
            }


        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                var requete = _keyValuePairs.Where(nombre => nombre.Value > 3)
                    .OrderBy(nombre => nombre.Value)
                    .Skip(0)
                    .Take(4)
                    .Select(nombre => nombre.Value);
                return requete;
                
            }
        }
    }
}

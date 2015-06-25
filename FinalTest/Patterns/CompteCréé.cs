using System;

namespace FinalTest.Tests
{
    public struct CompteCréé : IEvenementMetier
    {
        private readonly object _numéroDeCompte;
        private readonly int _autorisationDeCrédit;

        public override string ToString()
        {
            return string.Format("NuméroDeCompte: {0}, AutorisationDeCrédit: {1}", _numéroDeCompte, _autorisationDeCrédit);
        }

        public CompteCréé(object numéroDeCompte, int autorisationDeCrédit)
        {
            this._numéroDeCompte = numéroDeCompte;
            this._autorisationDeCrédit = autorisationDeCrédit;
        }
    }
}
using System.Globalization;

namespace Calculatrice
{
    public class Calculateur
    {
        public const char Addition = '+';
        public const char Soustraction = '−';
        public const char Multiplication = '×';
        public const char Division = '÷';

        private const int LongueurMaximale = 15;

        private readonly CultureInfo culture;
        private decimal? operandeGauche;
        private char? operation;
        private bool nouvelleSaisie;
        private bool enErreur;

        public string Affichage { get; private set; } = "0";
        public string Historique { get; private set; } = "";
        public string Separateur => culture.NumberFormat.NumberDecimalSeparator;

        public Calculateur(CultureInfo? culture = null)
        {
            this.culture = culture ?? CultureInfo.CurrentCulture;
        }

        public void SaisirChiffre(char chiffre)
        {
            if (!char.IsAsciiDigit(chiffre)) return;
            PreparerSaisie();
            if (Affichage.Length >= LongueurMaximale) return;

            Affichage = Affichage == "0" ? chiffre.ToString() : Affichage + chiffre;
        }

        public void SaisirVirgule()
        {
            PreparerSaisie();
            if (!Affichage.Contains(Separateur))
            {
                Affichage += Separateur;
            }
        }

        public void ChoisirOperation(char nouvelleOperation)
        {
            if (enErreur) return;

            if (operation is not null && !nouvelleSaisie)
            {
                if (!Calculer()) return;
            }
            else if (operation is null)
            {
                operandeGauche = ValeurAffichee();
            }

            operation = nouvelleOperation;
            Historique = $"{Formater(operandeGauche!.Value)} {nouvelleOperation}";
            nouvelleSaisie = true;
        }

        public void Egal()
        {
            if (enErreur || operation is null) return;

            decimal operandeDroite = ValeurAffichee();
            string calcul = $"{Formater(operandeGauche!.Value)} {operation} {Formater(operandeDroite)} =";
            if (!Calculer()) return;

            Historique = calcul;
            operation = null;
            operandeGauche = null;
        }

        public void Effacer()
        {
            if (enErreur)
            {
                Reset();
                return;
            }
            if (nouvelleSaisie) return;

            Affichage = Affichage[..^1];
            if (Affichage is "" or "-")
            {
                Affichage = "0";
            }
        }

        public void Reset()
        {
            operandeGauche = null;
            operation = null;
            nouvelleSaisie = false;
            enErreur = false;
            Affichage = "0";
            Historique = "";
        }

        private bool Calculer()
        {
            decimal gauche = operandeGauche!.Value;
            decimal droite = ValeurAffichee();

            if (operation == Division && droite == 0)
            {
                AfficherErreur("Division impossible");
                return false;
            }

            try
            {
                decimal resultat = operation switch
                {
                    Addition => gauche + droite,
                    Soustraction => gauche - droite,
                    Multiplication => gauche * droite,
                    Division => gauche / droite,
                    _ => droite
                };
                operandeGauche = resultat;
                Affichage = Formater(resultat);
                nouvelleSaisie = true;
                return true;
            }
            catch (OverflowException)
            {
                AfficherErreur("Nombre trop grand");
                return false;
            }
        }

        private void PreparerSaisie()
        {
            if (enErreur) Reset();
            if (nouvelleSaisie)
            {
                Affichage = "0";
                nouvelleSaisie = false;
            }
        }

        private void AfficherErreur(string message)
        {
            Reset();
            Affichage = message;
            enErreur = true;
        }

        private decimal ValeurAffichee() =>
            decimal.Parse(Affichage, NumberStyles.Number, culture);

        private string Formater(decimal valeur) =>
            valeur.ToString("0.############", culture);
    }
}

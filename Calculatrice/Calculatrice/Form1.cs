namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private readonly Calculateur calculateur = new();

        public Form1()
        {
            InitializeComponent();
            btnVirgule.Text = calculateur.Separateur;
            MettreAJourAffichage();
        }

        private void Chiffre_Click(object sender, EventArgs e)
        {
            calculateur.SaisirChiffre(((Button)sender).Text[0]);
            MettreAJourAffichage();
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            calculateur.ChoisirOperation(((Button)sender).Text[0]);
            MettreAJourAffichage();
        }

        private void Virgule_Click(object sender, EventArgs e)
        {
            calculateur.SaisirVirgule();
            MettreAJourAffichage();
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            calculateur.Egal();
            MettreAJourAffichage();
        }

        private void Effacer_Click(object sender, EventArgs e)
        {
            calculateur.Effacer();
            MettreAJourAffichage();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            calculateur.Reset();
            MettreAJourAffichage();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    calculateur.Egal();
                    break;
                case Keys.Back:
                    calculateur.Effacer();
                    break;
                case Keys.Escape:
                case Keys.Delete:
                    calculateur.Reset();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            MettreAJourAffichage();
            return true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case >= '0' and <= '9':
                    calculateur.SaisirChiffre(e.KeyChar);
                    break;
                case ',' or '.':
                    calculateur.SaisirVirgule();
                    break;
                case '+':
                    calculateur.ChoisirOperation(Calculateur.Addition);
                    break;
                case '-':
                    calculateur.ChoisirOperation(Calculateur.Soustraction);
                    break;
                case '*' or 'x':
                    calculateur.ChoisirOperation(Calculateur.Multiplication);
                    break;
                case '/':
                    calculateur.ChoisirOperation(Calculateur.Division);
                    break;
                case '=':
                    calculateur.Egal();
                    break;
                default:
                    base.OnKeyPress(e);
                    return;
            }
            e.Handled = true;
            MettreAJourAffichage();
        }

        private void MettreAJourAffichage()
        {
            lblAffichage.Text = calculateur.Affichage;
            lblHistorique.Text = calculateur.Historique;
        }
    }
}

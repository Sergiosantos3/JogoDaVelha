namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        //Variáveis globais
        string jogadaatual = "X";
        public Form1()
        {
            InitializeComponent();
        }
        private void pibFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // fechar o programa
        }
        private void Jogada_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            botaoClicado.Text = jogadaatual;
            botaoClicado.Enabled = false;
            // Trocar de x para O e de O para X:
            if (jogadaatual == "X")
            {
                jogadaatual = "O";
                // Trocra a cor do labal
                lblinfo.ForeColor = Color.Green;
            }
            else
            {
                jogadaatual = "X";
                // Trocra a cor do labal
                lblinfo.ForeColor = Color.Red;
            }
            // Atualizar o labal:
            lblinfo.Text = $"É vez do {jogadaatual}";

            // Verificar vencedor
            verificarVencedor();
        }

        private void PibReiniciar_Click(object sender, EventArgs e)
        {
            jogadaatual= "X";
            lblinfo.Text = $"É vez do {jogadaatual}";
            lblinfo.ForeColor = Color.Red;

            // Resetar os botões:
            btn11.Enabled = true;
            btn11.Text = "";

            btn12.Enabled = true;
            btn12.Text = "";

            btn13.Enabled = true;
            btn13.Text = "";

            btn21.Enabled = true;
            btn21.Text = "";

            btn22.Enabled = true;
            btn22.Text = "";

            btn23.Enabled = true;
            btn23.Text = "";

            btn31.Enabled = true;
            btn31.Text = "";

            btn32.Enabled = true;
            btn32.Text = "";

            btn33.Enabled = true;
            btn33.Text = "";
        }
        public void verificarVencedor()
        {
            // Verificar linhas:
            if (btn11.Text == btn12.Text && btn12.Text == btn13.Text && btn11.Text != "")
            {
                /* ---
                 * zzz
                 * zzz
                 */
                lblinfo.Text = $"O vencedor é {btn11.Text}";
            }
            else if (btn21.Text == btn22.Text && btn22.Text == btn23.Text && btn21.Text != "")
            {
                /* zzz
                 * ---
                 * zzz
                 */
                lblinfo.Text = $"O vencedor é {btn21.Text}";
            }
            else if (btn31.Text == btn32.Text && btn32.Text == btn33.Text && btn31.Text != "")
            {
                /* zzz
                 * zzz
                 * ---
                 */
                lblinfo.Text = $"O vencedor é {btn31.Text}";
            }
            else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "")
            {
                /* -zz
                 * -zz
                 * -zz
                 */
                lblinfo.Text = $"O vencedor é {btn11.Text}";
            }
            else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "")
            {
                /* z-z
                 * z-z
                 * z-z
                 */
                lblinfo.Text = $"O vencedor é {btn12.Text}";
            }
            else if (btn13.Text == btn23.Text && btn23.Text == btn33.Text && btn13.Text != "")
            {
                /* zz-
                 * zz-
                 * zz-
                 */
                lblinfo.Text = $"O vencedor é {btn13.Text}";
            }
            else if (btn11.Text == btn22.Text && btn22.Text == btn33.Text && btn11.Text != "")
            {
                /* -zz
                 * z-z
                 * zz-
                 */
                lblinfo.Text = $"O vencedor é {btn11.Text}";
            }
            else if (btn13.Text == btn22.Text && btn22.Text == btn31.Text && btn13.Text != "")
            {
                /* zz-
                 * z-z
                 * -zz
                 */
                lblinfo.Text = $"O vencedor é {btn13.Text}";
            }//verificar se deu velha:
            else if(btn11.Enabled && btn12.Enabled && btn13.Enabled && btn21.Enabled && btn22.Enabled && btn23.Enabled && btn31.Enabled && btn32.Enabled
                && btn33.Enabled)
            {
                lblinfo.Text = "Empate!";
            }
        }
    }
}

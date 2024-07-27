namespace WinFormsAvaliacao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Arrays para armazenar os números e estrelas escolhidos pelo usuário.
        int[] apostaNums = new int[5];
        int[] apostaEst = new int[2];

        // Ficheiro de som a ser utilizado em caso de vitória
        System.Media.SoundPlayer vitoria = new System.Media.SoundPlayer(Properties.Resources.vitoria);
        System.Media.SoundPlayer derrota = new System.Media.SoundPlayer(Properties.Resources.derrota);

        #region IntroduçãoAposta

        // Evento KeyPress para o primeiro campo de número.
        private void txt_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla Enter foi pressionada.
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                // Validação do número inserido.
                if (int.TryParse(txt_num1.Text, out number) && number >= 1 && number <= 50)         // Caso o jogador introduza um input válido, actualizamos a informação apresentada e passamos ao proximo número
                {
                    apostaNums[0] = number;
                    txtbox_info.Text = "Os números da sua chave introduzida são:      " + number.ToString();
                    txt_num2.Enabled = true;
                    txt_num2.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 50!");            // Caso contrário, o programa alerta o jogador
                    txt_num1.Clear();
                    txt_num1.Focus(); // Foca-se novamente para nova tentativa.
                }
                e.Handled = true; // Previne outros processamentos da tecla Enter.
            }
        }

        // Restantes Eventos KeyPress seguem a mesma lógica
        private void txt_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                if (int.TryParse(txt_num2.Text, out number) && number >= 1 && number <= 50)
                {
                    apostaNums[1] = number;
                    txtbox_info.Text += " " + number.ToString();
                    txt_num3.Enabled = true;
                    txt_num3.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 50!");
                    txt_num2.Clear();
                    txt_num2.Focus();
                }
                e.Handled = true;
            }
        }

        private void txt_num3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                if (int.TryParse(txt_num3.Text, out number) && number >= 1 && number <= 50)
                {
                    apostaNums[2] = number;
                    txtbox_info.Text += " " + number.ToString();
                    txt_num4.Enabled = true;
                    txt_num4.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 50!");
                    txt_num3.Clear();
                    txt_num3.Focus();
                }
                e.Handled = true;
            }
        }


        private void txt_num4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                if (int.TryParse(txt_num4.Text, out number) && number >= 1 && number <= 50)
                {
                    apostaNums[3] = number;
                    txtbox_info.Text += " " + number.ToString();
                    txt_num5.Enabled = true;
                    txt_num5.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 50!");
                    txt_num4.Clear();
                    txt_num4.Focus();
                }
                e.Handled = true;
            }
        }

        private void txt_num5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                if (int.TryParse(txt_num5.Text, out number) && number >= 1 && number <= 50)
                {
                    apostaNums[4] = number;
                    txtbox_info.Text += " " + number.ToString();
                    txt_estrela1.Enabled = true;
                    txt_estrela1.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 50!");
                    txt_num5.Clear();
                    txt_num5.Focus();
                }
                e.Handled = true;
            }
        }

        // Evento KeyPress para o primeiro campo de estrela.
        private void txt_estrela1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                if (int.TryParse(txt_estrela1.Text, out number) && number >= 1 && number <= 12)
                {
                    apostaEst[0] = number;
                    txtbox_info.Text += "\r\nAs estrelas da sua chave são:      " + number.ToString();
                    txt_estrela2.Enabled = true;
                    txt_estrela2.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 12!");
                    txt_estrela1.Clear();
                    txt_estrela1.Focus();
                }
                e.Handled = true;
            }
        }

        // Evento KeyPress para o segundo campo de estrela.
        private void txt_estrela2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int number;
                if (int.TryParse(txt_estrela2.Text, out number) && number >= 1 && number <= 12)
                {
                    apostaEst[1] = number;
                    txtbox_info.Text += " " + number.ToString();
                    btn_Jogar.Enabled = true;
                    btn_Jogar.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido entre 1 e 12!");
                    txt_estrela2.Clear();
                    txt_estrela2.Focus();
                }
                e.Handled = true;
            }
        }

        #endregion


        #region Jogar
        // Método para gerar e verificar a chave vencedora.
        private void gerarVerificarChave()
        {
            // Arrays para a chave vencedora.
            int[] chaveNums = new int[5];
            int[] chaveEst = new int[2];
            // Contadores para numeros/estrelas certos.
            int numsCertos = 0;
            int estrCertos = 0;
            Random numAleatorio = new Random();
            string chave = "Números: ";

            // Geração de números.
            for (int i = 0; i < chaveNums.Length; i++)
            {
                int nAleatorio = numAleatorio.Next(1, 51);
                while (chaveNums.Contains(nAleatorio))
                {
                    nAleatorio = numAleatorio.Next(1, 51);
                }
                chaveNums[i] = nAleatorio;
                chave += $"{nAleatorio} ";
            }
            chave += "\n\rEstrelas: ";
            // Geração de estrelas.
            for (int i = 0; i < chaveEst.Length; i++)
            {
                int nAleatorio = numAleatorio.Next(1, 13);
                while (chaveEst.Contains(nAleatorio))
                {
                    nAleatorio = numAleatorio.Next(1, 13);
                }
                chaveEst[i] = nAleatorio;
                chave += $"{nAleatorio} ";
            }
            lbl_chaveVenc.Enabled = true;
            lbl_chaveVenc.Text = chave;

            // Verificação de numeros e estrelas
            for (int i = 0; i < chaveNums.Length; i++)
            {
                if (chaveNums.Contains(apostaNums[i]))
                {
                    numsCertos++;
                }
            }
            for (int i = 0; i < chaveEst.Length; i++)
            {
                if (chaveEst.Contains(apostaEst[i]))
                {
                    estrCertos++;
                }
            }

            txtbox_info.Text += "\r\n\r\n";


            // Apresentação dos resultados e verificação de prémios (ou nao existência de prémio)
            if (numsCertos > 0)
                txtbox_info.Text += $"Acertou {numsCertos} número(s)!\r\n";
            if (estrCertos > 0)
                txtbox_info.Text += $"Acertou {estrCertos} estrela(s)!\r\n\r\n";

            if (numsCertos == 5 && estrCertos == 2) 
            {
                vitoria.Play();
                txtbox_info.Text += "PARABÉNS!! Ganhou o 1º prémio!";
            }
            else if (numsCertos == 5 && estrCertos == 1)
            {
                vitoria.Play();
                txtbox_info.Text += "PARABÉNS!! Ganhou o 2º prémio!";
            }
            else if (numsCertos == 5 && estrCertos == 0)
            {
                vitoria.Play();
                txtbox_info.Text += "PARABÉNS!! Ganhou o 3º prémio!";
            }
            else if (numsCertos == 4 && estrCertos == 2)
            {
                vitoria.Play();
                txtbox_info.Text += "PARABÉNS!! Ganhou o 4º prémio!";
            }
            else if (numsCertos == 4 && estrCertos == 1)
            {
                vitoria.Play();
                txtbox_info.Text += "PARABÉNS!! Ganhou o 5º prémio!";
            }
            else if (numsCertos == 4 && estrCertos == 0)
            {
                vitoria.Play();
                txtbox_info.Text += "PARABÉNS!! Ganhou o 6º prémio!";
            }
            else
            {
                derrota.Play();
                txtbox_info.Text += "É pena, não ganhou nada... Volte a tentar :)";
            }
        }
        
        // Funcionalidade do botao Jogar
        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            lbl_chaveVenc.BackColor = Color.White;      // Ao jogar, após ter introduzido a sua aposta, o jogador passa a poder ver a chave vencedora
            gerarVerificarChave();
            btn_Jogar.Enabled = false;
            lbl_chaveVenc.Focus();
        }   

        #endregion


    }
}

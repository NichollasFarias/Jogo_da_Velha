using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP04_182348
{
    public partial class Form1 : Form
    {
        // ID dos jogadores: [X = 1] [O = 2]

        #region Variavel Global
        int Jogador = 0, cont = 0;
        int A = 0, B = 0, C = 0, D = 0, E = 0, F = 0, G = 0, H = 0, I = 0;
        int pontoX = 0, pontoO = 0;
        #endregion

        #region Iniciação
        public Form1()
        {
            InitializeComponent();
            Jogador = 1;
        }
        #endregion 

        #region Funções
        public void VezJogada()
        {
            if (Jogador == 1)
            {
                Jogador = 2;
                LB_Vez.Text = "É a vez do Jogador O";
            }
            else
            {
                Jogador = 1;
                LB_Vez.Text = "É a vez do Jogador X";
            }
        
        }

        public void Velha()
        {
            if (cont == 9)
            {
                MessageBox.Show("Deu Velha!");
                Recomeçar();
                cont = 0;
            }
            
        }

        public void Recomeçar()
        {
            VezJogada();
            cont = 0;
            BT_A.Enabled = true;
            BT_A.Text = "";
            BT_B.Enabled = true;
            BT_B.Text = "";
            BT_C.Enabled = true;
            BT_C.Text = "";
            BT_D.Enabled = true;
            BT_D.Text = "";
            BT_E.Enabled = true;
            BT_E.Text = "";
            BT_F.Enabled = true;
            BT_F.Text = "";
            BT_G.Enabled = true;
            BT_G.Text = "";
            BT_H.Enabled = true;
            BT_H.Text = "";
            BT_I.Enabled = true;
            BT_I.Text = "";

            A = 0; B = 0; C = 0; D = 0; E = 0; F = 0; G = 0; H = 0; I = 0;

        }
        #endregion

        #region Botões
        private void BT_A_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_A.Text = "X";
                BT_A.Enabled = false;
                A = 1;
            }
            else
            {
                BT_A.Text = "O";
                BT_A.Enabled = false;
                A = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            VerificarDiagonal();
            cont++;
            Velha();
            VezJogada();

        }

        private void BT_B_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_B.Text = "X";
                BT_B.Enabled = false;
                B = 1;
            }
            else
            {
                BT_B.Text = "O";
                BT_B.Enabled = false;
                B = 2;
            }
            VerificarVertical();
            VerificarHorizontal();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_C_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_C.Text = "X";
                BT_C.Enabled = false;
                C = 1;
            }
            else
            {
                BT_C.Text = "O";
                BT_C.Enabled = false;
                C = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            VerificarDiagonal();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_D_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_D.Text = "X";
                BT_D.Enabled = false;
                D = 1;
            }
            else
            {
                BT_D.Text = "O";
                BT_D.Enabled = false;
                D = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_E_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_E.Text = "X";
                BT_E.Enabled = false;
                E = 1;
            }
            else
            {
                BT_E.Text = "O";
                BT_E.Enabled = false;
                E = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            VerificarDiagonal();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_F_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_F.Text = "X";
                BT_F.Enabled = false;
                F = 1;
            }
            else
            {
                BT_F.Text = "O";
                BT_F.Enabled = false;
                F = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_G_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_G.Text = "X";
                BT_G.Enabled = false;
                G = 1;
            }
            else
            {
                BT_G.Text = "O";
                BT_G.Enabled = false;
                G = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            VerificarDiagonal();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_H_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_H.Text = "X";
                BT_H.Enabled = false;
                H = 1;
            }
            else
            {
                BT_H.Text = "O";
                BT_H.Enabled = false;
                H = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            cont++;
            Velha();
            VezJogada();
        }

        private void BT_I_Click(object sender, EventArgs e)
        {
            if (Jogador == 1)
            {
                BT_I.Text = "X";
                BT_I.Enabled = false;
                I = 1;
            }
            else
            {
                BT_I.Text = "O";
                BT_I.Enabled = false;
                I = 2;
            }
            VerificarHorizontal();
            VerificarVertical();
            VerificarDiagonal();
            cont++;
            Velha();
            VezJogada();
        }
        #endregion

        #region Botão Reiniciar
        private void BT_Reiniciar_Click(object sender, EventArgs e)
        {
            LB_O.Text = "0";
            LB_X.Text = "0";
            pontoO = 0;
            pontoX = 0;
            Jogador = 2;
            Recomeçar();
        }
        #endregion

        #region Verificar
        public void VerificarHorizontal()
        {

            #region ABC

            //X
            if (A == 1 && B == 1 && C == 1)
            {

              MessageBox.Show("Jogador X Ganhou!");
              pontoX++;
              LB_X.Text = pontoX.ToString();
              cont = 0;
              Recomeçar();

            }

            //O
            if (A == 2 && B == 2 && C == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

            #region DEF

            //X
            if (D == 1 && E == 1 && F == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (D == 2 && E == 2 && F == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

            #region GHI

            //X
            if (G == 1 && H == 1 && I == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (G == 2 && H == 2 && I == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

        }

        public void VerificarVertical()
        {

            #region ADG

            //X
            if (A == 1 && D == 1 && G == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (A == 2 && D == 2 && G == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

            #region BEH

            //X
            if (B == 1 && E == 1 && H == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (B == 2 && E == 2 && H == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

            #region CFI

            //X
            if (C == 1 && F == 1 && I == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (C == 2 && F == 2 && I == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

        }

        public void VerificarDiagonal()
        {

            #region AEI

            //X
            if (A == 1 && E == 1 && I == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (A == 2 && E == 2 && I == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

            #region CEG

            //X
            if (C == 1 && E == 1 && G == 1)
            {

                MessageBox.Show("Jogador X Ganhou!");
                pontoX++;
                LB_X.Text = pontoX.ToString();
                cont = 0;
                Recomeçar();

            }

            //O
            if (C == 2 && E == 2 && G == 2)
            {

                MessageBox.Show("Jogador O Ganhou!");
                pontoO++;
                LB_O.Text = pontoO.ToString();
                Jogador = 1;
                cont = 0;
                Recomeçar();

            }

            #endregion

        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Trabalho_2C
{
    public partial class FormPrincipal : Form
    {
    

        List<string>Respostas=new List<string>(); 
        List<string> Notas = new List<string>(); //Anotação da esquestão
        List<decimal> Tempos = new List<decimal>(); //tempo por questão
        List<int> EstadoQuestao = new List<int>(); // Salva se a questão: está marcada, pulada ou respondida;

        RadioButton Rb;
        Visualizar vs;

        int NumbOfQuestions, count = 0;
        decimal Time, TimeStartQuestion = 0;
        bool finalizado=false;
        public FormPrincipal(int Qnt,decimal time)
        {
            
            InitializeComponent();

            NumbOfQuestions = Qnt;
            Time = time;

            lblQntQ.Text = Convert.ToString(count + 1) + "/" + Qnt.ToString();
            lblTime.Text = Convert.ToString(Math.Floor(Time/60))+":"+Convert.ToString(time%60);

            SetListas();
            Question();

            vs = new Visualizar(EstadoQuestao);

            this.ShowDialog();
         
        }

        private void SetListas()
        {
            //Necessário adicionar posições vazias nas listas para o funcionamento do código
            for (int i = 0; i < NumbOfQuestions; i++)
            {
                Respostas.Add(" ");
                Notas.Add(" ");
                Tempos.Add(0);
                EstadoQuestao.Add(0);
            }

        }

        private void Question()
        {
            // Monta a questão
            txtEnunciado.Text = Questão.list[count].enunciado;
            rdbA.Text = Questão.list[count].altA;
            rdbB.Text = Questão.list[count].altB;
            rdbC.Text = Questão.list[count].altC;
            rdbD.Text = Questão.list[count].altD;
            rdbE.Text = Questão.list[count].altE;

            TimeStartQuestion = Time;

        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            SaveAnotacao();
            Clean();

            count++;

            if (count==Respostas.Count)
                Finalizar();

            if (count < NumbOfQuestions)
            {
                QuestionTime();
                Question();
                lblQntQ.Text = Convert.ToString(count+1) + "/" + NumbOfQuestions.ToString();
                txtNotas.Text = Notas[count];
            }

            if (count == NumbOfQuestions - 1)
                btnProximaPergunta.Text = "Finalizar";
            else
                btnProximaPergunta.Text = "Próxima pergunta";




        }
        private void Finalizar() {
            finalizado = true;
            FormResult result= new FormResult(Respostas, Tempos);
            this.Hide();
            result.ShowDialog();
            result.Close();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if(count!=0)
                Clean();

            if (count > 0)
            {
                QuestionTime();
                count--;
                txtNotas.Text = Notas[count];
                Question();
                lblQntQ.Text = Convert.ToString(count + 1) + "/" + NumbOfQuestions.ToString();
                btnProximaPergunta.Text = "Próxima pergunta";
            }

        }


        private void QuestionTime()
        {
            Tempos[count]+= Time-TimeStartQuestion;
        }

        private void Resposta_CheckedChanged(object sender, EventArgs e)
        {
            //Guarda a resposta do usuário e muda o estado da questão 
            Rb = (RadioButton)sender;
            Respostas[count] = Rb.Tag.ToString();
            EstadoQuestao[count] = 1;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time -= 1;
            if (Time == 0 && finalizado==false)
                Finalizar();
            lblTime.Text = Convert.ToString(Math.Floor(Time / 60)) + ":" + Convert.ToString(Time % 60);
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (EstadoQuestao[count] != -1)
                EstadoQuestao[count] = -1;

        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                vs.Show();
                vs.Atualizar(EstadoQuestao);
            }
            catch
            {
                vs = new Visualizar(EstadoQuestao);
                vs.Show();
            }   
        }

        private void SaveAnotacao()
        {
            Notas[count]=txtNotas.Text;
        }
        private void Clean()
        {
            if(Rb != null)
                Rb.Checked = false;
            txtNotas.Text = " ";

        }
    }
}

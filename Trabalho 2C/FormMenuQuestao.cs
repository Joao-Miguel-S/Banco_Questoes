using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Trabalho_2C
{
    public partial class FormMenuQuestao : Form
    {

        List<string> diretorios= new List<string>();
        string CaminhoDiretorioQ;
     
        public FormMenuQuestao()
        {
            InitializeComponent();
            GetCaminhoDiretorioQ();
            Pastas();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            Questão.list.Clear();

            if(rbRandom.Checked)
                IsRandomQuestion();
            else
                IsPersoQuestion();
        }
        void IsRandomQuestion()
        {
            if (rbHumanas.Checked)
                QuestoesAleat(rbHumanas.Text);
            else if (rbExatas.Checked)
                QuestoesAleat(rbExatas.Text);
            else if (rdMista.Checked)
                MistaQuestao();
        }
        void IsPersoQuestion()
        {
 
            string Diretorio= CaminhoDiretorioQ;

            if (diretorios.Contains(Diretorio + @"Humanas\" + cBPastas.Text))
                Diretorio += @"Humanas\" + cBPastas.Text;
            else
                Diretorio += @"Exatas\" + cBPastas.Text;

            if (CriarBateriaQuestao(Diretorio))
            {
                this.Hide();
                FormPrincipal Principal = new FormPrincipal(Questão.list.Count, nudTimer.Value);
                this.Close();
            }
        }
        private void QuestoesAleat(string txt) // preparar as pastas que vão ser utilizadas para pegar as questões e permitir o inicio das questoes
        {
            List<string> PastasNUsadas = new List<string>();
            string DiretorioTemp;

            DiretorioTemp = CaminhoDiretorioQ+txt+@"\";
            PastasNUsadas.AddRange(Directory.GetDirectories(DiretorioTemp));


            if (CriarBateriaQuestao(PastasNUsadas))
            {
                this.Hide();
                FormPrincipal Principal = new FormPrincipal(Questão.list.Count, nudTimer.Value);
                this.Close();
            }


        }
        private void MistaQuestao()
        {
            List <string> MateriasPastas= new List<string>();
            string[] Pastas = { @"\Humanas", @"\Exatas" };
            string temp;

            foreach(string x in Pastas)
            {
                temp = CaminhoDiretorioQ+x;
                MateriasPastas.AddRange(Directory.GetDirectories(temp));
            }

            if (CriarBateriaQuestao(MateriasPastas))
            {
                this.Hide();
                FormPrincipal Principal = new FormPrincipal(Questão.list.Count, nudTimer.Value);
                this.Close();
            }

        }
        private bool CriarBateriaQuestao(List<string> PastasNUsadas)
        {
            List<string> Questoes = new List<string>();
            int QntQuestoes, index, SaveOldCount;

            foreach (string path in PastasNUsadas)
            {
                DirectoryInfo info = new DirectoryInfo(path);
                foreach (FileInfo x in info.GetFiles().ToList())
                    Questoes.Add(path+ @"\"+x);
            }
           
            QntQuestoes = Convert.ToInt32(nudQt.Value);
            SaveOldCount = Questoes.Count;

            for (int j = 0; j < QntQuestoes; j++)
            {

                index = RandomNumber(Questoes.Count);
                //necessidade do try, pois pode existir pastas sem questões
                try
                {
                    CriarObjQuestao(Questoes[index]);
                }
                catch
                {
                    MessageBox.Show("Pasta sem questões, selecione outra");
                    return false;
                }

                Questoes.RemoveAt(index);
                if (Questoes.Count == 0 && QntQuestoes != SaveOldCount)
                {
                    MessageBox.Show("Não há questões o suficiente, essa bateria conterá: " + (j + 1).ToString() + " questões");
                    return true;
                }

            }
            return true;
        }
        private bool CriarBateriaQuestao(string PastaUsada)
        {
            // Essa funçao cria uma bateria de questões dada um pasta de matéria
            // necessidade de ser bool, pois, caso seja possível criar uma bateria, permitira o inicio  das questões
            List<FileInfo> Questoes = new List<FileInfo>();
            DirectoryInfo info = new DirectoryInfo(PastaUsada);
            int QntQuestoes,index,SaveOldCount;

            QntQuestoes = Convert.ToInt32(nudQt.Value);
            Questoes = info.GetFiles().ToList();
            SaveOldCount = Questoes.Count;

            for (int j=0;j< QntQuestoes; j++)
            {

                index = RandomNumber(Questoes.Count);
                //necessidade do try, pois pode existir pastas sem questões
                try
                {
                    CriarObjQuestao(PastaUsada+ @"\"+ Questoes[index]);
                }
                catch
                {
                    MessageBox.Show("Pasta sem questões, selecione outra");
                    return false;
                }

                Questoes.RemoveAt(index);
                if (Questoes.Count == 0 && QntQuestoes!= SaveOldCount)
                {
                    MessageBox.Show("Não há questões o suficiente, essa bateria conterá: "+(j+1).ToString()+" questões");
                    return true;
                }

            }
            return true;
        }
        private void CriarObjQuestao(string path)
        {
            StreamReader leitor = new StreamReader(path);
            string enunciado, altA, altB, altC, altD, altE, resp;

            enunciado = leitor.ReadLine();
            altA = leitor.ReadLine();
            altB = leitor.ReadLine();
            altC = leitor.ReadLine();
            altD = leitor.ReadLine();
            altE = leitor.ReadLine();
            resp = leitor.ReadLine();
            leitor.Close();

            Questão q = new Questão(enunciado, altA, altB, altC, altD, altE, resp, path);
            Questão.list.Add(q);
        }
        private int RandomNumber(int max)
        {
            Random rnd=new Random();
            return rnd.Next(max);
        }
        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            panelPerso.Visible = false;
            panelAle.Visible = true;
        }
        private void rbdPerso_CheckedChanged(object sender, EventArgs e)
        {
            panelAle.Visible = false;
            panelPerso.Visible = true;

        }
        private void Pastas()
        {
            // adiciona os nomes das pastas na comboBox
            string[] caminho = { @"Exatas\", @"Humanas\" };
            string Diretorio;

            for (int j = 0; j < 2; j++)
            {
                Diretorio = CaminhoDiretorioQ;
                Diretorio += caminho[j];
                string[] Ediretorios = Directory.GetDirectories(Diretorio);

                for (int i = 0; i < Ediretorios.Length; i++)
                {
                    string nomeDaDisciplina = Ediretorios[i].Remove(0, Diretorio.Length);
                    cBPastas.Items.Add(nomeDaDisciplina);
                }

                diretorios.AddRange(Ediretorios);
            }

        }
        private void GetCaminhoDiretorioQ()
        {
            CaminhoDiretorioQ = Directory.GetCurrentDirectory();
            CaminhoDiretorioQ += @"\..\..\..\Questões\";
        }

    }
}

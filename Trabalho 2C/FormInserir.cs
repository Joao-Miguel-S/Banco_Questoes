using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Trabalho_2C
{
    public partial class FormInserir : Form
    {
        string CorrectAlt="";
        string diretorioAtual;
        string Pasta="";
        string type = "";
        RadioButton Btn;
        RadioButton TypeBtn;
        public FormInserir()
        {
            InitializeComponent();
            ResetDiretorioAtual();
            Pastas();
        }

        private void btnNewQ_Click(object sender, EventArgs e)
        {
            AddArq();
        }

        private void btnNewD_Click(object sender, EventArgs e)
        {
            string Diretorio = diretorioAtual + type;
            string Path = Diretorio + NewDirec.Text;

            if (type != "")
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                    MessageBox.Show("Diretório Criado");
                    Pastas();
                }

                else
                    MessageBox.Show("Pasta já exite");
            }

            CleanD();
  
        }
        private void AddArq()
        {
            if(Pasta!=""&& CorrectAlt != "")
            {
                string Path = diretorioAtual + Pasta+ FindNewestFile();
                StreamWriter Writer = new StreamWriter(Path);
                Writer.WriteLine(TratarTxt(txtEnun.Text));
                Writer.WriteLine(TratarTxt(txtA.Text));
                Writer.WriteLine(TratarTxt(txtB.Text));
                Writer.WriteLine(TratarTxt(txtC.Text));
                Writer.WriteLine(TratarTxt(txtD.Text));
                Writer.WriteLine(TratarTxt(txtE.Text));
                Writer.WriteLine(CorrectAlt);
                Writer.WriteLine(txtReso.Text);
                Writer.WriteLine(0);//acertos
                Writer.WriteLine(0);//erros

                Writer.Close();
                CleanQ();
                MessageBox.Show("Questão criada com sucesso!");
            }
            else
                MessageBox.Show("Parametro não preenchido");

        }
        
        private void Pastas()
        {
            string Diretorio;
            cmbPastas.Items.Clear();
            string[] caminho = {@"Exatas\", @"Humanas\" };
            for(int j = 0; j < 2; j++){

                Diretorio = diretorioAtual;
                Diretorio += caminho[j];
                string[] diretorios = Directory.GetDirectories(Diretorio);

                for (int i = 0; i < diretorios.Length; i++)
                {
                    string nomeDaDisciplina = diretorios[i].Remove(0, Diretorio.Length);
                    cmbPastas.Items.Add(nomeDaDisciplina);
                }
   
            }
  
        }

        private void cmbPastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleciona a pasta que será salva a questão
            ComboBox Cbm = (ComboBox)sender;
            if(Directory.Exists(diretorioAtual+@"Humanas\"+Cbm.Text))
                Pasta = @"Humanas\"+Cbm.Text;
            else
                Pasta = @"Exatas\" + Cbm.Text;
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            Btn = (RadioButton)sender;
            CorrectAlt = Btn.Text;
           
        }

        private void CleanQ()
        {
            txtA.Text="";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtE.Text = "";
            txtEnun.Text = "";
            txtReso.Text = "";
            CorrectAlt = "";
            Pasta = "";
            Btn.Checked= false;
        }

        private void CleanD()
        {
            NewDirec.Text = "";
            type = "";
            TypeBtn.Checked = false;
        }

        private string FindNewestFile()
        {
            // função possui o objetivo de gerar um nome de arquivo 
            int temp,Index,Lenght;
            string FileName;

            DirectoryInfo info = new DirectoryInfo(diretorioAtual + Pasta);
            try
            {
                // caso haja um arquivo na pasta, o novo será nomeado somando-se o valor
                // arquivos txt são nomeado por números

                FileInfo[] files = info.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
                FileName = files[0].Name;

                Index=FileName.IndexOf(".");
                Lenght = FileName.Length-Index;

                temp = Convert.ToInt32(FileName.Remove(Index, Lenght));
                temp++;
            }
            catch
            {
                temp = 0;
            }
            FileName= @"\"+temp.ToString()+".txt";
       
            return FileName;
        }

        private void TypeSubject_CheckedChanged(object sender, EventArgs e)
        {
            //Seleciona onde a pasta estará salva entre humanas e exatas
            TypeBtn = (RadioButton)sender;
            type = TypeBtn.Text+@"\";
        }

        private void ResetDiretorioAtual()
        {
            // Garante que possuirá o caminho para o diretório onde se econtrar a pasta questões
            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\..\..\..\Questões\";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novo diretório serve para criar pastas de matérias como: Artes, Música etc \n" +
                "Nova Questão é o local onde criará questões novas\n" +
                "Pastas existentes são mostradas no icone ao lado da frase pasta");
        }
        string TratarTxt(string txt)
        {
            string replacement = Regex.Replace(txt, @"\t|\n|\r", "");
            return replacement;
        }
    }
}

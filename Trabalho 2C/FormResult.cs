using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2C
{
    public partial class FormResult : Form
    {
        List<string> respostas = new List<string>();
        List<decimal> times = new List<decimal>();

        //Monto dinamicamente 
        readonly int SizeX= 200, SizeY=22;
        readonly int PositionInicial_X = 32, PositionInicial_Y= 256; 
        readonly int ConstanteX = 250, ConstanteY=28;

        int cont = 0;
        public FormResult(List<string> Respostas,List<decimal> Tempos) 
        {
            InitializeComponent();

            respostas = Respostas;
            times = Tempos;
            

            MontarGabarito();
            MontarMedias();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string diretorioAtual = Directory.GetCurrentDirectory();
            DateTime thisDay = DateTime.Today;

            
            diretorioAtual += @"\..\..\..\Salvos\"+ txtNome.Text+"_"+ thisDay.Day + "_" + thisDay.Month + "_" + thisDay.Year+ ".txt";

            StreamWriter Writer= new StreamWriter(diretorioAtual);
            for(int i=0;i< respostas.Count;i++)
                Writer.Write(respostas[i]);
            Writer.WriteLine();

            for (int i = 0; i < respostas.Count; i++)
                Writer.Write(Questão.list[i].resp);
            Writer.WriteLine();

            Writer.WriteLine(txtTotal.Text);
            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\..\..\..\Questões\";

            for (int i = 0; i < respostas.Count; i++)
            {
                string path = Questão.list[i].path;
                path=path.Remove(0, diretorioAtual.Length+7);
                Writer.WriteLine(path);
            }
            Writer.WriteLine(txtAcertos.Text);
            Writer.WriteLine(txtMediaTempo.Text);
            
            Writer.Close();
            MessageBox.Show("Salvo");
            this.Close();
        }

        private void MontarGabarito()
        {
            //Monta dinamicamente a interface que mostra o gabarito e a resposta do usuário

            int Px = PositionInicial_X;
            int Py = PositionInicial_Y;
            cont = 0;
            int temp = 1;
            foreach (string resposta in respostas)
            {
                TextBox tb = new TextBox();
                tb.Text ="Questão "+temp.ToString()+"| Resposta: "+ resposta + " |Gabarito: "+ Questão.list[cont].resp;
                tb.Size = new Size(SizeX, SizeY);
                tb.Location = new Point(Px, Py);

                if (resposta == Questão.list[cont].resp)
                    tb.BackColor = Color.LightGreen;
                else
                    tb.BackColor = Color.Red;

                tb.ReadOnly = true;
                Controls.Add(tb);
                tb.Visible = true;

                Px += ConstanteX;

                cont++;
                temp++;

                if (temp % 3 == 0)
                {
                    Px = PositionInicial_X;
                    Py += ConstanteY;
                }
                

            }
        }
        private void MontarMedias()
        {
            //monta dados como total de acertos
            int Acertos=0;
            decimal MediaHorario = 0;
           

            for(int i = 0; i < Questão.list.Count; i++)
                if (Questão.list[i].resp == respostas[i])
                    Acertos++;
            for (int i = 0; i < times.Count; i++)
                MediaHorario += times[i];

        
            MediaHorario = MediaHorario / times.Count;

            txtAcertos.Text =Acertos.ToString();
            txtMediaTempo.Text= MediaHorario.ToString();
            txtTotal.Text= respostas.Count.ToString();

        }
    }
}

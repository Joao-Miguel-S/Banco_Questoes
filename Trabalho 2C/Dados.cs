using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho_2C
{
    public partial class Dados : Form
    { 
        string diretorioAtual;
        readonly int PostionX = 32, PositionY = 167;
        readonly int ConstanteX = 260, ConstanteY = 28;
        readonly int SizeX = 176, SizeY = 22;
        int ControlNumber;
        List<System.Windows.Forms.TextBox> textBoxes= new List<System.Windows.Forms.TextBox>();

        public Dados()
        {
            InitializeComponent();
            Pastas();
            ControlNumber = Controls.Count;
        }

        private void Pastas()
        {
            cbmAqr.Items.Clear();


            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\..\..\..\Salvos\";
            DirectoryInfo info = new DirectoryInfo(diretorioAtual);
            FileInfo[] Files = info.GetFiles().ToArray();

             for (int i = 0; i < Files.Length; i++)
             {
                string NomedoArquivo = Files[i].Name;
                cbmAqr.Items.Add(NomedoArquivo);
             }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string Gabaritos,Resultados, Acertos, MediaTempo, Total;
            List<string> paths= new List<string>();
            int temp;

            if (cbmAqr.Text == " " || cbmAqr.Text == null)
                return;
            try
            {
                StreamReader reader = new StreamReader(diretorioAtual + cbmAqr.Text);

                Resultados = reader.ReadLine();
                Gabaritos = reader.ReadLine();
                Total = reader.ReadLine();

                temp = Convert.ToInt32(Total);
                for (int i = 0; i < temp; i++)
                    paths.Add(reader.ReadLine());

                Acertos = reader.ReadLine();
                MediaTempo = reader.ReadLine();

                reader.Close();
                CreateDados(Resultados, Gabaritos, Acertos, MediaTempo, Total, paths);
            }
            catch (Exception ex) {}

        }

        private void CreateDados(string Gabaritos, string Resultados, string Acertos, string MediaTempo, string Total,List<string>Path)
        {
            cleanForms();
            int Px = PostionX, Py = PositionY;
            for(int j=0;j<3;j++) 
            {

                for(int i = 0; i < Gabaritos.Length; i++)
                {

                    System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                    if(j==0)
                        tb.Text = Resultados[i].ToString();
                    if(j== 1)
                        tb.Text = Gabaritos[i].ToString();
                    if(j==2)
                        tb.Text = Path[i];

                    tb.Size = new Size(SizeX, SizeY);
                    tb.Location = new Point(Px, Py);
                    tb.ReadOnly = true;
                    Controls.Add(tb);
                    tb.Visible = true;

                    Py += ConstanteY;
                }
                Py = PositionY;
                Px += ConstanteX;
            }
            lblAcertos.Text = "Acertos " + Acertos;
            lblMediaT.Text = "Tempo Médio " + MediaTempo;
        }

        void cleanForms()
        {
            int NewControlNumber = Controls.Count;
            for (int x=0;x< NewControlNumber - ControlNumber;x++)
                Controls.RemoveAt(ControlNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho_2C
{
    public partial class Visualizar : Form
    {
        readonly int SizeX = 226, SizeY = 22;
        readonly int PositionX = 257,ConstanteY=28;
        int PositionY = 55;

        List<System.Windows.Forms.TextBox> TextBoxes = new List<System.Windows.Forms.TextBox>();
        public Visualizar(List<int> Estado)
        {
            InitializeComponent();
            CriarEstado(Estado);
        }

        public void Atualizar(List<int> Estado)
        {
            int i = 0;
            foreach(System.Windows.Forms.TextBox textBox in TextBoxes)
            {

                if (Estado[i] == -1)
                    textBox.BackColor = Color.Red;
                if (Estado[i] == 1)
                    textBox.BackColor = Color.Green;
                if (Estado[i] == 0)
                    textBox.BackColor = Color.Yellow;
                i++;
            }
            
        }
        public void CriarEstado(List<int> Estado)
        {
            int i = 1;
            foreach(int estado in Estado)
            {
                System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                tb.Text = "Questão: " + i.ToString();
                tb.Size = new Size(SizeX, SizeY);
                tb.Location = new Point(PositionX, PositionY);

                if (estado == -1)
                    tb.BackColor = Color.Red;
                if (estado == 1)
                    tb.BackColor = Color.Green;
                if (estado == 0)
                    tb.BackColor = Color.Yellow;
                TextBoxes.Add(tb);
                Controls.Add(tb);
                tb.Visible = true;
                PositionY += ConstanteY;
                i++;
                
            }
        }
    }
}

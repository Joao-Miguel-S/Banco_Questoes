using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2C
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnQuestao_Click(object sender, EventArgs e)
        {
            FormMenuQuestao formP = new FormMenuQuestao();
            this.Hide();
            formP.ShowDialog();
            formP.Close();
            this.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormInserir formI= new FormInserir();
            this.Hide();
            formI.ShowDialog();
            formI.Close();
            this.Show();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            Dados formD = new Dados();
            this.Hide();
            formD.ShowDialog();
            formD.Close();
            this.Show();
        }

    }
}

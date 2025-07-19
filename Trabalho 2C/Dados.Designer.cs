namespace Trabalho_2C
{
    partial class Dados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbmAqr = new System.Windows.Forms.ComboBox();
            this.Arqvos = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblMediaT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbmAqr
            // 
            this.cbmAqr.FormattingEnabled = true;
            this.cbmAqr.Location = new System.Drawing.Point(152, 28);
            this.cbmAqr.Name = "cbmAqr";
            this.cbmAqr.Size = new System.Drawing.Size(227, 24);
            this.cbmAqr.TabIndex = 0;
            // 
            // Arqvos
            // 
            this.Arqvos.AutoSize = true;
            this.Arqvos.Location = new System.Drawing.Point(64, 36);
            this.Arqvos.Name = "Arqvos";
            this.Arqvos.Size = new System.Drawing.Size(60, 16);
            this.Arqvos.TabIndex = 1;
            this.Arqvos.Text = "Arquivos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(415, 29);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Location = new System.Drawing.Point(207, 114);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(53, 16);
            this.lblAcertos.TabIndex = 6;
            this.lblAcertos.Text = "Acertos";
            // 
            // lblMediaT
            // 
            this.lblMediaT.AutoSize = true;
            this.lblMediaT.Location = new System.Drawing.Point(499, 114);
            this.lblMediaT.Name = "lblMediaT";
            this.lblMediaT.Size = new System.Drawing.Size(92, 16);
            this.lblMediaT.TabIndex = 7;
            this.lblMediaT.Text = "Tempo Médio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resposta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gabrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(781, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Arquivo";
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMediaT);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.Arqvos);
            this.Controls.Add(this.cbmAqr);
            this.Name = "Dados";
            this.Text = "Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmAqr;
        private System.Windows.Forms.Label Arqvos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblMediaT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
namespace Trabalho_2C
{
    partial class FormMenuQuestao
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
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.cBPastas = new System.Windows.Forms.ComboBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rbExatas = new System.Windows.Forms.RadioButton();
            this.rbHumanas = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbdPerso = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAle = new System.Windows.Forms.Panel();
            this.rdMista = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panelPerso = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQt)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelAle.SuspendLayout();
            this.panelPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTimer
            // 
            this.nudTimer.Location = new System.Drawing.Point(200, 116);
            this.nudTimer.Maximum = new decimal(new int[] {
            330,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(121, 22);
            this.nudTimer.TabIndex = 0;
            this.nudTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cBPastas
            // 
            this.cBPastas.FormattingEnabled = true;
            this.cBPastas.Location = new System.Drawing.Point(160, 78);
            this.cBPastas.Name = "cBPastas";
            this.cBPastas.Size = new System.Drawing.Size(121, 24);
            this.cBPastas.TabIndex = 1;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(140, 176);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(82, 20);
            this.rbRandom.TabIndex = 2;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Aleatório";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area de questões";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo (em minuto)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pasta de Questões";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantidade de Questões";
            // 
            // nudQt
            // 
            this.nudQt.Location = new System.Drawing.Point(200, 56);
            this.nudQt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQt.Name = "nudQt";
            this.nudQt.Size = new System.Drawing.Size(120, 22);
            this.nudQt.TabIndex = 8;
            this.nudQt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Personalizadas";
            // 
            // rbExatas
            // 
            this.rbExatas.AutoSize = true;
            this.rbExatas.Location = new System.Drawing.Point(17, 60);
            this.rbExatas.Name = "rbExatas";
            this.rbExatas.Size = new System.Drawing.Size(69, 20);
            this.rbExatas.TabIndex = 14;
            this.rbExatas.TabStop = true;
            this.rbExatas.Text = "Exatas";
            this.rbExatas.UseVisualStyleBackColor = true;
            // 
            // rbHumanas
            // 
            this.rbHumanas.AutoSize = true;
            this.rbHumanas.Location = new System.Drawing.Point(17, 100);
            this.rbHumanas.Name = "rbHumanas";
            this.rbHumanas.Size = new System.Drawing.Size(86, 20);
            this.rbHumanas.TabIndex = 3;
            this.rbHumanas.TabStop = true;
            this.rbHumanas.Text = "Humanas";
            this.rbHumanas.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(167, 394);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(456, 45);
            this.btnIniciar.TabIndex = 15;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbdPerso);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.nudQt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nudTimer);
            this.panel3.Controls.Add(this.rbRandom);
            this.panel3.Location = new System.Drawing.Point(12, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 244);
            this.panel3.TabIndex = 16;
            // 
            // rbdPerso
            // 
            this.rbdPerso.AutoSize = true;
            this.rbdPerso.Location = new System.Drawing.Point(228, 174);
            this.rbdPerso.Name = "rbdPerso";
            this.rbdPerso.Size = new System.Drawing.Size(122, 20);
            this.rbdPerso.TabIndex = 10;
            this.rbdPerso.TabStop = true;
            this.rbdPerso.Text = "Personalizadas";
            this.rbdPerso.UseVisualStyleBackColor = true;
            this.rbdPerso.CheckedChanged += new System.EventHandler(this.rbdPerso_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo de questão:";
            // 
            // panelAle
            // 
            this.panelAle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAle.Controls.Add(this.rdMista);
            this.panelAle.Controls.Add(this.label8);
            this.panelAle.Controls.Add(this.rbExatas);
            this.panelAle.Controls.Add(this.rbHumanas);
            this.panelAle.Location = new System.Drawing.Point(520, 129);
            this.panelAle.Name = "panelAle";
            this.panelAle.Size = new System.Drawing.Size(155, 189);
            this.panelAle.TabIndex = 17;
            this.panelAle.Visible = false;
            // 
            // rdMista
            // 
            this.rdMista.AutoSize = true;
            this.rdMista.Location = new System.Drawing.Point(17, 138);
            this.rdMista.Name = "rdMista";
            this.rdMista.Size = new System.Drawing.Size(60, 20);
            this.rdMista.TabIndex = 15;
            this.rdMista.TabStop = true;
            this.rdMista.Text = "Mista";
            this.rdMista.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Aleatório";
            // 
            // panelPerso
            // 
            this.panelPerso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerso.Controls.Add(this.label4);
            this.panelPerso.Controls.Add(this.label3);
            this.panelPerso.Controls.Add(this.cBPastas);
            this.panelPerso.Location = new System.Drawing.Point(451, 129);
            this.panelPerso.Name = "panelPerso";
            this.panelPerso.Size = new System.Drawing.Size(290, 194);
            this.panelPerso.TabIndex = 18;
            this.panelPerso.Visible = false;
            // 
            // FormMenuQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 567);
            this.Controls.Add(this.panelPerso);
            this.Controls.Add(this.panelAle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuQuestao";
            this.Text = "Questões";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQt)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAle.ResumeLayout(false);
            this.panelAle.PerformLayout();
            this.panelPerso.ResumeLayout(false);
            this.panelPerso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.ComboBox cBPastas;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHumanas;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.RadioButton rbExatas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbdPerso;
        private System.Windows.Forms.Panel panelAle;
        private System.Windows.Forms.RadioButton rdMista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPerso;
    }
}
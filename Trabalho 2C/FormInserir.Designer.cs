namespace Trabalho_2C
{
    partial class FormInserir
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
            this.components = new System.ComponentModel.Container();
            this.NewDirec = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblDirec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rnbExatas = new System.Windows.Forms.RadioButton();
            this.rnbHumanas = new System.Windows.Forms.RadioButton();
            this.btnNewD = new System.Windows.Forms.Button();
            this.lblD = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cmbPastas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewQ = new System.Windows.Forms.Button();
            this.txtReso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.lblEnum = new System.Windows.Forms.Label();
            this.txtEnun = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewDirec
            // 
            this.NewDirec.Location = new System.Drawing.Point(17, 53);
            this.NewDirec.Name = "NewDirec";
            this.NewDirec.Size = new System.Drawing.Size(229, 22);
            this.NewDirec.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Location = new System.Drawing.Point(103, 33);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(94, 16);
            this.lblDirec.TabIndex = 2;
            this.lblDirec.Text = "Novo Diretório";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rnbExatas);
            this.panel1.Controls.Add(this.rnbHumanas);
            this.panel1.Controls.Add(this.btnNewD);
            this.panel1.Controls.Add(this.lblD);
            this.panel1.Controls.Add(this.NewDirec);
            this.panel1.Location = new System.Drawing.Point(26, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 221);
            this.panel1.TabIndex = 3;
            // 
            // rnbExatas
            // 
            this.rnbExatas.AutoSize = true;
            this.rnbExatas.Location = new System.Drawing.Point(177, 173);
            this.rnbExatas.Name = "rnbExatas";
            this.rnbExatas.Size = new System.Drawing.Size(69, 20);
            this.rnbExatas.TabIndex = 8;
            this.rnbExatas.TabStop = true;
            this.rnbExatas.Text = "Exatas";
            this.rnbExatas.UseVisualStyleBackColor = true;
            this.rnbExatas.CheckedChanged += new System.EventHandler(this.TypeSubject_CheckedChanged);
            // 
            // rnbHumanas
            // 
            this.rnbHumanas.AutoSize = true;
            this.rnbHumanas.Location = new System.Drawing.Point(17, 173);
            this.rnbHumanas.Name = "rnbHumanas";
            this.rnbHumanas.Size = new System.Drawing.Size(86, 20);
            this.rnbHumanas.TabIndex = 7;
            this.rnbHumanas.TabStop = true;
            this.rnbHumanas.Text = "Humanas";
            this.rnbHumanas.UseVisualStyleBackColor = true;
            this.rnbHumanas.CheckedChanged += new System.EventHandler(this.TypeSubject_CheckedChanged);
            // 
            // btnNewD
            // 
            this.btnNewD.Location = new System.Drawing.Point(70, 95);
            this.btnNewD.Name = "btnNewD";
            this.btnNewD.Size = new System.Drawing.Size(115, 49);
            this.btnNewD.TabIndex = 6;
            this.btnNewD.Text = "Enviar";
            this.btnNewD.UseVisualStyleBackColor = true;
            this.btnNewD.Click += new System.EventHandler(this.btnNewD_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(77, 34);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(94, 16);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "Novo Diretório";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.cmbPastas);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.btnNewQ);
            this.panel.Controls.Add(this.txtReso);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.rbE);
            this.panel.Controls.Add(this.rbD);
            this.panel.Controls.Add(this.rbC);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.txtE);
            this.panel.Controls.Add(this.txtD);
            this.panel.Controls.Add(this.txtC);
            this.panel.Controls.Add(this.txtB);
            this.panel.Controls.Add(this.txtA);
            this.panel.Controls.Add(this.rbB);
            this.panel.Controls.Add(this.rbA);
            this.panel.Controls.Add(this.lblEnum);
            this.panel.Controls.Add(this.txtEnun);
            this.panel.Location = new System.Drawing.Point(346, 52);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(442, 568);
            this.panel.TabIndex = 4;
            // 
            // cmbPastas
            // 
            this.cmbPastas.FormattingEnabled = true;
            this.cmbPastas.Location = new System.Drawing.Point(158, 419);
            this.cmbPastas.Name = "cmbPastas";
            this.cmbPastas.Size = new System.Drawing.Size(265, 24);
            this.cmbPastas.TabIndex = 27;
            this.cmbPastas.SelectedIndexChanged += new System.EventHandler(this.cmbPastas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pasta";
            // 
            // btnNewQ
            // 
            this.btnNewQ.Location = new System.Drawing.Point(42, 524);
            this.btnNewQ.Name = "btnNewQ";
            this.btnNewQ.Size = new System.Drawing.Size(381, 28);
            this.btnNewQ.TabIndex = 24;
            this.btnNewQ.Text = "Enviar";
            this.btnNewQ.UseVisualStyleBackColor = true;
            this.btnNewQ.Click += new System.EventHandler(this.btnNewQ_Click);
            // 
            // txtReso
            // 
            this.txtReso.Location = new System.Drawing.Point(137, 474);
            this.txtReso.Multiline = true;
            this.txtReso.Name = "txtReso";
            this.txtReso.Size = new System.Drawing.Size(286, 33);
            this.txtReso.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Correta";
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(42, 364);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(37, 20);
            this.rbE.TabIndex = 21;
            this.rbE.TabStop = true;
            this.rbE.Text = "E";
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(41, 308);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(38, 20);
            this.rbD.TabIndex = 20;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(42, 254);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(37, 20);
            this.rbC.TabIndex = 19;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Resolução";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alternativas";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(96, 363);
            this.txtE.Multiline = true;
            this.txtE.Name = "txtE";
            this.txtE.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtE.Size = new System.Drawing.Size(327, 33);
            this.txtE.TabIndex = 15;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(96, 307);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtD.Size = new System.Drawing.Size(327, 33);
            this.txtD.TabIndex = 13;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(96, 253);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtC.Size = new System.Drawing.Size(327, 33);
            this.txtC.TabIndex = 11;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(96, 198);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtB.Size = new System.Drawing.Size(327, 33);
            this.txtB.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(96, 147);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtA.Size = new System.Drawing.Size(327, 33);
            this.txtA.TabIndex = 7;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(42, 201);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(37, 20);
            this.rbB.TabIndex = 3;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(42, 148);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(37, 20);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // lblEnum
            // 
            this.lblEnum.AutoSize = true;
            this.lblEnum.Location = new System.Drawing.Point(19, 59);
            this.lblEnum.Name = "lblEnum";
            this.lblEnum.Size = new System.Drawing.Size(71, 16);
            this.lblEnum.TabIndex = 1;
            this.lblEnum.Text = "Enunciado";
            // 
            // txtEnun
            // 
            this.txtEnun.Location = new System.Drawing.Point(96, 34);
            this.txtEnun.Multiline = true;
            this.txtEnun.Name = "txtEnun";
            this.txtEnun.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnun.Size = new System.Drawing.Size(327, 71);
            this.txtEnun.TabIndex = 0;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(518, 33);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(94, 16);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Nova Questão";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(68, 374);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(165, 62);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "FormInserir";
            this.Text = "FormInserir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewDirec;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtEnun;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lblEnum;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.TextBox txtReso;
        private System.Windows.Forms.Button btnNewD;
        private System.Windows.Forms.Button btnNewQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPastas;
        private System.Windows.Forms.RadioButton rnbExatas;
        private System.Windows.Forms.RadioButton rnbHumanas;
        private System.Windows.Forms.Button btnInfo;
    }
}
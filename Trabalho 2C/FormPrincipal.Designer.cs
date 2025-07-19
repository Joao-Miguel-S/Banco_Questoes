namespace Trabalho_2C
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.grpAlternativas = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.lblD = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.lblC = new System.Windows.Forms.Label();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.btnProximaPergunta = new System.Windows.Forms.Button();
            this.lblQntQ = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(15, 26);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(71, 16);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Enunciado";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(18, 44);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(699, 122);
            this.txtEnunciado.TabIndex = 3;
            // 
            // grpAlternativas
            // 
            this.grpAlternativas.Controls.Add(this.lblE);
            this.grpAlternativas.Controls.Add(this.rdbE);
            this.grpAlternativas.Controls.Add(this.lblD);
            this.grpAlternativas.Controls.Add(this.rdbD);
            this.grpAlternativas.Controls.Add(this.lblC);
            this.grpAlternativas.Controls.Add(this.rdbC);
            this.grpAlternativas.Controls.Add(this.lblB);
            this.grpAlternativas.Controls.Add(this.rdbB);
            this.grpAlternativas.Controls.Add(this.lblA);
            this.grpAlternativas.Controls.Add(this.rdbA);
            this.grpAlternativas.Location = new System.Drawing.Point(18, 193);
            this.grpAlternativas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAlternativas.Name = "grpAlternativas";
            this.grpAlternativas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAlternativas.Size = new System.Drawing.Size(699, 210);
            this.grpAlternativas.TabIndex = 4;
            this.grpAlternativas.TabStop = false;
            this.grpAlternativas.Text = "Alternativas";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(8, 166);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(19, 16);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "E.";
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Location = new System.Drawing.Point(35, 165);
            this.rdbE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(17, 16);
            this.rdbE.TabIndex = 8;
            this.rdbE.TabStop = true;
            this.rdbE.Tag = "E";
            this.rdbE.UseVisualStyleBackColor = true;
            this.rdbE.CheckedChanged += new System.EventHandler(this.Resposta_CheckedChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(8, 129);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(20, 16);
            this.lblD.TabIndex = 7;
            this.lblD.Text = "D.";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(35, 127);
            this.rdbD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(17, 16);
            this.rdbD.TabIndex = 6;
            this.rdbD.TabStop = true;
            this.rdbD.Tag = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.CheckedChanged += new System.EventHandler(this.Resposta_CheckedChanged);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(8, 94);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(19, 16);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C.";
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(35, 92);
            this.rdbC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(17, 16);
            this.rdbC.TabIndex = 4;
            this.rdbC.TabStop = true;
            this.rdbC.Tag = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.CheckedChanged += new System.EventHandler(this.Resposta_CheckedChanged);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(8, 57);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 16);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B.";
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(35, 55);
            this.rdbB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(17, 16);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.Tag = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.CheckedChanged += new System.EventHandler(this.Resposta_CheckedChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 22);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 16);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A.";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(35, 20);
            this.rdbA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(17, 16);
            this.rdbA.TabIndex = 0;
            this.rdbA.TabStop = true;
            this.rdbA.Tag = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.CheckedChanged += new System.EventHandler(this.Resposta_CheckedChanged);
            // 
            // btnProximaPergunta
            // 
            this.btnProximaPergunta.Location = new System.Drawing.Point(450, 462);
            this.btnProximaPergunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProximaPergunta.Name = "btnProximaPergunta";
            this.btnProximaPergunta.Size = new System.Drawing.Size(253, 54);
            this.btnProximaPergunta.TabIndex = 6;
            this.btnProximaPergunta.Text = "Próxima pergunta";
            this.btnProximaPergunta.UseVisualStyleBackColor = true;
            this.btnProximaPergunta.Click += new System.EventHandler(this.btnProximaPergunta_Click);
            // 
            // lblQntQ
            // 
            this.lblQntQ.AutoSize = true;
            this.lblQntQ.Location = new System.Drawing.Point(670, 26);
            this.lblQntQ.Name = "lblQntQ";
            this.lblQntQ.Size = new System.Drawing.Size(25, 16);
            this.lblQntQ.TabIndex = 9;
            this.lblQntQ.Text = "xxx";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(18, 462);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(242, 54);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(304, 462);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(97, 24);
            this.btnMarcar.TabIndex = 11;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(304, 492);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(97, 24);
            this.btnVisualizar.TabIndex = 12;
            this.btnVisualizar.Text = "Marcadas";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(12, 553);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(702, 52);
            this.txtNotas.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 534);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 16);
            this.label31.TabIndex = 14;
            this.label31.Text = "Notas";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(318, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Horas: Minutos";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblQntQ);
            this.Controls.Add(this.btnProximaPergunta);
            this.Controls.Add(this.grpAlternativas);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.lblEnunciado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "Aplicativo de Resolução de Questões CPII";
            this.grpAlternativas.ResumeLayout(false);
            this.grpAlternativas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.GroupBox grpAlternativas;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Button btnProximaPergunta;
        private System.Windows.Forms.Label lblQntQ;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
    }
}


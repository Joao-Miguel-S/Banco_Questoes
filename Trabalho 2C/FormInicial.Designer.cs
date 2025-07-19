namespace Trabalho_2C
{
    partial class FormInicial
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnQuestao = new System.Windows.Forms.Button();
            this.btnDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(47, 122);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(260, 71);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir Questão";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnQuestao
            // 
            this.btnQuestao.Location = new System.Drawing.Point(47, 201);
            this.btnQuestao.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestao.Name = "btnQuestao";
            this.btnQuestao.Size = new System.Drawing.Size(260, 71);
            this.btnQuestao.TabIndex = 1;
            this.btnQuestao.Text = "Questão";
            this.btnQuestao.UseVisualStyleBackColor = true;
            this.btnQuestao.Click += new System.EventHandler(this.btnQuestao_Click);
            // 
            // btnDados
            // 
            this.btnDados.Location = new System.Drawing.Point(47, 279);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(260, 77);
            this.btnDados.TabIndex = 2;
            this.btnDados.Text = "Dados";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem vindo!";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 71);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aqui você poderá criar, realizar questões e acessar dados do seu desepenho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.btnQuestao);
            this.Controls.Add(this.btnInserir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicial";
            this.Text = "InitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnQuestao;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
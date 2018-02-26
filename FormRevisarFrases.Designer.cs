namespace RevisadorDeFrase
{
    partial class FormRevisarFrases
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFrase = new System.Windows.Forms.RichTextBox();
            this.textFrasePortugues = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnResposta = new System.Windows.Forms.Button();
            this.btnAcertou = new System.Windows.Forms.Button();
            this.btnErrou = new System.Windows.Forms.Button();
            this.btnMaisOuMenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frase Português";
            // 
            // textFrase
            // 
            this.textFrase.Location = new System.Drawing.Point(12, 29);
            this.textFrase.Name = "textFrase";
            this.textFrase.Size = new System.Drawing.Size(852, 134);
            this.textFrase.TabIndex = 2;
            this.textFrase.Text = "";
            // 
            // textFrasePortugues
            // 
            this.textFrasePortugues.Location = new System.Drawing.Point(12, 213);
            this.textFrasePortugues.Name = "textFrasePortugues";
            this.textFrasePortugues.Size = new System.Drawing.Size(852, 134);
            this.textFrasePortugues.TabIndex = 3;
            this.textFrasePortugues.Text = "";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 379);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnResposta
            // 
            this.btnResposta.Location = new System.Drawing.Point(473, 353);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(94, 23);
            this.btnResposta.TabIndex = 5;
            this.btnResposta.Text = "Resposta";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            this.btnResposta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnResposta_MouseDown);
            this.btnResposta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnResposta_MouseUp);
            // 
            // btnAcertou
            // 
            this.btnAcertou.Location = new System.Drawing.Point(573, 353);
            this.btnAcertou.Name = "btnAcertou";
            this.btnAcertou.Size = new System.Drawing.Size(75, 23);
            this.btnAcertou.TabIndex = 6;
            this.btnAcertou.Text = "Acertou";
            this.btnAcertou.UseVisualStyleBackColor = true;
            this.btnAcertou.Click += new System.EventHandler(this.btnAcertou_Click);
            // 
            // btnErrou
            // 
            this.btnErrou.Location = new System.Drawing.Point(789, 353);
            this.btnErrou.Name = "btnErrou";
            this.btnErrou.Size = new System.Drawing.Size(75, 23);
            this.btnErrou.TabIndex = 7;
            this.btnErrou.Text = "Errou";
            this.btnErrou.UseVisualStyleBackColor = true;
            this.btnErrou.Click += new System.EventHandler(this.btnErrou_Click);
            // 
            // btnMaisOuMenos
            // 
            this.btnMaisOuMenos.Location = new System.Drawing.Point(654, 353);
            this.btnMaisOuMenos.Name = "btnMaisOuMenos";
            this.btnMaisOuMenos.Size = new System.Drawing.Size(129, 23);
            this.btnMaisOuMenos.TabIndex = 8;
            this.btnMaisOuMenos.Text = "Mais ou Menos";
            this.btnMaisOuMenos.UseVisualStyleBackColor = true;
            this.btnMaisOuMenos.Click += new System.EventHandler(this.btnMaisOuMenos_Click);
            // 
            // FormRevisarFrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 414);
            this.Controls.Add(this.btnMaisOuMenos);
            this.Controls.Add(this.btnErrou);
            this.Controls.Add(this.btnAcertou);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.textFrasePortugues);
            this.Controls.Add(this.textFrase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormRevisarFrases";
            this.Text = "Revisar Frases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textFrase;
        private System.Windows.Forms.RichTextBox textFrasePortugues;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnResposta;
        private System.Windows.Forms.Button btnAcertou;
        private System.Windows.Forms.Button btnErrou;
        private System.Windows.Forms.Button btnMaisOuMenos;
    }
}
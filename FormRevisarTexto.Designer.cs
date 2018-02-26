namespace RevisadorDeFrase
{
    partial class FormRevisarTexto
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFacil = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnDificil = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOutroIdioma = new System.Windows.Forms.TabPage();
            this.textTexto = new System.Windows.Forms.RichTextBox();
            this.tabPortugues = new System.Windows.Forms.TabPage();
            this.textTextoPortugues = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            this.textTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabOutroIdioma.SuspendLayout();
            this.tabPortugues.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 713);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnFacil
            // 
            this.btnFacil.Location = new System.Drawing.Point(1017, 713);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(110, 23);
            this.btnFacil.TabIndex = 17;
            this.btnFacil.Text = "Fácil 4 dias";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(910, 713);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(101, 23);
            this.btnNormal.TabIndex = 16;
            this.btnNormal.Text = "Normal 1 dia";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnDificil
            // 
            this.btnDificil.Location = new System.Drawing.Point(787, 713);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(117, 23);
            this.btnDificil.TabIndex = 18;
            this.btnDificil.Text = "Difícil < 1m";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOutroIdioma);
            this.tabControl1.Controls.Add(this.tabPortugues);
            this.tabControl1.Location = new System.Drawing.Point(10, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 649);
            this.tabControl1.TabIndex = 38;
            // 
            // tabOutroIdioma
            // 
            this.tabOutroIdioma.Controls.Add(this.textTexto);
            this.tabOutroIdioma.Location = new System.Drawing.Point(4, 25);
            this.tabOutroIdioma.Name = "tabOutroIdioma";
            this.tabOutroIdioma.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutroIdioma.Size = new System.Drawing.Size(1105, 620);
            this.tabOutroIdioma.TabIndex = 0;
            this.tabOutroIdioma.Text = "Outro Idioma";
            this.tabOutroIdioma.UseVisualStyleBackColor = true;
            // 
            // textTexto
            // 
            this.textTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTexto.Location = new System.Drawing.Point(3, 3);
            this.textTexto.Name = "textTexto";
            this.textTexto.Size = new System.Drawing.Size(1099, 614);
            this.textTexto.TabIndex = 0;
            this.textTexto.Text = "";
            // 
            // tabPortugues
            // 
            this.tabPortugues.Controls.Add(this.textTextoPortugues);
            this.tabPortugues.Location = new System.Drawing.Point(4, 25);
            this.tabPortugues.Name = "tabPortugues";
            this.tabPortugues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPortugues.Size = new System.Drawing.Size(1105, 620);
            this.tabPortugues.TabIndex = 1;
            this.tabPortugues.Text = "Texto em Português";
            this.tabPortugues.UseVisualStyleBackColor = true;
            // 
            // textTextoPortugues
            // 
            this.textTextoPortugues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTextoPortugues.Location = new System.Drawing.Point(3, 3);
            this.textTextoPortugues.Name = "textTextoPortugues";
            this.textTextoPortugues.Size = new System.Drawing.Size(1099, 614);
            this.textTextoPortugues.TabIndex = 1;
            this.textTextoPortugues.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Idioma";
            // 
            // comboIdioma
            // 
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Location = new System.Drawing.Point(945, 10);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(174, 24);
            this.comboIdioma.TabIndex = 36;
            // 
            // textTags
            // 
            this.textTags.Location = new System.Drawing.Point(613, 11);
            this.textTags.Name = "textTags";
            this.textTags.Size = new System.Drawing.Size(271, 22);
            this.textTags.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tags";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(58, 11);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(503, 22);
            this.textTitulo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Titulo";
            // 
            // FormRevisarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 740);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.textTags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDificil);
            this.Controls.Add(this.btnFacil);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormRevisarTexto";
            this.Text = "Revisar Texto";
            this.tabControl1.ResumeLayout(false);
            this.tabOutroIdioma.ResumeLayout(false);
            this.tabPortugues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOutroIdioma;
        private System.Windows.Forms.RichTextBox textTexto;
        private System.Windows.Forms.TabPage tabPortugues;
        private System.Windows.Forms.RichTextBox textTextoPortugues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboIdioma;
        private System.Windows.Forms.TextBox textTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label label2;
    }
}
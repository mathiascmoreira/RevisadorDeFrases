namespace RevisadorDeFrase
{
    partial class Form1
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
            this.btnListaDeTextos = new System.Windows.Forms.Button();
            this.btnListaDeFrases = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaDeTextos
            // 
            this.btnListaDeTextos.Location = new System.Drawing.Point(12, 12);
            this.btnListaDeTextos.Name = "btnListaDeTextos";
            this.btnListaDeTextos.Size = new System.Drawing.Size(154, 58);
            this.btnListaDeTextos.TabIndex = 3;
            this.btnListaDeTextos.Text = "Lista de Textos";
            this.btnListaDeTextos.UseVisualStyleBackColor = true;
            this.btnListaDeTextos.Click += new System.EventHandler(this.btnListaDeTextos_Click);
            // 
            // btnListaDeFrases
            // 
            this.btnListaDeFrases.Location = new System.Drawing.Point(172, 12);
            this.btnListaDeFrases.Name = "btnListaDeFrases";
            this.btnListaDeFrases.Size = new System.Drawing.Size(154, 58);
            this.btnListaDeFrases.TabIndex = 7;
            this.btnListaDeFrases.Text = "Lista de Frases";
            this.btnListaDeFrases.UseVisualStyleBackColor = true;
            this.btnListaDeFrases.Click += new System.EventHandler(this.btnListaDeFrases_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListaDeFrases);
            this.Controls.Add(this.btnListaDeTextos);
            this.Name = "Form1";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListaDeTextos;
        private System.Windows.Forms.Button btnListaDeFrases;
        private System.Windows.Forms.Button button1;
    }
}


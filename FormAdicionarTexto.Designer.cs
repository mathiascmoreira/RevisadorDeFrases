namespace RevisadorDeFrase
{
    partial class FormAdicionarTexto
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
            this.textTexto = new System.Windows.Forms.RichTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.btnLimparLegenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOutroIdioma = new System.Windows.Forms.TabPage();
            this.tabPortugues = new System.Windows.Forms.TabPage();
            this.textTextoPortugues = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabOutroIdioma.SuspendLayout();
            this.tabPortugues.SuspendLayout();
            this.SuspendLayout();
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
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.Location = new System.Drawing.Point(14, 713);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(92, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Titulo";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(60, 13);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(503, 22);
            this.textTitulo.TabIndex = 24;
            // 
            // btnLimparLegenda
            // 
            this.btnLimparLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparLegenda.Location = new System.Drawing.Point(997, 711);
            this.btnLimparLegenda.Name = "btnLimparLegenda";
            this.btnLimparLegenda.Size = new System.Drawing.Size(130, 26);
            this.btnLimparLegenda.TabIndex = 25;
            this.btnLimparLegenda.Text = "Limpar Legenda";
            this.btnLimparLegenda.UseVisualStyleBackColor = true;
            this.btnLimparLegenda.Click += new System.EventHandler(this.btnLimparLegenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tags";
            // 
            // textTags
            // 
            this.textTags.Location = new System.Drawing.Point(615, 13);
            this.textTags.Name = "textTags";
            this.textTags.Size = new System.Drawing.Size(271, 22);
            this.textTags.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(892, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Idioma";
            // 
            // comboIdioma
            // 
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Location = new System.Drawing.Point(947, 12);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(174, 24);
            this.comboIdioma.TabIndex = 28;
            this.comboIdioma.SelectedValueChanged += new System.EventHandler(this.comboIdioma_SelectedValueChanged);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Location = new System.Drawing.Point(112, 713);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 23);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabOutroIdioma);
            this.tabControl1.Controls.Add(this.tabPortugues);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 649);
            this.tabControl1.TabIndex = 31;
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 620);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Outros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 744);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.textTags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimparLegenda);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FormAdicionarTexto";
            this.Text = "Adicionar Texto";
            this.tabControl1.ResumeLayout(false);
            this.tabOutroIdioma.ResumeLayout(false);
            this.tabPortugues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textTexto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Button btnLimparLegenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboIdioma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOutroIdioma;
        private System.Windows.Forms.TabPage tabPortugues;
        private System.Windows.Forms.RichTextBox textTextoPortugues;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
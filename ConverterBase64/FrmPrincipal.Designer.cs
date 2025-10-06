namespace ConverterBase64
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            label1 = new Label();
            TxtLocalArquivo = new TextBox();
            BtnProcurar = new Button();
            BtnConverter = new Button();
            RTxtBase64 = new RichTextBox();
            BtnCopiar = new Button();
            groupBox1 = new GroupBox();
            BtnLimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Local do arquivo";
            // 
            // TxtLocalArquivo
            // 
            TxtLocalArquivo.Location = new Point(12, 27);
            TxtLocalArquivo.Name = "TxtLocalArquivo";
            TxtLocalArquivo.Size = new Size(349, 23);
            TxtLocalArquivo.TabIndex = 1;
            // 
            // BtnProcurar
            // 
            BtnProcurar.Location = new Point(367, 27);
            BtnProcurar.Name = "BtnProcurar";
            BtnProcurar.Size = new Size(75, 23);
            BtnProcurar.TabIndex = 2;
            BtnProcurar.Text = "Procurar";
            BtnProcurar.UseVisualStyleBackColor = true;
            BtnProcurar.Click += BtnProcurar_Click;
            // 
            // BtnConverter
            // 
            BtnConverter.Location = new Point(12, 70);
            BtnConverter.Name = "BtnConverter";
            BtnConverter.Size = new Size(75, 23);
            BtnConverter.TabIndex = 3;
            BtnConverter.Text = "Converter";
            BtnConverter.UseVisualStyleBackColor = true;
            BtnConverter.Click += BtnConverter_Click;
            // 
            // RTxtBase64
            // 
            RTxtBase64.Dock = DockStyle.Fill;
            RTxtBase64.Location = new Point(3, 19);
            RTxtBase64.Name = "RTxtBase64";
            RTxtBase64.Size = new Size(426, 317);
            RTxtBase64.TabIndex = 4;
            RTxtBase64.Text = "";
            // 
            // BtnCopiar
            // 
            BtnCopiar.Location = new Point(93, 70);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(66, 23);
            BtnCopiar.TabIndex = 5;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = true;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(RTxtBase64);
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 339);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(165, 70);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 23);
            BtnLimpar.TabIndex = 7;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(BtnLimpar);
            Controls.Add(groupBox1);
            Controls.Add(BtnCopiar);
            Controls.Add(BtnConverter);
            Controls.Add(BtnProcurar);
            Controls.Add(TxtLocalArquivo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Converter";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtLocalArquivo;
        private Button BtnProcurar;
        private Button BtnConverter;
        private RichTextBox RTxtBase64;
        private Button BtnCopiar;
        private GroupBox groupBox1;
        private Button BtnLimpar;
    }
}

namespace Form1
{
    partial class FrmImc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImc));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnImc = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 23);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Peso";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(144, 20);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Informe o Peso";
            txtPeso.Size = new Size(142, 23);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(144, 49);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Informe a altura";
            txtAltura.Size = new Size(142, 23);
            txtAltura.TabIndex = 4;
            // 
            // btnImc
            // 
            btnImc.Location = new Point(211, 91);
            btnImc.Name = "btnImc";
            btnImc.Size = new Size(75, 23);
            btnImc.TabIndex = 5;
            btnImc.Text = "Gerar";
            btnImc.UseVisualStyleBackColor = true;
            btnImc.Click += btnImc_Click;
            // 
            // FrmImc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 143);
            Controls.Add(btnImc);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmImc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtPeso;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private TextBox txtAltura;
        private Button btnImc;
    }
}

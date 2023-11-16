namespace PracticaLogin
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            btnIntegrantes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(543, 118);
            label1.TabIndex = 0;
            label1.Text = "Programa de  crear Nómina";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(275, 171);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(194, 61);
            button2.TabIndex = 2;
            button2.Text = "Crear  Nómina";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(339, 304);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 35);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIntegrantes
            // 
            btnIntegrantes.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIntegrantes.Location = new Point(304, 251);
            btnIntegrantes.Name = "btnIntegrantes";
            btnIntegrantes.Size = new Size(140, 35);
            btnIntegrantes.TabIndex = 14;
            btnIntegrantes.Text = "Elaborado Por :";
            btnIntegrantes.UseVisualStyleBackColor = true;
            btnIntegrantes.Click += btnIntegrantes_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(684, 368);
            Controls.Add(btnIntegrantes);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Principal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnIntegrantes;
    }
}
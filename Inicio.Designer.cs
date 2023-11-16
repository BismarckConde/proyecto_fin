namespace PracticaLogin
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            btnIniciarSecion = new Button();
            btnRegistrarse = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(149, 58);
            label1.Name = "label1";
            label1.Size = new Size(429, 86);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión del Programa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciarSecion
            // 
            btnIniciarSecion.Cursor = Cursors.Hand;
            btnIniciarSecion.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSecion.Location = new Point(121, 188);
            btnIniciarSecion.Name = "btnIniciarSecion";
            btnIniciarSecion.Size = new Size(123, 58);
            btnIniciarSecion.TabIndex = 1;
            btnIniciarSecion.Text = "Iniciar sesión";
            btnIniciarSecion.UseVisualStyleBackColor = true;
            btnIniciarSecion.Click += btnIniciarSecion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.Location = new Point(448, 188);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(121, 58);
            btnRegistrarse.TabIndex = 2;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(648, 311);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIniciarSecion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnIniciarSecion;
        private Button btnRegistrarse;
        private PictureBox pictureBox1;
    }
}
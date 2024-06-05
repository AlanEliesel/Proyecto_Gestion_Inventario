namespace Precentacion.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_NoEntrar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_entrar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.txt_Contraseña = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.txt_Usuario = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(534, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(664, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 115);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_NoEntrar
            // 
            this.Btn_NoEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.Btn_NoEntrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.Btn_NoEntrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_NoEntrar.BorderRadius = 20;
            this.Btn_NoEntrar.BorderSize = 0;
            this.Btn_NoEntrar.FlatAppearance.BorderSize = 0;
            this.Btn_NoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NoEntrar.ForeColor = System.Drawing.Color.White;
            this.Btn_NoEntrar.Location = new System.Drawing.Point(815, 366);
            this.Btn_NoEntrar.Name = "Btn_NoEntrar";
            this.Btn_NoEntrar.Size = new System.Drawing.Size(186, 58);
            this.Btn_NoEntrar.TabIndex = 10;
            this.Btn_NoEntrar.Text = "Cancelar";
            this.Btn_NoEntrar.TextColor = System.Drawing.Color.White;
            this.Btn_NoEntrar.UseVisualStyleBackColor = false;
            this.Btn_NoEntrar.Click += new System.EventHandler(this.Btn_NoEntrar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.btn_entrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.btn_entrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_entrar.BorderRadius = 20;
            this.btn_entrar.BorderSize = 0;
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(596, 366);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(186, 58);
            this.btn_entrar.TabIndex = 9;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.TextColor = System.Drawing.Color.White;
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Contraseña.BorderFocusColor = System.Drawing.Color.White;
            this.txt_Contraseña.BorderRadius = 9;
            this.txt_Contraseña.BorderSize = 3;
            this.txt_Contraseña.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.txt_Contraseña.Location = new System.Drawing.Point(660, 267);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña.Multiline = false;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Contraseña.PasswordChar = true;
            this.txt_Contraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Contraseña.PlaceholderText = "";
            this.txt_Contraseña.Size = new System.Drawing.Size(275, 39);
            this.txt_Contraseña.TabIndex = 8;
            this.txt_Contraseña.Texts = "";
            this.txt_Contraseña.UnderlinedStyle = false;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Usuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Usuario.BorderRadius = 9;
            this.txt_Usuario.BorderSize = 3;
            this.txt_Usuario.Font = new System.Drawing.Font("Script MT Bold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_Usuario.Location = new System.Drawing.Point(660, 182);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Multiline = false;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Usuario.PasswordChar = false;
            this.txt_Usuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Usuario.PlaceholderText = "";
            this.txt_Usuario.Size = new System.Drawing.Size(275, 47);
            this.txt_Usuario.TabIndex = 7;
            this.txt_Usuario.Texts = "";
            this.txt_Usuario.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1039, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_NoEntrar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Diseños_Personalizados.Dñ_TextBox txt_Usuario;
        private Diseños_Personalizados.Dñ_TextBox txt_Contraseña;
        private Diseños_Personalizados.Dñ_Button btn_entrar;
        private Diseños_Personalizados.Dñ_Button Btn_NoEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
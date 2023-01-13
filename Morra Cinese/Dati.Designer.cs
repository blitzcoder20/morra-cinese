namespace Morra_Cinese
{
    partial class Dati
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
            this.btn_Conferma = new System.Windows.Forms.Button();
            this.txt_Nick = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_Registazione = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.lbl_Pwd2 = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Pwd2 = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Cognome = new System.Windows.Forms.Label();
            this.txt_Cognome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Conferma
            // 
            this.btn_Conferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conferma.Location = new System.Drawing.Point(190, 382);
            this.btn_Conferma.Name = "btn_Conferma";
            this.btn_Conferma.Size = new System.Drawing.Size(172, 48);
            this.btn_Conferma.TabIndex = 2;
            this.btn_Conferma.Text = "Conferma";
            this.btn_Conferma.UseVisualStyleBackColor = true;
            this.btn_Conferma.Click += new System.EventHandler(this.btn_Conferma_Click);
            // 
            // txt_Nick
            // 
            this.txt_Nick.Location = new System.Drawing.Point(163, 88);
            this.txt_Nick.Name = "txt_Nick";
            this.txt_Nick.Size = new System.Drawing.Size(239, 20);
            this.txt_Nick.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(185, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(178, 25);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Login giocatore 1";
            // 
            // btn_Registazione
            // 
            this.btn_Registazione.Location = new System.Drawing.Point(420, 152);
            this.btn_Registazione.Name = "btn_Registazione";
            this.btn_Registazione.Size = new System.Drawing.Size(139, 54);
            this.btn_Registazione.TabIndex = 6;
            this.btn_Registazione.Text = "Non sei ancora registrato?Registrati subito!";
            this.btn_Registazione.UseVisualStyleBackColor = true;
            this.btn_Registazione.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(163, 128);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(239, 20);
            this.txt_Pwd.TabIndex = 9;
            this.txt_Pwd.UseSystemPasswordChar = true;
            // 
            // lbl_Pwd2
            // 
            this.lbl_Pwd2.AutoSize = true;
            this.lbl_Pwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pwd2.Location = new System.Drawing.Point(12, 27);
            this.lbl_Pwd2.Name = "lbl_Pwd2";
            this.lbl_Pwd2.Size = new System.Drawing.Size(143, 24);
            this.lbl_Pwd2.TabIndex = 10;
            this.lbl_Pwd2.Text = "Ripeti password";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(12, 62);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(62, 24);
            this.lbl_Nome.TabIndex = 11;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Pwd2
            // 
            this.txt_Pwd2.Location = new System.Drawing.Point(163, 27);
            this.txt_Pwd2.Name = "txt_Pwd2";
            this.txt_Pwd2.PasswordChar = '*';
            this.txt_Pwd2.Size = new System.Drawing.Size(239, 20);
            this.txt_Pwd2.TabIndex = 12;
            this.txt_Pwd2.UseSystemPasswordChar = true;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(163, 62);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(239, 20);
            this.txt_Nome.TabIndex = 13;
            // 
            // lbl_Cognome
            // 
            this.lbl_Cognome.AutoSize = true;
            this.lbl_Cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cognome.Location = new System.Drawing.Point(12, 108);
            this.lbl_Cognome.Name = "lbl_Cognome";
            this.lbl_Cognome.Size = new System.Drawing.Size(94, 24);
            this.lbl_Cognome.TabIndex = 14;
            this.lbl_Cognome.Text = "Cognome";
            // 
            // txt_Cognome
            // 
            this.txt_Cognome.Location = new System.Drawing.Point(163, 108);
            this.txt_Cognome.Name = "txt_Cognome";
            this.txt_Cognome.Size = new System.Drawing.Size(239, 20);
            this.txt_Cognome.TabIndex = 15;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(163, 151);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(239, 20);
            this.txt_email.TabIndex = 17;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 151);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 24);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Pwd2);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.lbl_Nome);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.txt_Pwd2);
            this.panel1.Controls.Add(this.txt_Cognome);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.lbl_Cognome);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 207);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // Dati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(571, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Registazione);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_Nick);
            this.Controls.Add(this.btn_Conferma);
            this.Name = "Dati";
            this.Text = "Dati";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dati_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Conferma;
        private System.Windows.Forms.TextBox txt_Nick;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Registazione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Label lbl_Pwd2;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Pwd2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Cognome;
        private System.Windows.Forms.TextBox txt_Cognome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel panel1;
    }
}
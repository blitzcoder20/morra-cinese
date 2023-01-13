namespace Morra_Cinese
{
    partial class Gioco
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
            this.lbl_Player1 = new System.Windows.Forms.Label();
            this.lbl_Player2 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.pcb_Player2 = new System.Windows.Forms.PictureBox();
            this.pcb_Player1 = new System.Windows.Forms.PictureBox();
            this.pcb_Sasso = new System.Windows.Forms.PictureBox();
            this.pcb_Carta = new System.Windows.Forms.PictureBox();
            this.pcb_Forbici = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Sasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Carta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Forbici)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Player1
            // 
            this.lbl_Player1.AutoSize = true;
            this.lbl_Player1.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Player1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player1.ForeColor = System.Drawing.Color.Green;
            this.lbl_Player1.Location = new System.Drawing.Point(75, 96);
            this.lbl_Player1.Name = "lbl_Player1";
            this.lbl_Player1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Player1.Size = new System.Drawing.Size(96, 19);
            this.lbl_Player1.TabIndex = 4;
            this.lbl_Player1.Text = "Giocatore 1";
            // 
            // lbl_Player2
            // 
            this.lbl_Player2.AutoSize = true;
            this.lbl_Player2.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Player2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player2.ForeColor = System.Drawing.Color.Green;
            this.lbl_Player2.Location = new System.Drawing.Point(378, 96);
            this.lbl_Player2.Name = "lbl_Player2";
            this.lbl_Player2.Size = new System.Drawing.Size(96, 19);
            this.lbl_Player2.TabIndex = 5;
            this.lbl_Player2.Text = "Giocatore 2";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(203, 13);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(152, 23);
            this.btn_Menu.TabIndex = 10;
            this.btn_Menu.Text = "Torna al menu principale";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // pcb_Player2
            // 
            this.pcb_Player2.Location = new System.Drawing.Point(377, 139);
            this.pcb_Player2.Name = "pcb_Player2";
            this.pcb_Player2.Size = new System.Drawing.Size(108, 120);
            this.pcb_Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Player2.TabIndex = 6;
            this.pcb_Player2.TabStop = false;
            // 
            // pcb_Player1
            // 
            this.pcb_Player1.Location = new System.Drawing.Point(74, 139);
            this.pcb_Player1.Name = "pcb_Player1";
            this.pcb_Player1.Size = new System.Drawing.Size(108, 120);
            this.pcb_Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Player1.TabIndex = 0;
            this.pcb_Player1.TabStop = false;
            // 
            // pcb_Sasso
            // 
            this.pcb_Sasso.Image = global::Morra_Cinese.Properties.Resources.sasso;
            this.pcb_Sasso.Location = new System.Drawing.Point(89, 296);
            this.pcb_Sasso.Name = "pcb_Sasso";
            this.pcb_Sasso.Size = new System.Drawing.Size(82, 92);
            this.pcb_Sasso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Sasso.TabIndex = 11;
            this.pcb_Sasso.TabStop = false;
            // 
            // pcb_Carta
            // 
            this.pcb_Carta.Image = global::Morra_Cinese.Properties.Resources.carta;
            this.pcb_Carta.Location = new System.Drawing.Point(239, 296);
            this.pcb_Carta.Name = "pcb_Carta";
            this.pcb_Carta.Size = new System.Drawing.Size(82, 92);
            this.pcb_Carta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Carta.TabIndex = 12;
            this.pcb_Carta.TabStop = false;
            // 
            // pcb_Forbici
            // 
            this.pcb_Forbici.Image = global::Morra_Cinese.Properties.Resources.forbici;
            this.pcb_Forbici.Location = new System.Drawing.Point(392, 296);
            this.pcb_Forbici.Name = "pcb_Forbici";
            this.pcb_Forbici.Size = new System.Drawing.Size(82, 92);
            this.pcb_Forbici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Forbici.TabIndex = 13;
            this.pcb_Forbici.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "3";
            // 
            // Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Morra_Cinese.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_Forbici);
            this.Controls.Add(this.pcb_Carta);
            this.Controls.Add(this.pcb_Sasso);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.pcb_Player2);
            this.Controls.Add(this.lbl_Player2);
            this.Controls.Add(this.lbl_Player1);
            this.Controls.Add(this.pcb_Player1);
            this.KeyPreview = true;
            this.Name = "Gioco";
            this.Text = "Morra Cinese";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gioco_FormClosing);
            this.Load += new System.EventHandler(this.Gioco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gioco_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Sasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Carta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Forbici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Player1;
        private System.Windows.Forms.Label lbl_Player1;
        private System.Windows.Forms.Label lbl_Player2;
        private System.Windows.Forms.PictureBox pcb_Player2;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.PictureBox pcb_Sasso;
        private System.Windows.Forms.PictureBox pcb_Carta;
        private System.Windows.Forms.PictureBox pcb_Forbici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


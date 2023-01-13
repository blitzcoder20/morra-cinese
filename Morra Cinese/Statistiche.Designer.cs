namespace Morra_Cinese
{
    partial class Statistiche
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbl_Classifica = new System.Windows.Forms.DataGridView();
            this.clm_Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Nick1 = new System.Windows.Forms.TextBox();
            this.txt_Nick2 = new System.Windows.Forms.TextBox();
            this.lbl_Vittorie1 = new System.Windows.Forms.Label();
            this.lbl_Pareggi1 = new System.Windows.Forms.Label();
            this.lbl_Sconfitte1 = new System.Windows.Forms.Label();
            this.lbl_Vittorie2 = new System.Windows.Forms.Label();
            this.lbl_Pareggi2 = new System.Windows.Forms.Label();
            this.lbl_Sconfitte2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Conferma = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.txt_Nick_gg = new System.Windows.Forms.TextBox();
            this.lbl_Vittoriegg = new System.Windows.Forms.Label();
            this.lbl_Pareggigg = new System.Windows.Forms.Label();
            this.lbl_Sconfittegg = new System.Windows.Forms.Label();
            this.btn_Conferma_gg = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Classifica)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 407);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tbl_Classifica);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Classifica";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btn_Conferma);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_Sconfitte2);
            this.tabPage2.Controls.Add(this.lbl_Pareggi2);
            this.tabPage2.Controls.Add(this.lbl_Vittorie2);
            this.tabPage2.Controls.Add(this.lbl_Sconfitte1);
            this.tabPage2.Controls.Add(this.lbl_Pareggi1);
            this.tabPage2.Controls.Add(this.lbl_Vittorie1);
            this.tabPage2.Controls.Add(this.txt_Nick2);
            this.tabPage2.Controls.Add(this.txt_Nick1);
            this.tabPage2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info Partite";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.btn_Conferma_gg);
            this.tabPage3.Controls.Add(this.lbl_Sconfittegg);
            this.tabPage3.Controls.Add(this.lbl_Pareggigg);
            this.tabPage3.Controls.Add(this.lbl_Vittoriegg);
            this.tabPage3.Controls.Add(this.txt_Nick_gg);
            this.tabPage3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(547, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info Giocatore";
            // 
            // tbl_Classifica
            // 
            this.tbl_Classifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Classifica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Nickname,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tbl_Classifica.Location = new System.Drawing.Point(7, 29);
            this.tbl_Classifica.Name = "tbl_Classifica";
            this.tbl_Classifica.ReadOnly = true;
            this.tbl_Classifica.Size = new System.Drawing.Size(533, 344);
            this.tbl_Classifica.TabIndex = 0;
            // 
            // clm_Nickname
            // 
            this.clm_Nickname.HeaderText = "Nickname";
            this.clm_Nickname.Name = "clm_Nickname";
            this.clm_Nickname.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vittorie";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pareggi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sconfitte";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "% Vittorie";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txt_Nick1
            // 
            this.txt_Nick1.Location = new System.Drawing.Point(55, 33);
            this.txt_Nick1.Name = "txt_Nick1";
            this.txt_Nick1.Size = new System.Drawing.Size(123, 28);
            this.txt_Nick1.TabIndex = 0;
            // 
            // txt_Nick2
            // 
            this.txt_Nick2.Location = new System.Drawing.Point(339, 33);
            this.txt_Nick2.Name = "txt_Nick2";
            this.txt_Nick2.Size = new System.Drawing.Size(123, 28);
            this.txt_Nick2.TabIndex = 1;
            // 
            // lbl_Vittorie1
            // 
            this.lbl_Vittorie1.AutoSize = true;
            this.lbl_Vittorie1.Location = new System.Drawing.Point(26, 92);
            this.lbl_Vittorie1.Name = "lbl_Vittorie1";
            this.lbl_Vittorie1.Size = new System.Drawing.Size(71, 21);
            this.lbl_Vittorie1.TabIndex = 2;
            this.lbl_Vittorie1.Text = "Vittorie";
            // 
            // lbl_Pareggi1
            // 
            this.lbl_Pareggi1.AutoSize = true;
            this.lbl_Pareggi1.Location = new System.Drawing.Point(26, 171);
            this.lbl_Pareggi1.Name = "lbl_Pareggi1";
            this.lbl_Pareggi1.Size = new System.Drawing.Size(68, 21);
            this.lbl_Pareggi1.TabIndex = 3;
            this.lbl_Pareggi1.Text = "Pareggi";
            // 
            // lbl_Sconfitte1
            // 
            this.lbl_Sconfitte1.AutoSize = true;
            this.lbl_Sconfitte1.Location = new System.Drawing.Point(26, 265);
            this.lbl_Sconfitte1.Name = "lbl_Sconfitte1";
            this.lbl_Sconfitte1.Size = new System.Drawing.Size(80, 21);
            this.lbl_Sconfitte1.TabIndex = 4;
            this.lbl_Sconfitte1.Text = "Sconfitte";
            // 
            // lbl_Vittorie2
            // 
            this.lbl_Vittorie2.AutoSize = true;
            this.lbl_Vittorie2.Location = new System.Drawing.Point(307, 92);
            this.lbl_Vittorie2.Name = "lbl_Vittorie2";
            this.lbl_Vittorie2.Size = new System.Drawing.Size(71, 21);
            this.lbl_Vittorie2.TabIndex = 5;
            this.lbl_Vittorie2.Text = "Vittorie";
            // 
            // lbl_Pareggi2
            // 
            this.lbl_Pareggi2.AutoSize = true;
            this.lbl_Pareggi2.Location = new System.Drawing.Point(307, 171);
            this.lbl_Pareggi2.Name = "lbl_Pareggi2";
            this.lbl_Pareggi2.Size = new System.Drawing.Size(68, 21);
            this.lbl_Pareggi2.TabIndex = 6;
            this.lbl_Pareggi2.Text = "Pareggi";
            // 
            // lbl_Sconfitte2
            // 
            this.lbl_Sconfitte2.AutoSize = true;
            this.lbl_Sconfitte2.Location = new System.Drawing.Point(307, 265);
            this.lbl_Sconfitte2.Name = "lbl_Sconfitte2";
            this.lbl_Sconfitte2.Size = new System.Drawing.Size(80, 21);
            this.lbl_Sconfitte2.TabIndex = 7;
            this.lbl_Sconfitte2.Text = "Sconfitte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "VS";
            // 
            // btn_Conferma
            // 
            this.btn_Conferma.Location = new System.Drawing.Point(198, 323);
            this.btn_Conferma.Name = "btn_Conferma";
            this.btn_Conferma.Size = new System.Drawing.Size(124, 28);
            this.btn_Conferma.TabIndex = 9;
            this.btn_Conferma.Text = "Conferma";
            this.btn_Conferma.UseVisualStyleBackColor = true;
            this.btn_Conferma.Click += new System.EventHandler(this.btn_Conferma_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(547, 378);
            this.tabMenu.TabIndex = 3;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // txt_Nick_gg
            // 
            this.txt_Nick_gg.Location = new System.Drawing.Point(181, 21);
            this.txt_Nick_gg.Name = "txt_Nick_gg";
            this.txt_Nick_gg.Size = new System.Drawing.Size(147, 28);
            this.txt_Nick_gg.TabIndex = 0;
            // 
            // lbl_Vittoriegg
            // 
            this.lbl_Vittoriegg.AutoSize = true;
            this.lbl_Vittoriegg.Location = new System.Drawing.Point(80, 106);
            this.lbl_Vittoriegg.Name = "lbl_Vittoriegg";
            this.lbl_Vittoriegg.Size = new System.Drawing.Size(71, 21);
            this.lbl_Vittoriegg.TabIndex = 1;
            this.lbl_Vittoriegg.Text = "Vittorie";
            // 
            // lbl_Pareggigg
            // 
            this.lbl_Pareggigg.AutoSize = true;
            this.lbl_Pareggigg.Location = new System.Drawing.Point(80, 187);
            this.lbl_Pareggigg.Name = "lbl_Pareggigg";
            this.lbl_Pareggigg.Size = new System.Drawing.Size(68, 21);
            this.lbl_Pareggigg.TabIndex = 2;
            this.lbl_Pareggigg.Text = "Pareggi";
            // 
            // lbl_Sconfittegg
            // 
            this.lbl_Sconfittegg.AutoSize = true;
            this.lbl_Sconfittegg.Location = new System.Drawing.Point(80, 268);
            this.lbl_Sconfittegg.Name = "lbl_Sconfittegg";
            this.lbl_Sconfittegg.Size = new System.Drawing.Size(80, 21);
            this.lbl_Sconfittegg.TabIndex = 3;
            this.lbl_Sconfittegg.Text = "Sconfitte";
            // 
            // btn_Conferma_gg
            // 
            this.btn_Conferma_gg.Location = new System.Drawing.Point(195, 318);
            this.btn_Conferma_gg.Name = "btn_Conferma_gg";
            this.btn_Conferma_gg.Size = new System.Drawing.Size(133, 32);
            this.btn_Conferma_gg.TabIndex = 4;
            this.btn_Conferma_gg.Text = "Conferma";
            this.btn_Conferma_gg.UseVisualStyleBackColor = true;
            this.btn_Conferma_gg.Click += new System.EventHandler(this.btn_Conferma_gg_Click);
            // 
            // Statistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistiche";
            this.Text = "Statistiche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistiche_FormClosing);
            this.Load += new System.EventHandler(this.Statistiche_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Classifica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tbl_Classifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_Nick2;
        private System.Windows.Forms.TextBox txt_Nick1;
        private System.Windows.Forms.Label lbl_Sconfitte2;
        private System.Windows.Forms.Label lbl_Pareggi2;
        private System.Windows.Forms.Label lbl_Vittorie2;
        private System.Windows.Forms.Label lbl_Sconfitte1;
        private System.Windows.Forms.Label lbl_Pareggi1;
        private System.Windows.Forms.Label lbl_Vittorie1;
        private System.Windows.Forms.Button btn_Conferma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Label lbl_Sconfittegg;
        private System.Windows.Forms.Label lbl_Pareggigg;
        private System.Windows.Forms.Label lbl_Vittoriegg;
        private System.Windows.Forms.TextBox txt_Nick_gg;
        private System.Windows.Forms.Button btn_Conferma_gg;
    }
}
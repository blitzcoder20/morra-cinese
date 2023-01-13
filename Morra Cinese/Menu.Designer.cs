namespace Morra_Cinese
{
    partial class Menu
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
            this.btn_Single = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.btn_Statistiche = new System.Windows.Forms.Button();
            this.btn_Regole = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Single
            // 
            this.btn_Single.BackColor = System.Drawing.Color.Blue;
            this.btn_Single.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Single.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Single.Location = new System.Drawing.Point(78, 56);
            this.btn_Single.Name = "btn_Single";
            this.btn_Single.Size = new System.Drawing.Size(249, 69);
            this.btn_Single.TabIndex = 0;
            this.btn_Single.Text = "1 Giocatore";
            this.btn_Single.UseVisualStyleBackColor = false;
            this.btn_Single.Click += new System.EventHandler(this.btn_Single_Click);
            // 
            // btn_Multi
            // 
            this.btn_Multi.BackColor = System.Drawing.Color.Blue;
            this.btn_Multi.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Multi.Location = new System.Drawing.Point(78, 156);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(249, 69);
            this.btn_Multi.TabIndex = 1;
            this.btn_Multi.Text = "2 Giocatori";
            this.btn_Multi.UseVisualStyleBackColor = false;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // btn_Statistiche
            // 
            this.btn_Statistiche.BackColor = System.Drawing.Color.Blue;
            this.btn_Statistiche.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistiche.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Statistiche.Location = new System.Drawing.Point(78, 251);
            this.btn_Statistiche.Name = "btn_Statistiche";
            this.btn_Statistiche.Size = new System.Drawing.Size(249, 69);
            this.btn_Statistiche.TabIndex = 2;
            this.btn_Statistiche.Text = "Statistiche";
            this.btn_Statistiche.UseVisualStyleBackColor = false;
            this.btn_Statistiche.Click += new System.EventHandler(this.btn_Statistiche_Click);
            // 
            // btn_Regole
            // 
            this.btn_Regole.BackColor = System.Drawing.Color.Blue;
            this.btn_Regole.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regole.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Regole.Location = new System.Drawing.Point(78, 343);
            this.btn_Regole.Name = "btn_Regole";
            this.btn_Regole.Size = new System.Drawing.Size(249, 69);
            this.btn_Regole.TabIndex = 3;
            this.btn_Regole.Text = "Regole";
            this.btn_Regole.UseVisualStyleBackColor = false;
            this.btn_Regole.Click += new System.EventHandler(this.btn_Regole_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Blue;
            this.btn_Exit.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Location = new System.Drawing.Point(78, 434);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(249, 69);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Esci";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(410, 551);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Regole);
            this.Controls.Add(this.btn_Statistiche);
            this.Controls.Add(this.btn_Multi);
            this.Controls.Add(this.btn_Single);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Single;
        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.Button btn_Statistiche;
        private System.Windows.Forms.Button btn_Regole;
        private System.Windows.Forms.Button btn_Exit;
    }
}
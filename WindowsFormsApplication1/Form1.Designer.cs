namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openSdmBtn = new System.Windows.Forms.Button();
            this.openSdmTxtBx = new System.Windows.Forms.TextBox();
            this.openPdmTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openPdmBtn = new System.Windows.Forms.Button();
            this.openResultPdmBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openResultPdmTxtBx = new System.Windows.Forms.TextBox();
            this.generatePdmBtn = new System.Windows.Forms.Button();
            this.openContextVarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openContextVarTxtBx = new System.Windows.Forms.TextBox();
            this.consoleRchTxtBx = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openSdmBtn
            // 
            this.openSdmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openSdmBtn.BackgroundImage")));
            this.openSdmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openSdmBtn.Location = new System.Drawing.Point(44, 52);
            this.openSdmBtn.Name = "openSdmBtn";
            this.openSdmBtn.Size = new System.Drawing.Size(34, 29);
            this.openSdmBtn.TabIndex = 0;
            this.openSdmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openSdmBtn.UseVisualStyleBackColor = true;
            this.openSdmBtn.Click += new System.EventHandler(this.openSdmBtn_Click);
            // 
            // openSdmTxtBx
            // 
            this.openSdmTxtBx.Enabled = false;
            this.openSdmTxtBx.Location = new System.Drawing.Point(84, 57);
            this.openSdmTxtBx.Name = "openSdmTxtBx";
            this.openSdmTxtBx.Size = new System.Drawing.Size(536, 20);
            this.openSdmTxtBx.TabIndex = 1;
            // 
            // openPdmTxtBx
            // 
            this.openPdmTxtBx.Enabled = false;
            this.openPdmTxtBx.Location = new System.Drawing.Point(84, 121);
            this.openPdmTxtBx.Name = "openPdmTxtBx";
            this.openPdmTxtBx.Size = new System.Drawing.Size(536, 20);
            this.openPdmTxtBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionner la SDM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sélectionner le dernier PDM à jour";
            // 
            // openPdmBtn
            // 
            this.openPdmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openPdmBtn.BackgroundImage")));
            this.openPdmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openPdmBtn.Location = new System.Drawing.Point(44, 116);
            this.openPdmBtn.Name = "openPdmBtn";
            this.openPdmBtn.Size = new System.Drawing.Size(34, 29);
            this.openPdmBtn.TabIndex = 5;
            this.openPdmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openPdmBtn.UseVisualStyleBackColor = true;
            this.openPdmBtn.Click += new System.EventHandler(this.openPdmBtn_Click);
            // 
            // openResultPdmBtn
            // 
            this.openResultPdmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openResultPdmBtn.BackgroundImage")));
            this.openResultPdmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openResultPdmBtn.Location = new System.Drawing.Point(44, 254);
            this.openResultPdmBtn.Name = "openResultPdmBtn";
            this.openResultPdmBtn.Size = new System.Drawing.Size(34, 29);
            this.openResultPdmBtn.TabIndex = 8;
            this.openResultPdmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openResultPdmBtn.UseVisualStyleBackColor = true;
            this.openResultPdmBtn.Click += new System.EventHandler(this.openResultPdmBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(44, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sélectionner le dossier où sera généré le PDM";
            // 
            // openResultPdmTxtBx
            // 
            this.openResultPdmTxtBx.Enabled = false;
            this.openResultPdmTxtBx.Location = new System.Drawing.Point(84, 259);
            this.openResultPdmTxtBx.Name = "openResultPdmTxtBx";
            this.openResultPdmTxtBx.Size = new System.Drawing.Size(536, 20);
            this.openResultPdmTxtBx.TabIndex = 6;
            // 
            // generatePdmBtn
            // 
            this.generatePdmBtn.Enabled = false;
            this.generatePdmBtn.Location = new System.Drawing.Point(44, 314);
            this.generatePdmBtn.Name = "generatePdmBtn";
            this.generatePdmBtn.Size = new System.Drawing.Size(279, 66);
            this.generatePdmBtn.TabIndex = 9;
            this.generatePdmBtn.Text = "Générer le nouveau PDM";
            this.generatePdmBtn.UseVisualStyleBackColor = true;
            this.generatePdmBtn.Click += new System.EventHandler(this.generatePdmBtn_Click);
            // 
            // openContextVarBtn
            // 
            this.openContextVarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openContextVarBtn.BackgroundImage")));
            this.openContextVarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openContextVarBtn.Location = new System.Drawing.Point(44, 186);
            this.openContextVarBtn.Name = "openContextVarBtn";
            this.openContextVarBtn.Size = new System.Drawing.Size(34, 29);
            this.openContextVarBtn.TabIndex = 12;
            this.openContextVarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openContextVarBtn.UseVisualStyleBackColor = true;
            this.openContextVarBtn.Click += new System.EventHandler(this.openContextVarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sélectionner la liste des variables de contexte";
            // 
            // openContextVarTxtBx
            // 
            this.openContextVarTxtBx.Enabled = false;
            this.openContextVarTxtBx.Location = new System.Drawing.Point(84, 191);
            this.openContextVarTxtBx.Name = "openContextVarTxtBx";
            this.openContextVarTxtBx.Size = new System.Drawing.Size(536, 20);
            this.openContextVarTxtBx.TabIndex = 10;
            // 
            // consoleRchTxtBx
            // 
            this.consoleRchTxtBx.Location = new System.Drawing.Point(664, 57);
            this.consoleRchTxtBx.Name = "consoleRchTxtBx";
            this.consoleRchTxtBx.Size = new System.Drawing.Size(485, 469);
            this.consoleRchTxtBx.TabIndex = 13;
            this.consoleRchTxtBx.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resultat :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.consoleRchTxtBx);
            this.Controls.Add(this.openContextVarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openContextVarTxtBx);
            this.Controls.Add(this.generatePdmBtn);
            this.Controls.Add(this.openResultPdmBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openResultPdmTxtBx);
            this.Controls.Add(this.openPdmBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openPdmTxtBx);
            this.Controls.Add(this.openSdmTxtBx);
            this.Controls.Add(this.openSdmBtn);
            this.Name = "Form1";
            this.Text = "PDM Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openSdmBtn;
        private System.Windows.Forms.TextBox openSdmTxtBx;
        private System.Windows.Forms.TextBox openPdmTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openPdmBtn;
        private System.Windows.Forms.Button openResultPdmBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox openResultPdmTxtBx;
        private System.Windows.Forms.Button generatePdmBtn;
        private System.Windows.Forms.Button openContextVarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox openContextVarTxtBx;
        private System.Windows.Forms.RichTextBox consoleRchTxtBx;
        private System.Windows.Forms.Label label5;
    }
}


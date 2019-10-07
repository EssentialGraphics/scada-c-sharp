namespace csScada
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tagLabel1 = new csScada.TagLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagLabel2 = new csScada.TagLabel();
            this.tagLabel3 = new csScada.TagLabel();
            this.tagProgressBar1 = new csScada.TagProgressBar();
            this.tagProgressBar2 = new csScada.TagProgressBar();
            this.tagProgressBar3 = new csScada.TagProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAG1 value:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tagLabel1
            // 
            this.tagLabel1.AutoSize = true;
            this.tagLabel1.Location = new System.Drawing.Point(100, 21);
            this.tagLabel1.Name = "tagLabel1";
            this.tagLabel1.Size = new System.Drawing.Size(54, 13);
            this.tagLabel1.TabIndex = 1;
            this.tagLabel1.TagName = "@VAR1";
            this.tagLabel1.Text = "tagLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TAG2 value:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TAG3 value:";
            // 
            // tagLabel2
            // 
            this.tagLabel2.AutoSize = true;
            this.tagLabel2.Location = new System.Drawing.Point(100, 85);
            this.tagLabel2.Name = "tagLabel2";
            this.tagLabel2.Size = new System.Drawing.Size(54, 13);
            this.tagLabel2.TabIndex = 4;
            this.tagLabel2.TagName = "@VAR2";
            this.tagLabel2.Text = "tagLabel2";
            // 
            // tagLabel3
            // 
            this.tagLabel3.AutoSize = true;
            this.tagLabel3.Location = new System.Drawing.Point(100, 151);
            this.tagLabel3.Name = "tagLabel3";
            this.tagLabel3.Size = new System.Drawing.Size(54, 13);
            this.tagLabel3.TabIndex = 5;
            this.tagLabel3.TagName = "@VAR3";
            this.tagLabel3.Text = "tagLabel3";
            // 
            // tagProgressBar1
            // 
            this.tagProgressBar1.Location = new System.Drawing.Point(160, 21);
            this.tagProgressBar1.Name = "tagProgressBar1";
            this.tagProgressBar1.Size = new System.Drawing.Size(123, 13);
            this.tagProgressBar1.TabIndex = 6;
            this.tagProgressBar1.TagName = "@VAR1";
            // 
            // tagProgressBar2
            // 
            this.tagProgressBar2.Location = new System.Drawing.Point(160, 85);
            this.tagProgressBar2.Name = "tagProgressBar2";
            this.tagProgressBar2.Size = new System.Drawing.Size(123, 13);
            this.tagProgressBar2.TabIndex = 7;
            this.tagProgressBar2.TagName = "@VAR2";
            // 
            // tagProgressBar3
            // 
            this.tagProgressBar3.Location = new System.Drawing.Point(160, 151);
            this.tagProgressBar3.Name = "tagProgressBar3";
            this.tagProgressBar3.Size = new System.Drawing.Size(123, 13);
            this.tagProgressBar3.TabIndex = 8;
            this.tagProgressBar3.TagName = "@VAR3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 195);
            this.Controls.Add(this.tagProgressBar3);
            this.Controls.Add(this.tagProgressBar2);
            this.Controls.Add(this.tagProgressBar1);
            this.Controls.Add(this.tagLabel3);
            this.Controls.Add(this.tagLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "C# SCADA - Simplest demo";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TagLabel tagControlLabel1;
        private TagLabel tagLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TagLabel tagLabel2;
        private TagLabel tagLabel3;
        private TagProgressBar tagProgressBar1;
        private TagProgressBar tagProgressBar2;
        private TagProgressBar tagProgressBar3;
    }
}


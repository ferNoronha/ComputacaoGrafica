namespace Primitivas
{
    partial class Primitivas
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.gbRetas = new System.Windows.Forms.GroupBox();
            this.btnBresenhamReta = new System.Windows.Forms.Button();
            this.btnDDA = new System.Windows.Forms.Button();
            this.btnEqGeralReta = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.gbCircunf = new System.Windows.Forms.GroupBox();
            this.btnBresenhamCircunf = new System.Windows.Forms.Button();
            this.btnTrig = new System.Windows.Forms.Button();
            this.btnEqGeralCircunf = new System.Windows.Forms.Button();
            this.gbElipse = new System.Windows.Forms.GroupBox();
            this.btnBresenhamElipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.gbRetas.SuspendLayout();
            this.gbCircunf.SuspendLayout();
            this.gbElipse.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(790, 543);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // gbRetas
            // 
            this.gbRetas.Controls.Add(this.btnBresenhamReta);
            this.gbRetas.Controls.Add(this.btnDDA);
            this.gbRetas.Controls.Add(this.btnEqGeralReta);
            this.gbRetas.Location = new System.Drawing.Point(819, 12);
            this.gbRetas.Name = "gbRetas";
            this.gbRetas.Size = new System.Drawing.Size(183, 76);
            this.gbRetas.TabIndex = 1;
            this.gbRetas.TabStop = false;
            this.gbRetas.Text = "Retas";
            // 
            // btnBresenhamReta
            // 
            this.btnBresenhamReta.Location = new System.Drawing.Point(49, 48);
            this.btnBresenhamReta.Name = "btnBresenhamReta";
            this.btnBresenhamReta.Size = new System.Drawing.Size(75, 23);
            this.btnBresenhamReta.TabIndex = 2;
            this.btnBresenhamReta.Text = "Bresenham";
            this.btnBresenhamReta.UseVisualStyleBackColor = true;
            this.btnBresenhamReta.Click += new System.EventHandler(this.btnBresenhamReta_Click);
            // 
            // btnDDA
            // 
            this.btnDDA.Location = new System.Drawing.Point(87, 19);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(75, 23);
            this.btnDDA.TabIndex = 1;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // btnEqGeralReta
            // 
            this.btnEqGeralReta.Location = new System.Drawing.Point(6, 19);
            this.btnEqGeralReta.Name = "btnEqGeralReta";
            this.btnEqGeralReta.Size = new System.Drawing.Size(75, 23);
            this.btnEqGeralReta.TabIndex = 0;
            this.btnEqGeralReta.Text = "Eq Geral";
            this.btnEqGeralReta.UseVisualStyleBackColor = true;
            this.btnEqGeralReta.Click += new System.EventHandler(this.btnEqGeral_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(12, 561);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(75, 23);
            this.btnResetar.TabIndex = 2;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // gbCircunf
            // 
            this.gbCircunf.Controls.Add(this.btnBresenhamCircunf);
            this.gbCircunf.Controls.Add(this.btnTrig);
            this.gbCircunf.Controls.Add(this.btnEqGeralCircunf);
            this.gbCircunf.Location = new System.Drawing.Point(819, 94);
            this.gbCircunf.Name = "gbCircunf";
            this.gbCircunf.Size = new System.Drawing.Size(183, 76);
            this.gbCircunf.TabIndex = 3;
            this.gbCircunf.TabStop = false;
            this.gbCircunf.Text = "Circunferências";
            // 
            // btnBresenhamCircunf
            // 
            this.btnBresenhamCircunf.Location = new System.Drawing.Point(49, 48);
            this.btnBresenhamCircunf.Name = "btnBresenhamCircunf";
            this.btnBresenhamCircunf.Size = new System.Drawing.Size(75, 23);
            this.btnBresenhamCircunf.TabIndex = 2;
            this.btnBresenhamCircunf.Text = "Bresenham";
            this.btnBresenhamCircunf.UseVisualStyleBackColor = true;
            this.btnBresenhamCircunf.Click += new System.EventHandler(this.btnBresenhamCircunf_Click);
            // 
            // btnTrig
            // 
            this.btnTrig.Location = new System.Drawing.Point(87, 19);
            this.btnTrig.Name = "btnTrig";
            this.btnTrig.Size = new System.Drawing.Size(89, 23);
            this.btnTrig.TabIndex = 1;
            this.btnTrig.Text = "Trigonométrica";
            this.btnTrig.UseVisualStyleBackColor = true;
            this.btnTrig.Click += new System.EventHandler(this.btnTrig_Click);
            // 
            // btnEqGeralCircunf
            // 
            this.btnEqGeralCircunf.Location = new System.Drawing.Point(6, 19);
            this.btnEqGeralCircunf.Name = "btnEqGeralCircunf";
            this.btnEqGeralCircunf.Size = new System.Drawing.Size(75, 23);
            this.btnEqGeralCircunf.TabIndex = 0;
            this.btnEqGeralCircunf.Text = "Eq Geral";
            this.btnEqGeralCircunf.UseVisualStyleBackColor = true;
            this.btnEqGeralCircunf.Click += new System.EventHandler(this.btnEqGeralCircunf_Click);
            // 
            // gbElipse
            // 
            this.gbElipse.Controls.Add(this.btnBresenhamElipse);
            this.gbElipse.Location = new System.Drawing.Point(819, 176);
            this.gbElipse.Name = "gbElipse";
            this.gbElipse.Size = new System.Drawing.Size(183, 76);
            this.gbElipse.TabIndex = 4;
            this.gbElipse.TabStop = false;
            this.gbElipse.Text = "Elipse";
            // 
            // btnBresenhamElipse
            // 
            this.btnBresenhamElipse.Location = new System.Drawing.Point(49, 34);
            this.btnBresenhamElipse.Name = "btnBresenhamElipse";
            this.btnBresenhamElipse.Size = new System.Drawing.Size(75, 23);
            this.btnBresenhamElipse.TabIndex = 0;
            this.btnBresenhamElipse.Text = "Bresenham";
            this.btnBresenhamElipse.UseVisualStyleBackColor = true;
            this.btnBresenhamElipse.Click += new System.EventHandler(this.btnBresenhamElipse_Click);
            // 
            // Primitivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 681);
            this.Controls.Add(this.gbElipse);
            this.Controls.Add(this.gbCircunf);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.gbRetas);
            this.Controls.Add(this.picBox);
            this.Name = "Primitivas";
            this.Text = "Primitivas Gráficas";
            this.Load += new System.EventHandler(this.Primitivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.gbRetas.ResumeLayout(false);
            this.gbCircunf.ResumeLayout(false);
            this.gbElipse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox gbRetas;
        private System.Windows.Forms.Button btnBresenhamReta;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnEqGeralReta;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.GroupBox gbCircunf;
        private System.Windows.Forms.Button btnBresenhamCircunf;
        private System.Windows.Forms.Button btnTrig;
        private System.Windows.Forms.Button btnEqGeralCircunf;
        private System.Windows.Forms.GroupBox gbElipse;
        private System.Windows.Forms.Button btnBresenhamElipse;
    }
}


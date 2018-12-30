namespace Atividade1
{
    partial class Form1
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
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbox
            // 
            this.pcbox.Location = new System.Drawing.Point(12, 12);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(609, 416);
            this.pcbox.TabIndex = 0;
            this.pcbox.TabStop = false;
            this.pcbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mover);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(691, 63);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(691, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(644, 172);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 13);
            this.lblR.TabIndex = 3;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(712, 172);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 13);
            this.lblC.TabIndex = 4;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(785, 172);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(0, 13);
            this.lblH.TabIndex = 5;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(644, 212);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(0, 13);
            this.lblG.TabIndex = 6;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(712, 212);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(0, 13);
            this.lblM.TabIndex = 7;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(785, 212);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 13);
            this.lblS.TabIndex = 8;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(644, 248);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 13);
            this.lblB.TabIndex = 9;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(712, 248);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 13);
            this.lblY.TabIndex = 10;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(785, 248);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(0, 13);
            this.lblI.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(647, 383);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 468);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.pcbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}


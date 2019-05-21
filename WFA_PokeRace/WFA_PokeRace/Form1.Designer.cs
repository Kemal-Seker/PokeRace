namespace WFA_PokeRace
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
            this.components = new System.ComponentModel.Container();
            this.pctFinishLine = new System.Windows.Forms.PictureBox();
            this.pctPoke4 = new System.Windows.Forms.PictureBox();
            this.pctPoke3 = new System.Windows.Forms.PictureBox();
            this.pctPoke2 = new System.Windows.Forms.PictureBox();
            this.pctPoke1 = new System.Windows.Forms.PictureBox();
            this.pctFloor = new System.Windows.Forms.PictureBox();
            this.pctArena = new System.Windows.Forms.PictureBox();
            this.cmbArena = new System.Windows.Forms.ComboBox();
            this.lblArena = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArena)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFinishLine
            // 
            this.pctFinishLine.Location = new System.Drawing.Point(764, 159);
            this.pctFinishLine.Name = "pctFinishLine";
            this.pctFinishLine.Size = new System.Drawing.Size(10, 288);
            this.pctFinishLine.TabIndex = 6;
            this.pctFinishLine.TabStop = false;
            // 
            // pctPoke4
            // 
            this.pctPoke4.Location = new System.Drawing.Point(25, 373);
            this.pctPoke4.Name = "pctPoke4";
            this.pctPoke4.Size = new System.Drawing.Size(65, 68);
            this.pctPoke4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPoke4.TabIndex = 5;
            this.pctPoke4.TabStop = false;
            this.pctPoke4.Click += new System.EventHandler(this.pct_Click);
            // 
            // pctPoke3
            // 
            this.pctPoke3.Location = new System.Drawing.Point(25, 304);
            this.pctPoke3.Name = "pctPoke3";
            this.pctPoke3.Size = new System.Drawing.Size(65, 63);
            this.pctPoke3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPoke3.TabIndex = 4;
            this.pctPoke3.TabStop = false;
            this.pctPoke3.Click += new System.EventHandler(this.pct_Click);
            // 
            // pctPoke2
            // 
            this.pctPoke2.Location = new System.Drawing.Point(25, 234);
            this.pctPoke2.Name = "pctPoke2";
            this.pctPoke2.Size = new System.Drawing.Size(65, 64);
            this.pctPoke2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPoke2.TabIndex = 3;
            this.pctPoke2.TabStop = false;
            this.pctPoke2.Click += new System.EventHandler(this.pct_Click);
            // 
            // pctPoke1
            // 
            this.pctPoke1.Location = new System.Drawing.Point(25, 159);
            this.pctPoke1.Name = "pctPoke1";
            this.pctPoke1.Size = new System.Drawing.Size(65, 69);
            this.pctPoke1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPoke1.TabIndex = 2;
            this.pctPoke1.TabStop = false;
            this.pctPoke1.Click += new System.EventHandler(this.pct_Click);
            // 
            // pctFloor
            // 
            this.pctFloor.Location = new System.Drawing.Point(12, 148);
            this.pctFloor.Name = "pctFloor";
            this.pctFloor.Size = new System.Drawing.Size(775, 306);
            this.pctFloor.TabIndex = 1;
            this.pctFloor.TabStop = false;
            // 
            // pctArena
            // 
            this.pctArena.Location = new System.Drawing.Point(158, 23);
            this.pctArena.Name = "pctArena";
            this.pctArena.Size = new System.Drawing.Size(452, 119);
            this.pctArena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctArena.TabIndex = 0;
            this.pctArena.TabStop = false;
            // 
            // cmbArena
            // 
            this.cmbArena.FormattingEnabled = true;
            this.cmbArena.Location = new System.Drawing.Point(666, 23);
            this.cmbArena.Name = "cmbArena";
            this.cmbArena.Size = new System.Drawing.Size(121, 24);
            this.cmbArena.TabIndex = 7;
            this.cmbArena.SelectedIndexChanged += new System.EventHandler(this.cmbArena_SelectedIndexChanged);
            // 
            // lblArena
            // 
            this.lblArena.AutoSize = true;
            this.lblArena.Location = new System.Drawing.Point(617, 29);
            this.lblArena.Name = "lblArena";
            this.lblArena.Size = new System.Drawing.Size(46, 17);
            this.lblArena.TabIndex = 8;
            this.lblArena.Text = "Arena";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 77);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Race";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblArena);
            this.Controls.Add(this.cmbArena);
            this.Controls.Add(this.pctFinishLine);
            this.Controls.Add(this.pctPoke4);
            this.Controls.Add(this.pctPoke3);
            this.Controls.Add(this.pctPoke2);
            this.Controls.Add(this.pctPoke1);
            this.Controls.Add(this.pctFloor);
            this.Controls.Add(this.pctArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctArena;
        private System.Windows.Forms.PictureBox pctFloor;
        private System.Windows.Forms.PictureBox pctPoke1;
        private System.Windows.Forms.PictureBox pctPoke2;
        private System.Windows.Forms.PictureBox pctPoke3;
        private System.Windows.Forms.PictureBox pctPoke4;
        private System.Windows.Forms.PictureBox pctFinishLine;
        private System.Windows.Forms.ComboBox cmbArena;
        private System.Windows.Forms.Label lblArena;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}


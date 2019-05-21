namespace WFA_PokeRace
{
    partial class frmChooseRacer
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
            this.lblPoke = new System.Windows.Forms.Label();
            this.cmbPoke = new System.Windows.Forms.ComboBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoke
            // 
            this.lblPoke.AutoSize = true;
            this.lblPoke.Location = new System.Drawing.Point(13, 32);
            this.lblPoke.Name = "lblPoke";
            this.lblPoke.Size = new System.Drawing.Size(79, 17);
            this.lblPoke.TabIndex = 0;
            this.lblPoke.Text = "Pokemon : ";
            // 
            // cmbPoke
            // 
            this.cmbPoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoke.FormattingEnabled = true;
            this.cmbPoke.Location = new System.Drawing.Point(92, 23);
            this.cmbPoke.Name = "cmbPoke";
            this.cmbPoke.Size = new System.Drawing.Size(121, 24);
            this.cmbPoke.TabIndex = 1;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(12, 71);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(61, 17);
            this.lblOwner.TabIndex = 0;
            this.lblOwner.Text = "Owner : ";
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(91, 62);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(121, 24);
            this.cmbOwner.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(60, 120);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChooseRacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 155);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.cmbPoke);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblPoke);
            this.Name = "frmChooseRacer";
            this.Text = "frmChooseRacer";
            this.Load += new System.EventHandler(this.frmChooseRacer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoke;
        private System.Windows.Forms.ComboBox cmbPoke;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace PraktikumADO
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitungDsn = new System.Windows.Forms.Button();
            this.btnUpdateMK = new System.Windows.Forms.Button();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Location = new System.Drawing.Point(103, 258);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(199, 258);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(291, 258);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "Hitung Mk";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(382, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Mhs";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "HASIL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(183, 93);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(351, 20);
            this.txtHasil.TabIndex = 5;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // btnHitungDsn
            // 
            this.btnHitungDsn.Location = new System.Drawing.Point(199, 287);
            this.btnHitungDsn.Name = "btnHitungDsn";
            this.btnHitungDsn.Size = new System.Drawing.Size(75, 23);
            this.btnHitungDsn.TabIndex = 6;
            this.btnHitungDsn.Text = "Hitung Dsn";
            this.btnHitungDsn.UseVisualStyleBackColor = true;
            this.btnHitungDsn.Click += new System.EventHandler(this.btnHitungDsn_Click);
            // 
            // btnUpdateMK
            // 
            this.btnUpdateMK.Location = new System.Drawing.Point(291, 287);
            this.btnUpdateMK.Name = "btnUpdateMK";
            this.btnUpdateMK.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMK.TabIndex = 7;
            this.btnUpdateMK.Text = "Update MK";
            this.btnUpdateMK.UseVisualStyleBackColor = true;
            this.btnUpdateMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(382, 285);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(75, 23);
            this.btnInsertProdi.TabIndex = 8;
            this.btnInsertProdi.Text = "Insert Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.btnInsertProdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.btnUpdateMK);
            this.Controls.Add(this.btnHitungDsn);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitungDsn;
        private System.Windows.Forms.Button btnUpdateMK;
        private System.Windows.Forms.Button btnInsertProdi;
    }
}


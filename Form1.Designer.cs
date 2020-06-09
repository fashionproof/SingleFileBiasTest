namespace MiscEncrypt
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnCreatePayload = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPaassword = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(128, 36);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select Input File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 51);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(48, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "File Path";
            // 
            // btnCreatePayload
            // 
            this.btnCreatePayload.Location = new System.Drawing.Point(12, 201);
            this.btnCreatePayload.Name = "btnCreatePayload";
            this.btnCreatePayload.Size = new System.Drawing.Size(128, 36);
            this.btnCreatePayload.TabIndex = 2;
            this.btnCreatePayload.Text = "Create Encyrpted Payload";
            this.btnCreatePayload.UseVisualStyleBackColor = true;
            this.btnCreatePayload.Click += new System.EventHandler(this.btnCreatePayload_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(208, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPaassword
            // 
            this.lblPaassword.AutoSize = true;
            this.lblPaassword.Location = new System.Drawing.Point(9, 159);
            this.lblPaassword.Name = "lblPaassword";
            this.lblPaassword.Size = new System.Drawing.Size(145, 13);
            this.lblPaassword.TabIndex = 4;
            this.lblPaassword.Text = "Encrypted Payload Password";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(66, 51);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(19, 13);
            this.lblFilePath.TabIndex = 5;
            this.lblFilePath.Text = "***";
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Location = new System.Drawing.Point(12, 67);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(128, 36);
            this.btnSelectOutput.TabIndex = 6;
            this.btnSelectOutput.Text = "Select Output File";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "File Path";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(66, 106);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(19, 13);
            this.lblOutputFile.TabIndex = 8;
            this.lblOutputFile.Text = "***";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 268);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblPaassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCreatePayload);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnCreatePayload;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPaassword;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


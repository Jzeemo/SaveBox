namespace SaveBox
{
    partial class Form2
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
            this.btnbroswer = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnunlock = new System.Windows.Forms.Button();
            this.txtFIlePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnbroswer
            // 
            this.btnbroswer.Location = new System.Drawing.Point(11, 65);
            this.btnbroswer.Name = "btnbroswer";
            this.btnbroswer.Size = new System.Drawing.Size(75, 23);
            this.btnbroswer.TabIndex = 0;
            this.btnbroswer.Text = "Browse";
            this.btnbroswer.UseVisualStyleBackColor = true;
            this.btnbroswer.Click += new System.EventHandler(this.btnbroswer_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(105, 65);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 1;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnunlock
            // 
            this.btnunlock.Location = new System.Drawing.Point(196, 65);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(75, 23);
            this.btnunlock.TabIndex = 2;
            this.btnunlock.Text = "Unlock";
            this.btnunlock.UseVisualStyleBackColor = true;
            this.btnunlock.Click += new System.EventHandler(this.btnunlock_Click);
            // 
            // txtFIlePath
            // 
            this.txtFIlePath.Location = new System.Drawing.Point(12, 21);
            this.txtFIlePath.Name = "txtFIlePath";
            this.txtFIlePath.Size = new System.Drawing.Size(259, 20);
            this.txtFIlePath.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.txtFIlePath);
            this.Controls.Add(this.btnunlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnbroswer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbroswer;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnunlock;
        private System.Windows.Forms.TextBox txtFIlePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
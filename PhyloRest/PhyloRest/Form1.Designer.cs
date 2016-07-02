namespace PhyloRest
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxProfiles = new System.Windows.Forms.TextBox();
            this.tbxAux = new System.Windows.Forms.TextBox();
            this.btnOpenProfiles = new System.Windows.Forms.Button();
            this.btnOpenAux = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(13, 13);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(100, 20);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.Text = "demo";
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(120, 13);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.Text = "demo";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(227, 9);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "1. Login Demo";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxProfiles
            // 
            this.tbxProfiles.Location = new System.Drawing.Point(13, 40);
            this.tbxProfiles.Name = "tbxProfiles";
            this.tbxProfiles.Size = new System.Drawing.Size(207, 20);
            this.tbxProfiles.TabIndex = 3;
            // 
            // tbxAux
            // 
            this.tbxAux.Location = new System.Drawing.Point(13, 67);
            this.tbxAux.Name = "tbxAux";
            this.tbxAux.Size = new System.Drawing.Size(207, 20);
            this.tbxAux.TabIndex = 4;
            // 
            // btnOpenProfiles
            // 
            this.btnOpenProfiles.Location = new System.Drawing.Point(227, 36);
            this.btnOpenProfiles.Name = "btnOpenProfiles";
            this.btnOpenProfiles.Size = new System.Drawing.Size(75, 23);
            this.btnOpenProfiles.TabIndex = 5;
            this.btnOpenProfiles.Text = "2. Profiles";
            this.btnOpenProfiles.UseVisualStyleBackColor = true;
            this.btnOpenProfiles.Click += new System.EventHandler(this.btnOpenProfiles_Click);
            // 
            // btnOpenAux
            // 
            this.btnOpenAux.Location = new System.Drawing.Point(227, 66);
            this.btnOpenAux.Name = "btnOpenAux";
            this.btnOpenAux.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAux.TabIndex = 6;
            this.btnOpenAux.Text = "3. Metadata";
            this.btnOpenAux.UseVisualStyleBackColor = true;
            this.btnOpenAux.Click += new System.EventHandler(this.btnOpenAux_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(13, 94);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "4. Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(353, 69);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "5. GoeBurst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(175, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "6. Make Visible";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "7. Public Link";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 205);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpenAux);
            this.Controls.Add(this.btnOpenProfiles);
            this.Controls.Add(this.tbxAux);
            this.Controls.Add(this.tbxProfiles);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxProfiles;
        private System.Windows.Forms.TextBox tbxAux;
        private System.Windows.Forms.Button btnOpenProfiles;
        private System.Windows.Forms.Button btnOpenAux;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


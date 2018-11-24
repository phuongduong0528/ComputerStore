namespace ComputerStore.FormApplication
{
    partial class LogInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxIp = new System.Windows.Forms.TextBox();
            this.txtbxPort = new System.Windows.Forms.TextBox();
            this.txtbxId = new System.Windows.Forms.TextBox();
            this.txtbxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChangeConn = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // txtbxIp
            // 
            this.txtbxIp.Location = new System.Drawing.Point(396, 72);
            this.txtbxIp.Name = "txtbxIp";
            this.txtbxIp.Size = new System.Drawing.Size(129, 25);
            this.txtbxIp.TabIndex = 1;
            this.txtbxIp.Text = "192.168.5.101";
            // 
            // txtbxPort
            // 
            this.txtbxPort.Location = new System.Drawing.Point(395, 109);
            this.txtbxPort.Name = "txtbxPort";
            this.txtbxPort.Size = new System.Drawing.Size(130, 25);
            this.txtbxPort.TabIndex = 1;
            this.txtbxPort.Text = "8733";
            // 
            // txtbxId
            // 
            this.txtbxId.Location = new System.Drawing.Point(73, 63);
            this.txtbxId.Name = "txtbxId";
            this.txtbxId.Size = new System.Drawing.Size(248, 25);
            this.txtbxId.TabIndex = 2;
            // 
            // txtbxPass
            // 
            this.txtbxPass.Location = new System.Drawing.Point(73, 114);
            this.txtbxPass.Name = "txtbxPass";
            this.txtbxPass.PasswordChar = '*';
            this.txtbxPass.Size = new System.Drawing.Size(248, 25);
            this.txtbxPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "LOG IN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.Location = new System.Drawing.Point(9, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 49);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập  ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(195, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát  ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnChangeConn
            // 
            this.btnChangeConn.FlatAppearance.BorderSize = 0;
            this.btnChangeConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnChangeConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeConn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeConn.ForeColor = System.Drawing.Color.Green;
            this.btnChangeConn.Location = new System.Drawing.Point(396, 140);
            this.btnChangeConn.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeConn.Name = "btnChangeConn";
            this.btnChangeConn.Size = new System.Drawing.Size(65, 65);
            this.btnChangeConn.TabIndex = 5;
            this.btnChangeConn.Text = "\r\nLưu";
            this.btnChangeConn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeConn.UseVisualStyleBackColor = true;
            this.btnChangeConn.Click += new System.EventHandler(this.btnChangeConn_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.FlatAppearance.BorderSize = 0;
            this.btnTestConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTestConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConn.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTestConn.Location = new System.Drawing.Point(460, 141);
            this.btnTestConn.Margin = new System.Windows.Forms.Padding(0);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(65, 65);
            this.btnTestConn.TabIndex = 5;
            this.btnTestConn.Text = "\r\nKT\r\nKết nối";
            this.btnTestConn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatus.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 221);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.btnChangeConn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxPass);
            this.Controls.Add(this.txtbxId);
            this.Controls.Add(this.txtbxPort);
            this.Controls.Add(this.txtbxIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxIp;
        private System.Windows.Forms.TextBox txtbxPort;
        private System.Windows.Forms.TextBox txtbxId;
        private System.Windows.Forms.TextBox txtbxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChangeConn;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Label lblStatus;
    }
}
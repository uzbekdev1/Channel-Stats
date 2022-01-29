
namespace StatsApp.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbxLogs = new System.Windows.Forms.RichTextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxChannel = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxHash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(411, 292);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone number:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(231, 25);
            this.tbxPhone.Mask = "00-000-0000";
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(97, 26);
            this.tbxPhone.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbxLogs);
            this.groupBox2.Location = new System.Drawing.Point(69, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 194);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation logs";
            // 
            // rbxLogs
            // 
            this.rbxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbxLogs.Location = new System.Drawing.Point(3, 22);
            this.rbxLogs.Name = "rbxLogs";
            this.rbxLogs.Size = new System.Drawing.Size(459, 169);
            this.rbxLogs.TabIndex = 7;
            this.rbxLogs.Text = "";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(231, 69);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(183, 26);
            this.tbxPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cloud password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Channel id:";
            // 
            // tbxChannel
            // 
            this.tbxChannel.Location = new System.Drawing.Point(231, 158);
            this.tbxChannel.Name = "tbxChannel";
            this.tbxChannel.Size = new System.Drawing.Size(183, 26);
            this.tbxChannel.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(231, 111);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '*';
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(183, 26);
            this.tbxEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Recover e-mail:";
            // 
            // tbxHash
            // 
            this.tbxHash.Location = new System.Drawing.Point(231, 248);
            this.tbxHash.Name = "tbxHash";
            this.tbxHash.Size = new System.Drawing.Size(300, 26);
            this.tbxHash.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Api hash:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(231, 200);
            this.tbxId.Mask = "0000000000";
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(97, 26);
            this.tbxId.TabIndex = 19;
            this.tbxId.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Api id:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tbxHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxChannel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Channel Stats";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxPhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rbxLogs;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxChannel;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbxId;
        private System.Windows.Forms.Label label2;
    }
}


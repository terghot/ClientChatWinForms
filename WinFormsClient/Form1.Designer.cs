namespace WinFormsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btnMessage = new Button();
            textMessage = new TextBox();
            lblMessage = new Label();
            textName = new TextBox();
            lblName = new Label();
            btnUserName = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(573, 537);
            listBox1.TabIndex = 0;
            // 
            // btnMessage
            // 
            btnMessage.Font = new Font("Segoe UI", 12F);
            btnMessage.Location = new Point(394, 789);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(369, 59);
            btnMessage.TabIndex = 1;
            btnMessage.Text = "Отправить сообщение";
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnMessage_Click;
            // 
            // textMessage
            // 
            textMessage.Font = new Font("Segoe UI", 13F);
            textMessage.Location = new Point(394, 725);
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(369, 48);
            textMessage.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 13F);
            lblMessage.Location = new Point(447, 651);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(185, 42);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Сообщение";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 13F);
            textName.Location = new Point(54, 725);
            textName.Name = "textName";
            textName.Size = new Size(206, 48);
            textName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13F);
            lblName.Location = new Point(82, 663);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 42);
            lblName.TabIndex = 5;
            lblName.Text = "UserName:";
            // 
            // btnUserName
            // 
            btnUserName.Font = new Font("Segoe UI", 12F);
            btnUserName.Location = new Point(28, 789);
            btnUserName.Name = "btnUserName";
            btnUserName.Size = new Size(262, 59);
            btnUserName.TabIndex = 7;
            btnUserName.Text = "Отправить Name";
            btnUserName.UseVisualStyleBackColor = true;
            btnUserName.Click += btnUserName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 970);
            Controls.Add(btnUserName);
            Controls.Add(lblName);
            Controls.Add(textName);
            Controls.Add(lblMessage);
            Controls.Add(textMessage);
            Controls.Add(btnMessage);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnMessage;
        private TextBox textMessage;
        private Label lblMessage;
        private TextBox textName;
        private Label lblName;
        private Button btnUserName;
    }
}

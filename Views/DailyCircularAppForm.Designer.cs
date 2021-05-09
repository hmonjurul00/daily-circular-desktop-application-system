
namespace daily_circular_desktop_application_system.Views
{
    partial class DailyCircularAppForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.allCircularButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.createCircularButton = new System.Windows.Forms.Button();
            this.userFullName = new System.Windows.Forms.Label();
            this.myCircularButton = new System.Windows.Forms.Button();
            this.allCircularPanel = new System.Windows.Forms.Panel();
            this.allCircularFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.myCircularPanel = new System.Windows.Forms.Panel();
            this.myCircularFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createCircularPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            this.allCircularPanel.SuspendLayout();
            this.myCircularPanel.SuspendLayout();
            this.createCircularPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuPanel.Controls.Add(this.allCircularButton);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.createCircularButton);
            this.menuPanel.Controls.Add(this.userFullName);
            this.menuPanel.Controls.Add(this.myCircularButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 1);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(850, 30);
            this.menuPanel.TabIndex = 8;
            // 
            // allCircularButton
            // 
            this.allCircularButton.Location = new System.Drawing.Point(3, 0);
            this.allCircularButton.Name = "allCircularButton";
            this.allCircularButton.Size = new System.Drawing.Size(124, 30);
            this.allCircularButton.TabIndex = 4;
            this.allCircularButton.Text = "All Circulars";
            this.allCircularButton.UseVisualStyleBackColor = true;
            this.allCircularButton.Click += new System.EventHandler(this.allCircularButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutButton.Location = new System.Drawing.Point(759, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 30);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // createCircularButton
            // 
            this.createCircularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createCircularButton.Location = new System.Drawing.Point(244, 0);
            this.createCircularButton.Name = "createCircularButton";
            this.createCircularButton.Size = new System.Drawing.Size(137, 30);
            this.createCircularButton.TabIndex = 1;
            this.createCircularButton.Text = "Create Circular";
            this.createCircularButton.UseVisualStyleBackColor = false;
            this.createCircularButton.Click += new System.EventHandler(this.createCircularButton_Click);
            // 
            // userFullName
            // 
            this.userFullName.AutoSize = true;
            this.userFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userFullName.Location = new System.Drawing.Point(602, 3);
            this.userFullName.Name = "userFullName";
            this.userFullName.Size = new System.Drawing.Size(117, 21);
            this.userFullName.TabIndex = 0;
            this.userFullName.Text = "User Full Name";
            // 
            // myCircularButton
            // 
            this.myCircularButton.Location = new System.Drawing.Point(124, 0);
            this.myCircularButton.Name = "myCircularButton";
            this.myCircularButton.Size = new System.Drawing.Size(124, 30);
            this.myCircularButton.TabIndex = 3;
            this.myCircularButton.Text = "My Circulars";
            this.myCircularButton.UseVisualStyleBackColor = true;
            this.myCircularButton.Click += new System.EventHandler(this.myCircularButton_Click);
            // 
            // allCircularPanel
            // 
            this.allCircularPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.allCircularPanel.Controls.Add(this.allCircularFlowLayoutPanel);
            this.allCircularPanel.Location = new System.Drawing.Point(3, 37);
            this.allCircularPanel.Name = "allCircularPanel";
            this.allCircularPanel.Size = new System.Drawing.Size(850, 472);
            this.allCircularPanel.TabIndex = 9;
            // 
            // allCircularFlowLayoutPanel
            // 
            this.allCircularFlowLayoutPanel.AutoScroll = true;
            this.allCircularFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCircularFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.allCircularFlowLayoutPanel.Name = "allCircularFlowLayoutPanel";
            this.allCircularFlowLayoutPanel.Size = new System.Drawing.Size(850, 472);
            this.allCircularFlowLayoutPanel.TabIndex = 0;
            // 
            // myCircularPanel
            // 
            this.myCircularPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.myCircularPanel.Controls.Add(this.myCircularFlowLayoutPanel);
            this.myCircularPanel.Location = new System.Drawing.Point(3, 37);
            this.myCircularPanel.Name = "myCircularPanel";
            this.myCircularPanel.Size = new System.Drawing.Size(850, 472);
            this.myCircularPanel.TabIndex = 10;
            // 
            // myCircularFlowLayoutPanel
            // 
            this.myCircularFlowLayoutPanel.AutoScroll = true;
            this.myCircularFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCircularFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.myCircularFlowLayoutPanel.Name = "myCircularFlowLayoutPanel";
            this.myCircularFlowLayoutPanel.Size = new System.Drawing.Size(850, 472);
            this.myCircularFlowLayoutPanel.TabIndex = 0;
            // 
            // createCircularPanel
            // 
            this.createCircularPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createCircularPanel.Controls.Add(this.button1);
            this.createCircularPanel.Controls.Add(this.button3);
            this.createCircularPanel.Controls.Add(this.richTextBox1);
            this.createCircularPanel.Controls.Add(this.label3);
            this.createCircularPanel.Controls.Add(this.label2);
            this.createCircularPanel.Controls.Add(this.textBox1);
            this.createCircularPanel.Location = new System.Drawing.Point(3, 37);
            this.createCircularPanel.Name = "createCircularPanel";
            this.createCircularPanel.Size = new System.Drawing.Size(840, 472);
            this.createCircularPanel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(701, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(71, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Post";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(71, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(705, 242);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Write Circular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DailyCircularAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 511);
            this.Controls.Add(this.myCircularPanel);
            this.Controls.Add(this.allCircularPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.createCircularPanel);
            this.Name = "DailyCircularAppForm";
            this.Text = "DailyCircularAppForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.allCircularPanel.ResumeLayout(false);
            this.myCircularPanel.ResumeLayout(false);
            this.createCircularPanel.ResumeLayout(false);
            this.createCircularPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button allCircularButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button createCircularButton;
        private System.Windows.Forms.Label userFullName;
        private System.Windows.Forms.Button myCircularButton;
        private System.Windows.Forms.Panel allCircularPanel;
        private System.Windows.Forms.Panel myCircularPanel;
        private System.Windows.Forms.Panel createCircularPanel;
        private System.Windows.Forms.FlowLayoutPanel allCircularFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel myCircularFlowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
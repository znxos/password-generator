namespace password_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.PSG = new System.Windows.Forms.NotifyIcon(this.components);
            this.open_and_quit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasswordHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GetInTouch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BuyMeCoffee = new System.Windows.Forms.ToolStripMenuItem();
            this.Email = new System.Windows.Forms.ToolStripMenuItem();
            this.GitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Placeholder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Placeholder2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.Guide = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.progressBarStrength = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.open_and_quit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(415, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(142, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(158, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = " ";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length (Max. 20)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Uppercase";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(58, 230);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Lowercase";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(58, 254);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Numbers";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(58, 278);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Symbols";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(58, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 82);
            this.button2.TabIndex = 8;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(48, 139);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // PSG
            // 
            this.PSG.ContextMenuStrip = this.open_and_quit;
            this.PSG.Icon = ((System.Drawing.Icon)(resources.GetObject("PSG.Icon")));
            this.PSG.Text = "PS-WRD GEN.";
            this.PSG.Visible = true;
            this.PSG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PSG_MouseClick);
            this.PSG.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PSG_MouseDoubleClick);
            // 
            // open_and_quit
            // 
            this.open_and_quit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Quit});
            this.open_and_quit.Name = "open_and_quit";
            this.open_and_quit.Size = new System.Drawing.Size(104, 48);
            // 
            // Open
            // 
            this.Open.CheckOnClick = true;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(103, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Quit
            // 
            this.Quit.CheckOnClick = true;
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(103, 22);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 43);
            this.panel1.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(288, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 40);
            this.button5.TabIndex = 2;
            this.button5.Text = "___";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(380, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 40);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasswordHistory,
            this.toolStripSeparator1,
            this.GetInTouch,
            this.toolStripSeparator4,
            this.BuyMeCoffee,
            this.Email,
            this.GitHub,
            this.toolStripSeparator2,
            this.Placeholder,
            this.toolStripSeparator5,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripSeparator6,
            this.Placeholder2,
            this.toolStripSeparator7,
            this.Help,
            this.Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 326);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // PasswordHistory
            // 
            this.PasswordHistory.Name = "PasswordHistory";
            this.PasswordHistory.Size = new System.Drawing.Size(186, 22);
            this.PasswordHistory.Text = "Password History";
            this.PasswordHistory.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // GetInTouch
            // 
            this.GetInTouch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GetInTouch.Enabled = false;
            this.GetInTouch.Name = "GetInTouch";
            this.GetInTouch.Size = new System.Drawing.Size(186, 22);
            this.GetInTouch.Text = "Get in Touch";
            this.GetInTouch.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // BuyMeCoffee
            // 
            this.BuyMeCoffee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyMeCoffee.Name = "BuyMeCoffee";
            this.BuyMeCoffee.Size = new System.Drawing.Size(186, 22);
            this.BuyMeCoffee.Text = "By Me A Coffee";
            // 
            // Email
            // 
            this.Email.Image = ((System.Drawing.Image)(resources.GetObject("Email.Image")));
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(186, 22);
            this.Email.Text = "Email";
            // 
            // GitHub
            // 
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(186, 22);
            this.GitHub.Text = "GitHub";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // Placeholder
            // 
            this.Placeholder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Placeholder.Enabled = false;
            this.Placeholder.Name = "Placeholder";
            this.Placeholder.Size = new System.Drawing.Size(186, 22);
            this.Placeholder.Text = "Placeholder";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem7.Text = "toolStripMenuItem7";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem8.Text = "toolStripMenuItem8";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem9.Text = "toolStripMenuItem9";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem10.Text = "toolStripMenuItem10";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(183, 6);
            // 
            // Placeholder2
            // 
            this.Placeholder2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Placeholder2.Enabled = false;
            this.Placeholder2.Name = "Placeholder2";
            this.Placeholder2.Size = new System.Drawing.Size(186, 22);
            this.Placeholder2.Text = "Placeholder2";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(183, 6);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Feedback,
            this.Guide,
            this.About});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(186, 22);
            this.Help.Text = "Help";
            this.Help.MouseHover += new System.EventHandler(this.Help_MouseHover);
            // 
            // Feedback
            // 
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(200, 22);
            this.Feedback.Text = "Feedback";
            // 
            // Guide
            // 
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(200, 22);
            this.Guide.Text = "Guide";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(200, 22);
            this.About.Text = "About PASSWORD GEN.";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(186, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "POES-WORD GEN.";
            this.label3.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // progressBarStrength
            // 
            this.progressBarStrength.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarStrength.ForeColor = System.Drawing.SystemColors.MenuText;
            this.progressBarStrength.Location = new System.Drawing.Point(142, 187);
            this.progressBarStrength.Name = "progressBarStrength";
            this.progressBarStrength.Size = new System.Drawing.Size(236, 10);
            this.progressBarStrength.TabIndex = 14;
            this.progressBarStrength.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.progressBarStrength);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PASSWORD GEN.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.open_and_quit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon PSG;
        private System.Windows.Forms.ContextMenuStrip open_and_quit;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PasswordHistory;
        private System.Windows.Forms.ToolStripMenuItem BuyMeCoffee;
        private System.Windows.Forms.ToolStripMenuItem Email;
        private System.Windows.Forms.ToolStripMenuItem GitHub;
        private System.Windows.Forms.ToolStripMenuItem Placeholder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem Placeholder2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem GetInTouch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem Feedback;
        private System.Windows.Forms.ToolStripMenuItem Guide;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ProgressBar progressBarStrength;
    }
}


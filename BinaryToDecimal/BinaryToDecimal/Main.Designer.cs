namespace BinaryToDecimal
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsValuesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitNumberLabel = new System.Windows.Forms.Label();
            this.Position_128 = new System.Windows.Forms.TextBox();
            this.Position_64 = new System.Windows.Forms.TextBox();
            this.Position_32 = new System.Windows.Forms.TextBox();
            this.Position_16 = new System.Windows.Forms.TextBox();
            this.Position_8 = new System.Windows.Forms.TextBox();
            this.Position_4 = new System.Windows.Forms.TextBox();
            this.Position_2 = new System.Windows.Forms.TextBox();
            this.Position_1 = new System.Windows.Forms.TextBox();
            this.QuessLabel = new System.Windows.Forms.Label();
            this.Bit_128 = new System.Windows.Forms.TextBox();
            this.Bit_64 = new System.Windows.Forms.TextBox();
            this.Bit_32 = new System.Windows.Forms.TextBox();
            this.Bit_16 = new System.Windows.Forms.TextBox();
            this.Bit_8 = new System.Windows.Forms.TextBox();
            this.Bit_4 = new System.Windows.Forms.TextBox();
            this.Bit_2 = new System.Windows.Forms.TextBox();
            this.Bit_1 = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.NewNumber = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.TextBox();
            this.ValueText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.OptionsMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // FileExitMenuItem
            // 
            this.FileExitMenuItem.Name = "FileExitMenuItem";
            this.FileExitMenuItem.Size = new System.Drawing.Size(93, 22);
            this.FileExitMenuItem.Text = "Exit";
            this.FileExitMenuItem.Click += new System.EventHandler(this.FileExitMenuItem_Click);
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsValuesMenuItem});
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenuItem.Text = "Options";
            // 
            // OptionsValuesMenuItem
            // 
            this.OptionsValuesMenuItem.CheckOnClick = true;
            this.OptionsValuesMenuItem.Name = "OptionsValuesMenuItem";
            this.OptionsValuesMenuItem.Size = new System.Drawing.Size(107, 22);
            this.OptionsValuesMenuItem.Text = "Values";
            this.OptionsValuesMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // HelpAboutMenuItem
            // 
            this.HelpAboutMenuItem.Name = "HelpAboutMenuItem";
            this.HelpAboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.HelpAboutMenuItem.Text = "About";
            this.HelpAboutMenuItem.Click += new System.EventHandler(this.HelpAboutMenuItem_Click);
            // 
            // BitNumberLabel
            // 
            this.BitNumberLabel.AutoSize = true;
            this.BitNumberLabel.Location = new System.Drawing.Point(12, 37);
            this.BitNumberLabel.Name = "BitNumberLabel";
            this.BitNumberLabel.Size = new System.Drawing.Size(51, 15);
            this.BitNumberLabel.TabIndex = 16;
            this.BitNumberLabel.Text = "Postion:";
            // 
            // Position_128
            // 
            this.Position_128.BackColor = System.Drawing.SystemColors.Control;
            this.Position_128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_128.Location = new System.Drawing.Point(67, 34);
            this.Position_128.Name = "Position_128";
            this.Position_128.Size = new System.Drawing.Size(31, 21);
            this.Position_128.TabIndex = 0;
            this.Position_128.TabStop = false;
            this.Position_128.Text = "8";
            this.Position_128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_128.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_128.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_64
            // 
            this.Position_64.BackColor = System.Drawing.SystemColors.Control;
            this.Position_64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_64.Location = new System.Drawing.Point(96, 34);
            this.Position_64.Name = "Position_64";
            this.Position_64.Size = new System.Drawing.Size(31, 21);
            this.Position_64.TabIndex = 2;
            this.Position_64.TabStop = false;
            this.Position_64.Text = "7";
            this.Position_64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_64.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_64.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_32
            // 
            this.Position_32.BackColor = System.Drawing.SystemColors.Control;
            this.Position_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_32.Location = new System.Drawing.Point(126, 34);
            this.Position_32.Name = "Position_32";
            this.Position_32.Size = new System.Drawing.Size(31, 21);
            this.Position_32.TabIndex = 2;
            this.Position_32.TabStop = false;
            this.Position_32.Text = "6";
            this.Position_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_32.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_16
            // 
            this.Position_16.BackColor = System.Drawing.SystemColors.Control;
            this.Position_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_16.Location = new System.Drawing.Point(156, 34);
            this.Position_16.Name = "Position_16";
            this.Position_16.Size = new System.Drawing.Size(31, 21);
            this.Position_16.TabIndex = 2;
            this.Position_16.TabStop = false;
            this.Position_16.Text = "5";
            this.Position_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_16.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_8
            // 
            this.Position_8.BackColor = System.Drawing.SystemColors.Control;
            this.Position_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_8.Location = new System.Drawing.Point(185, 34);
            this.Position_8.Name = "Position_8";
            this.Position_8.Size = new System.Drawing.Size(31, 21);
            this.Position_8.TabIndex = 2;
            this.Position_8.TabStop = false;
            this.Position_8.Text = "4";
            this.Position_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_8.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_4
            // 
            this.Position_4.BackColor = System.Drawing.SystemColors.Control;
            this.Position_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_4.Location = new System.Drawing.Point(215, 34);
            this.Position_4.Name = "Position_4";
            this.Position_4.Size = new System.Drawing.Size(31, 21);
            this.Position_4.TabIndex = 2;
            this.Position_4.TabStop = false;
            this.Position_4.Text = "3";
            this.Position_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_4.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_2
            // 
            this.Position_2.BackColor = System.Drawing.SystemColors.Control;
            this.Position_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_2.Location = new System.Drawing.Point(245, 34);
            this.Position_2.Name = "Position_2";
            this.Position_2.Size = new System.Drawing.Size(31, 21);
            this.Position_2.TabIndex = 2;
            this.Position_2.TabStop = false;
            this.Position_2.Text = "2";
            this.Position_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_2.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_1
            // 
            this.Position_1.BackColor = System.Drawing.SystemColors.Control;
            this.Position_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_1.Location = new System.Drawing.Point(275, 34);
            this.Position_1.Name = "Position_1";
            this.Position_1.Size = new System.Drawing.Size(31, 21);
            this.Position_1.TabIndex = 2;
            this.Position_1.TabStop = false;
            this.Position_1.Text = "1";
            this.Position_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Position_1.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // QuessLabel
            // 
            this.QuessLabel.AutoSize = true;
            this.QuessLabel.Location = new System.Drawing.Point(37, 69);
            this.QuessLabel.Name = "QuessLabel";
            this.QuessLabel.Size = new System.Drawing.Size(24, 15);
            this.QuessLabel.TabIndex = 1;
            this.QuessLabel.Text = "Bit:";
            // 
            // Bit_128
            // 
            this.Bit_128.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_128.Location = new System.Drawing.Point(66, 69);
            this.Bit_128.Name = "Bit_128";
            this.Bit_128.Size = new System.Drawing.Size(31, 21);
            this.Bit_128.TabIndex = 2;
            this.Bit_128.TabStop = false;
            this.Bit_128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_128.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_128.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_64
            // 
            this.Bit_64.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_64.Location = new System.Drawing.Point(96, 69);
            this.Bit_64.Name = "Bit_64";
            this.Bit_64.Size = new System.Drawing.Size(31, 21);
            this.Bit_64.TabIndex = 2;
            this.Bit_64.TabStop = false;
            this.Bit_64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_64.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_64.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_32
            // 
            this.Bit_32.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_32.Location = new System.Drawing.Point(126, 69);
            this.Bit_32.Name = "Bit_32";
            this.Bit_32.Size = new System.Drawing.Size(31, 21);
            this.Bit_32.TabIndex = 2;
            this.Bit_32.TabStop = false;
            this.Bit_32.Text = ".";
            this.Bit_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_32.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_16
            // 
            this.Bit_16.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_16.Location = new System.Drawing.Point(156, 69);
            this.Bit_16.Name = "Bit_16";
            this.Bit_16.Size = new System.Drawing.Size(31, 21);
            this.Bit_16.TabIndex = 2;
            this.Bit_16.TabStop = false;
            this.Bit_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_16.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_8
            // 
            this.Bit_8.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_8.Location = new System.Drawing.Point(185, 69);
            this.Bit_8.Name = "Bit_8";
            this.Bit_8.Size = new System.Drawing.Size(31, 21);
            this.Bit_8.TabIndex = 2;
            this.Bit_8.TabStop = false;
            this.Bit_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_8.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_4
            // 
            this.Bit_4.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_4.Location = new System.Drawing.Point(215, 69);
            this.Bit_4.Name = "Bit_4";
            this.Bit_4.Size = new System.Drawing.Size(31, 21);
            this.Bit_4.TabIndex = 2;
            this.Bit_4.TabStop = false;
            this.Bit_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_4.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_2
            // 
            this.Bit_2.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_2.Location = new System.Drawing.Point(245, 69);
            this.Bit_2.Name = "Bit_2";
            this.Bit_2.Size = new System.Drawing.Size(31, 21);
            this.Bit_2.TabIndex = 2;
            this.Bit_2.TabStop = false;
            this.Bit_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_2.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Bit_1
            // 
            this.Bit_1.BackColor = System.Drawing.SystemColors.Control;
            this.Bit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_1.Location = new System.Drawing.Point(275, 69);
            this.Bit_1.Name = "Bit_1";
            this.Bit_1.Size = new System.Drawing.Size(31, 21);
            this.Bit_1.TabIndex = 2;
            this.Bit_1.TabStop = false;
            this.Bit_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseClick);
            this.Bit_1.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(22, 102);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(41, 15);
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "Value:";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(9, 136);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(91, 23);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // NewNumber
            // 
            this.NewNumber.Location = new System.Drawing.Point(217, 136);
            this.NewNumber.Name = "NewNumber";
            this.NewNumber.Size = new System.Drawing.Size(91, 23);
            this.NewNumber.TabIndex = 4;
            this.NewNumber.Text = "New Number";
            this.NewNumber.UseVisualStyleBackColor = true;
            this.NewNumber.Click += new System.EventHandler(this.NewNumber_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status.Location = new System.Drawing.Point(104, 139);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(108, 14);
            this.Status.TabIndex = 2;
            this.Status.TabStop = false;
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValueText
            // 
            this.ValueText.AcceptsReturn = true;
            this.ValueText.Location = new System.Drawing.Point(67, 99);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(61, 21);
            this.ValueText.TabIndex = 3;
            // 
            // Main
            // 
            this.AcceptButton = this.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 171);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.NewNumber);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.Bit_1);
            this.Controls.Add(this.Bit_2);
            this.Controls.Add(this.Bit_4);
            this.Controls.Add(this.Bit_8);
            this.Controls.Add(this.Bit_16);
            this.Controls.Add(this.Bit_32);
            this.Controls.Add(this.Bit_64);
            this.Controls.Add(this.Bit_128);
            this.Controls.Add(this.QuessLabel);
            this.Controls.Add(this.Position_1);
            this.Controls.Add(this.Position_2);
            this.Controls.Add(this.Position_4);
            this.Controls.Add(this.Position_8);
            this.Controls.Add(this.Position_16);
            this.Controls.Add(this.Position_32);
            this.Controls.Add(this.Position_64);
            this.Controls.Add(this.Position_128);
            this.Controls.Add(this.BitNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Binary To Decimal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsValuesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutMenuItem;
        private System.Windows.Forms.Label BitNumberLabel;
        private System.Windows.Forms.TextBox Position_128;
        private System.Windows.Forms.TextBox Position_64;
        private System.Windows.Forms.TextBox Position_32;
        private System.Windows.Forms.TextBox Position_16;
        private System.Windows.Forms.TextBox Position_8;
        private System.Windows.Forms.TextBox Position_4;
        private System.Windows.Forms.TextBox Position_2;
        private System.Windows.Forms.TextBox Position_1;
        private System.Windows.Forms.Label QuessLabel;
        private System.Windows.Forms.TextBox Bit_128;
        private System.Windows.Forms.TextBox Bit_64;
        private System.Windows.Forms.TextBox Bit_32;
        private System.Windows.Forms.TextBox Bit_16;
        private System.Windows.Forms.TextBox Bit_8;
        private System.Windows.Forms.TextBox Bit_4;
        private System.Windows.Forms.TextBox Bit_2;
        private System.Windows.Forms.TextBox Bit_1;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button NewNumber;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.TextBox ValueText;
    }
}


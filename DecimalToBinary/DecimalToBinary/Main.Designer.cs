namespace DecimalToBinary
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
            this.OptionsHintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.Position_128 = new System.Windows.Forms.TextBox();
            this.Position_64 = new System.Windows.Forms.TextBox();
            this.Position_32 = new System.Windows.Forms.TextBox();
            this.Position_16 = new System.Windows.Forms.TextBox();
            this.Position_8 = new System.Windows.Forms.TextBox();
            this.Position_4 = new System.Windows.Forms.TextBox();
            this.Position_2 = new System.Windows.Forms.TextBox();
            this.Position_1 = new System.Windows.Forms.TextBox();
            this.BitLabel = new System.Windows.Forms.Label();
            this.Bit_128 = new System.Windows.Forms.TextBox();
            this.Bit_64 = new System.Windows.Forms.TextBox();
            this.Bit_32 = new System.Windows.Forms.TextBox();
            this.Bit_16 = new System.Windows.Forms.TextBox();
            this.Bit_8 = new System.Windows.Forms.TextBox();
            this.Bit_4 = new System.Windows.Forms.TextBox();
            this.Bit_2 = new System.Windows.Forms.TextBox();
            this.Bit_1 = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NewNumberButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.OptionsValuesMenuItem,
            this.OptionsHintMenuItem});
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
            this.OptionsValuesMenuItem.Click += new System.EventHandler(this.ValuesMenuItem_Click);
            // 
            // OptionsHintMenuItem
            // 
            this.OptionsHintMenuItem.CheckOnClick = true;
            this.OptionsHintMenuItem.Name = "OptionsHintMenuItem";
            this.OptionsHintMenuItem.Size = new System.Drawing.Size(107, 22);
            this.OptionsHintMenuItem.Text = "Hint";
            this.OptionsHintMenuItem.Click += new System.EventHandler(this.OptionsHintMenuItem_Click);
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
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.Location = new System.Drawing.Point(87, 31);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 15);
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "Vale:";
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Value.Location = new System.Drawing.Point(127, 31);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(19, 15);
            this.Value.TabIndex = 1;
            this.Value.Text = "    ";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositionLabel.Location = new System.Drawing.Point(7, 59);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(54, 15);
            this.PositionLabel.TabIndex = 1;
            this.PositionLabel.Text = "Position:";
            // 
            // Position_128
            // 
            this.Position_128.BackColor = System.Drawing.SystemColors.Control;
            this.Position_128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_128.Location = new System.Drawing.Point(60, 56);
            this.Position_128.Name = "Position_128";
            this.Position_128.ReadOnly = true;
            this.Position_128.Size = new System.Drawing.Size(29, 21);
            this.Position_128.TabIndex = 2;
            this.Position_128.TabStop = false;
            this.Position_128.Text = "8";
            this.Position_128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_128.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_128.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_64
            // 
            this.Position_64.BackColor = System.Drawing.SystemColors.Control;
            this.Position_64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_64.Location = new System.Drawing.Point(89, 56);
            this.Position_64.Name = "Position_64";
            this.Position_64.ReadOnly = true;
            this.Position_64.Size = new System.Drawing.Size(29, 21);
            this.Position_64.TabIndex = 2;
            this.Position_64.TabStop = false;
            this.Position_64.Text = "7";
            this.Position_64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_64.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_64.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_32
            // 
            this.Position_32.BackColor = System.Drawing.SystemColors.Control;
            this.Position_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_32.Location = new System.Drawing.Point(117, 56);
            this.Position_32.Name = "Position_32";
            this.Position_32.ReadOnly = true;
            this.Position_32.Size = new System.Drawing.Size(29, 21);
            this.Position_32.TabIndex = 2;
            this.Position_32.TabStop = false;
            this.Position_32.Text = "6";
            this.Position_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_32.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_16
            // 
            this.Position_16.BackColor = System.Drawing.SystemColors.Control;
            this.Position_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_16.Location = new System.Drawing.Point(143, 56);
            this.Position_16.Name = "Position_16";
            this.Position_16.ReadOnly = true;
            this.Position_16.Size = new System.Drawing.Size(29, 21);
            this.Position_16.TabIndex = 2;
            this.Position_16.TabStop = false;
            this.Position_16.Text = "5";
            this.Position_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_16.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_8
            // 
            this.Position_8.BackColor = System.Drawing.SystemColors.Control;
            this.Position_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_8.Location = new System.Drawing.Point(168, 56);
            this.Position_8.Name = "Position_8";
            this.Position_8.ReadOnly = true;
            this.Position_8.Size = new System.Drawing.Size(29, 21);
            this.Position_8.TabIndex = 2;
            this.Position_8.TabStop = false;
            this.Position_8.Text = "4";
            this.Position_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_8.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_4
            // 
            this.Position_4.BackColor = System.Drawing.SystemColors.Control;
            this.Position_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_4.Location = new System.Drawing.Point(197, 56);
            this.Position_4.Name = "Position_4";
            this.Position_4.ReadOnly = true;
            this.Position_4.Size = new System.Drawing.Size(29, 21);
            this.Position_4.TabIndex = 2;
            this.Position_4.TabStop = false;
            this.Position_4.Text = "3";
            this.Position_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_4.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_2
            // 
            this.Position_2.BackColor = System.Drawing.SystemColors.Control;
            this.Position_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_2.Location = new System.Drawing.Point(225, 56);
            this.Position_2.Name = "Position_2";
            this.Position_2.ReadOnly = true;
            this.Position_2.Size = new System.Drawing.Size(29, 21);
            this.Position_2.TabIndex = 2;
            this.Position_2.TabStop = false;
            this.Position_2.Text = "2";
            this.Position_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_2.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // Position_1
            // 
            this.Position_1.BackColor = System.Drawing.SystemColors.Control;
            this.Position_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_1.Location = new System.Drawing.Point(251, 56);
            this.Position_1.Name = "Position_1";
            this.Position_1.ReadOnly = true;
            this.Position_1.Size = new System.Drawing.Size(29, 21);
            this.Position_1.TabIndex = 2;
            this.Position_1.TabStop = false;
            this.Position_1.Text = "1";
            this.Position_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoRead_MouseCLick);
            this.Position_1.MouseCaptureChanged += new System.EventHandler(this.NoRead_MouseCaptureChange);
            // 
            // BitLabel
            // 
            this.BitLabel.AutoSize = true;
            this.BitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BitLabel.Location = new System.Drawing.Point(32, 86);
            this.BitLabel.Name = "BitLabel";
            this.BitLabel.Size = new System.Drawing.Size(24, 15);
            this.BitLabel.TabIndex = 1;
            this.BitLabel.Text = "Bit:";
            // 
            // Bit_128
            // 
            this.Bit_128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_128.Location = new System.Drawing.Point(60, 83);
            this.Bit_128.Name = "Bit_128";
            this.Bit_128.Size = new System.Drawing.Size(29, 21);
            this.Bit_128.TabIndex = 1;
            this.Bit_128.Text = "0";
            this.Bit_128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_128.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_128_KeyPress);
            // 
            // Bit_64
            // 
            this.Bit_64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_64.Location = new System.Drawing.Point(88, 83);
            this.Bit_64.Name = "Bit_64";
            this.Bit_64.Size = new System.Drawing.Size(29, 21);
            this.Bit_64.TabIndex = 2;
            this.Bit_64.Text = "0";
            this.Bit_64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_64_KeyPress);
            // 
            // Bit_32
            // 
            this.Bit_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_32.Location = new System.Drawing.Point(116, 83);
            this.Bit_32.Name = "Bit_32";
            this.Bit_32.Size = new System.Drawing.Size(29, 21);
            this.Bit_32.TabIndex = 3;
            this.Bit_32.Text = "0";
            this.Bit_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_32_KeyPress);
            // 
            // Bit_16
            // 
            this.Bit_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_16.Location = new System.Drawing.Point(144, 83);
            this.Bit_16.Name = "Bit_16";
            this.Bit_16.Size = new System.Drawing.Size(29, 21);
            this.Bit_16.TabIndex = 4;
            this.Bit_16.Text = "0";
            this.Bit_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_16_KeyPress);
            // 
            // Bit_8
            // 
            this.Bit_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_8.Location = new System.Drawing.Point(168, 83);
            this.Bit_8.Name = "Bit_8";
            this.Bit_8.Size = new System.Drawing.Size(29, 21);
            this.Bit_8.TabIndex = 5;
            this.Bit_8.Text = "0";
            this.Bit_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_8_KeyPress);
            // 
            // Bit_4
            // 
            this.Bit_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_4.Location = new System.Drawing.Point(195, 83);
            this.Bit_4.Name = "Bit_4";
            this.Bit_4.Size = new System.Drawing.Size(29, 21);
            this.Bit_4.TabIndex = 6;
            this.Bit_4.Text = "0";
            this.Bit_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_4_KeyPress);
            // 
            // Bit_2
            // 
            this.Bit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_2.Location = new System.Drawing.Point(223, 83);
            this.Bit_2.Name = "Bit_2";
            this.Bit_2.Size = new System.Drawing.Size(29, 21);
            this.Bit_2.TabIndex = 7;
            this.Bit_2.Text = "0";
            this.Bit_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_2_KeyPress);
            // 
            // Bit_1
            // 
            this.Bit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bit_1.Location = new System.Drawing.Point(251, 83);
            this.Bit_1.Name = "Bit_1";
            this.Bit_1.Size = new System.Drawing.Size(29, 21);
            this.Bit_1.TabIndex = 8;
            this.Bit_1.Text = "0";
            this.Bit_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bit_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bit_1_KeyPress);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.Location = new System.Drawing.Point(14, 166);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(106, 166);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // NewNumberButton
            // 
            this.NewNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewNumberButton.Location = new System.Drawing.Point(199, 166);
            this.NewNumberButton.Name = "NewNumberButton";
            this.NewNumberButton.Size = new System.Drawing.Size(88, 23);
            this.NewNumberButton.TabIndex = 4;
            this.NewNumberButton.Text = "New Number";
            this.NewNumberButton.UseVisualStyleBackColor = true;
            this.NewNumberButton.Click += new System.EventHandler(this.NewNumberButton_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HintLabel.Location = new System.Drawing.Point(121, 114);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(19, 15);
            this.HintLabel.TabIndex = 5;
            this.HintLabel.Text = "    ";
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hint.Location = new System.Drawing.Point(156, 114);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(19, 15);
            this.Hint.TabIndex = 5;
            this.Hint.Text = "    ";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Message.Location = new System.Drawing.Point(97, 138);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(112, 15);
            this.Message.TabIndex = 5;
            this.Message.Text = "                                   ";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AcceptButton = this.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 198);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.NewNumberButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Bit_1);
            this.Controls.Add(this.Bit_2);
            this.Controls.Add(this.Bit_4);
            this.Controls.Add(this.Bit_8);
            this.Controls.Add(this.Bit_16);
            this.Controls.Add(this.Bit_32);
            this.Controls.Add(this.Bit_64);
            this.Controls.Add(this.Bit_128);
            this.Controls.Add(this.BitLabel);
            this.Controls.Add(this.Position_1);
            this.Controls.Add(this.Position_2);
            this.Controls.Add(this.Position_4);
            this.Controls.Add(this.Position_8);
            this.Controls.Add(this.Position_16);
            this.Controls.Add(this.Position_32);
            this.Controls.Add(this.Position_64);
            this.Controls.Add(this.Position_128);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Decimal To Binary";
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
        private System.Windows.Forms.ToolStripMenuItem OptionsHintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutMenuItem;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox Position_128;
        private System.Windows.Forms.TextBox Position_64;
        private System.Windows.Forms.TextBox Position_32;
        private System.Windows.Forms.TextBox Position_16;
        private System.Windows.Forms.TextBox Position_8;
        private System.Windows.Forms.TextBox Position_4;
        private System.Windows.Forms.TextBox Position_2;
        private System.Windows.Forms.TextBox Position_1;
        private System.Windows.Forms.Label BitLabel;
        private System.Windows.Forms.TextBox Bit_128;
        private System.Windows.Forms.TextBox Bit_64;
        private System.Windows.Forms.TextBox Bit_32;
        private System.Windows.Forms.TextBox Bit_16;
        private System.Windows.Forms.TextBox Bit_8;
        private System.Windows.Forms.TextBox Bit_4;
        private System.Windows.Forms.TextBox Bit_2;
        private System.Windows.Forms.TextBox Bit_1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button NewNumberButton;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.Label Message;
    }
}


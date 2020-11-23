namespace SubnetCalculator
{
    partial class Driver
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
            this.IPNetworkGroupBox = new System.Windows.Forms.GroupBox();
            this.BorrowedBitsList = new System.Windows.Forms.ComboBox();
            this.BorrowedBitsLabel = new System.Windows.Forms.Label();
            this.NetMaskText = new System.Windows.Forms.TextBox();
            this.NetMaskLabel = new System.Windows.Forms.Label();
            this.PrefixList = new System.Windows.Forms.ComboBox();
            this.PrefixLabel = new System.Windows.Forms.Label();
            this.EnteredIPText = new System.Windows.Forms.TextBox();
            this.EnteredIPLabel = new System.Windows.Forms.Label();
            this.NetworkLabel = new System.Windows.Forms.Label();
            this.NetworkText = new System.Windows.Forms.TextBox();
            this.BroadcastText = new System.Windows.Forms.TextBox();
            this.BroadcastLabel = new System.Windows.Forms.Label();
            this.FirstHostText = new System.Windows.Forms.TextBox();
            this.FirstHostLabel = new System.Windows.Forms.Label();
            this.LastHostText = new System.Windows.Forms.TextBox();
            this.LastHostLabel = new System.Windows.Forms.Label();
            this.HostsText = new System.Windows.Forms.TextBox();
            this.HostsLabel = new System.Windows.Forms.Label();
            this.SubnetsText = new System.Windows.Forms.TextBox();
            this.SubnetLabel = new System.Windows.Forms.Label();
            this.SubnetViewList = new System.Windows.Forms.ComboBox();
            this.SubnetView = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.IPNetworkGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPNetworkGroupBox
            // 
            this.IPNetworkGroupBox.Controls.Add(this.BorrowedBitsList);
            this.IPNetworkGroupBox.Controls.Add(this.BorrowedBitsLabel);
            this.IPNetworkGroupBox.Controls.Add(this.NetMaskText);
            this.IPNetworkGroupBox.Controls.Add(this.NetMaskLabel);
            this.IPNetworkGroupBox.Controls.Add(this.PrefixList);
            this.IPNetworkGroupBox.Controls.Add(this.PrefixLabel);
            this.IPNetworkGroupBox.Controls.Add(this.EnteredIPText);
            this.IPNetworkGroupBox.Controls.Add(this.EnteredIPLabel);
            this.IPNetworkGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPNetworkGroupBox.Location = new System.Drawing.Point(7, 4);
            this.IPNetworkGroupBox.Name = "IPNetworkGroupBox";
            this.IPNetworkGroupBox.Size = new System.Drawing.Size(419, 158);
            this.IPNetworkGroupBox.TabIndex = 0;
            this.IPNetworkGroupBox.TabStop = false;
            this.IPNetworkGroupBox.Text = "IP / Network";
            // 
            // BorrowedBitsList
            // 
            this.BorrowedBitsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorrowedBitsList.FormattingEnabled = true;
            this.BorrowedBitsList.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.BorrowedBitsList.Location = new System.Drawing.Point(252, 112);
            this.BorrowedBitsList.Name = "BorrowedBitsList";
            this.BorrowedBitsList.Size = new System.Drawing.Size(53, 32);
            this.BorrowedBitsList.TabIndex = 2;
            this.BorrowedBitsList.SelectedIndexChanged += new System.EventHandler(this.BorrowedBitsList_SelectedIndexChanged);
            // 
            // BorrowedBitsLabel
            // 
            this.BorrowedBitsLabel.AutoSize = true;
            this.BorrowedBitsLabel.Location = new System.Drawing.Point(115, 120);
            this.BorrowedBitsLabel.Name = "BorrowedBitsLabel";
            this.BorrowedBitsLabel.Size = new System.Drawing.Size(131, 24);
            this.BorrowedBitsLabel.TabIndex = 0;
            this.BorrowedBitsLabel.Text = "Borrowed Bits:";
            // 
            // NetMaskText
            // 
            this.NetMaskText.Location = new System.Drawing.Point(242, 73);
            this.NetMaskText.Name = "NetMaskText";
            this.NetMaskText.Size = new System.Drawing.Size(162, 29);
            this.NetMaskText.TabIndex = 1;
            this.NetMaskText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NetMaskText_KeyPress);
            this.NetMaskText.Leave += new System.EventHandler(this.NetMaskText_Leave);
            // 
            // NetMaskLabel
            // 
            this.NetMaskLabel.AutoSize = true;
            this.NetMaskLabel.Location = new System.Drawing.Point(143, 76);
            this.NetMaskLabel.Name = "NetMaskLabel";
            this.NetMaskLabel.Size = new System.Drawing.Size(94, 24);
            this.NetMaskLabel.TabIndex = 0;
            this.NetMaskLabel.Text = "Net-Mask:";
            // 
            // PrefixList
            // 
            this.PrefixList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrefixList.FormattingEnabled = true;
            this.PrefixList.Items.AddRange(new object[] {
            "",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.PrefixList.Location = new System.Drawing.Point(84, 70);
            this.PrefixList.Name = "PrefixList";
            this.PrefixList.Size = new System.Drawing.Size(53, 32);
            this.PrefixList.TabIndex = 2;
            this.PrefixList.SelectedIndexChanged += new System.EventHandler(this.PrefixList_SelectedIndexChanged);
            // 
            // PrefixLabel
            // 
            this.PrefixLabel.AutoSize = true;
            this.PrefixLabel.Location = new System.Drawing.Point(16, 73);
            this.PrefixLabel.Name = "PrefixLabel";
            this.PrefixLabel.Size = new System.Drawing.Size(62, 24);
            this.PrefixLabel.TabIndex = 0;
            this.PrefixLabel.Text = "Prefix:";
            // 
            // EnteredIPText
            // 
            this.EnteredIPText.Location = new System.Drawing.Point(73, 32);
            this.EnteredIPText.Name = "EnteredIPText";
            this.EnteredIPText.Size = new System.Drawing.Size(333, 29);
            this.EnteredIPText.TabIndex = 1;
            this.EnteredIPText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteredIPText_KeyPress);
            this.EnteredIPText.Leave += new System.EventHandler(this.EnteredIPText_Leave);
            // 
            // EnteredIPLabel
            // 
            this.EnteredIPLabel.AutoSize = true;
            this.EnteredIPLabel.Location = new System.Drawing.Point(36, 37);
            this.EnteredIPLabel.Name = "EnteredIPLabel";
            this.EnteredIPLabel.Size = new System.Drawing.Size(31, 24);
            this.EnteredIPLabel.TabIndex = 0;
            this.EnteredIPLabel.Text = "IP:";
            // 
            // NetworkLabel
            // 
            this.NetworkLabel.AutoSize = true;
            this.NetworkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NetworkLabel.Location = new System.Drawing.Point(79, 182);
            this.NetworkLabel.Name = "NetworkLabel";
            this.NetworkLabel.Size = new System.Drawing.Size(92, 24);
            this.NetworkLabel.TabIndex = 0;
            this.NetworkLabel.Text = "Network:";
            // 
            // NetworkText
            // 
            this.NetworkText.BackColor = System.Drawing.SystemColors.Control;
            this.NetworkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NetworkText.Location = new System.Drawing.Point(177, 177);
            this.NetworkText.Name = "NetworkText";
            this.NetworkText.Size = new System.Drawing.Size(197, 29);
            this.NetworkText.TabIndex = 1;
            // 
            // BroadcastText
            // 
            this.BroadcastText.BackColor = System.Drawing.SystemColors.Control;
            this.BroadcastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BroadcastText.Location = new System.Drawing.Point(177, 221);
            this.BroadcastText.Name = "BroadcastText";
            this.BroadcastText.Size = new System.Drawing.Size(197, 29);
            this.BroadcastText.TabIndex = 1;
            // 
            // BroadcastLabel
            // 
            this.BroadcastLabel.AutoSize = true;
            this.BroadcastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BroadcastLabel.Location = new System.Drawing.Point(63, 226);
            this.BroadcastLabel.Name = "BroadcastLabel";
            this.BroadcastLabel.Size = new System.Drawing.Size(108, 24);
            this.BroadcastLabel.TabIndex = 0;
            this.BroadcastLabel.Text = "Broadcast:";
            // 
            // FirstHostText
            // 
            this.FirstHostText.BackColor = System.Drawing.SystemColors.Control;
            this.FirstHostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstHostText.Location = new System.Drawing.Point(177, 265);
            this.FirstHostText.Name = "FirstHostText";
            this.FirstHostText.Size = new System.Drawing.Size(197, 29);
            this.FirstHostText.TabIndex = 1;
            // 
            // FirstHostLabel
            // 
            this.FirstHostLabel.AutoSize = true;
            this.FirstHostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstHostLabel.Location = new System.Drawing.Point(67, 270);
            this.FirstHostLabel.Name = "FirstHostLabel";
            this.FirstHostLabel.Size = new System.Drawing.Size(104, 24);
            this.FirstHostLabel.TabIndex = 0;
            this.FirstHostLabel.Text = "First Host:";
            // 
            // LastHostText
            // 
            this.LastHostText.BackColor = System.Drawing.SystemColors.Control;
            this.LastHostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastHostText.Location = new System.Drawing.Point(177, 311);
            this.LastHostText.Name = "LastHostText";
            this.LastHostText.Size = new System.Drawing.Size(197, 29);
            this.LastHostText.TabIndex = 1;
            // 
            // LastHostLabel
            // 
            this.LastHostLabel.AutoSize = true;
            this.LastHostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastHostLabel.Location = new System.Drawing.Point(70, 316);
            this.LastHostLabel.Name = "LastHostLabel";
            this.LastHostLabel.Size = new System.Drawing.Size(101, 24);
            this.LastHostLabel.TabIndex = 0;
            this.LastHostLabel.Text = "Last Host:";
            // 
            // HostsText
            // 
            this.HostsText.BackColor = System.Drawing.SystemColors.Control;
            this.HostsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HostsText.Location = new System.Drawing.Point(122, 359);
            this.HostsText.Name = "HostsText";
            this.HostsText.Size = new System.Drawing.Size(74, 29);
            this.HostsText.TabIndex = 1;
            // 
            // HostsLabel
            // 
            this.HostsLabel.AutoSize = true;
            this.HostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HostsLabel.Location = new System.Drawing.Point(48, 362);
            this.HostsLabel.Name = "HostsLabel";
            this.HostsLabel.Size = new System.Drawing.Size(68, 24);
            this.HostsLabel.TabIndex = 0;
            this.HostsLabel.Text = "Hosts:";
            // 
            // SubnetsText
            // 
            this.SubnetsText.BackColor = System.Drawing.SystemColors.Control;
            this.SubnetsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubnetsText.Location = new System.Drawing.Point(315, 357);
            this.SubnetsText.Name = "SubnetsText";
            this.SubnetsText.Size = new System.Drawing.Size(74, 29);
            this.SubnetsText.TabIndex = 1;
            // 
            // SubnetLabel
            // 
            this.SubnetLabel.AutoSize = true;
            this.SubnetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubnetLabel.Location = new System.Drawing.Point(217, 360);
            this.SubnetLabel.Name = "SubnetLabel";
            this.SubnetLabel.Size = new System.Drawing.Size(92, 24);
            this.SubnetLabel.TabIndex = 0;
            this.SubnetLabel.Text = "Subnets:";
            // 
            // SubnetViewList
            // 
            this.SubnetViewList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubnetViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubnetViewList.FormattingEnabled = true;
            this.SubnetViewList.Location = new System.Drawing.Point(337, 408);
            this.SubnetViewList.Name = "SubnetViewList";
            this.SubnetViewList.Size = new System.Drawing.Size(53, 32);
            this.SubnetViewList.TabIndex = 2;
            this.SubnetViewList.SelectedIndexChanged += new System.EventHandler(this.SubnetViewList_SelectedIndexChanged);
            // 
            // SubnetView
            // 
            this.SubnetView.AutoSize = true;
            this.SubnetView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubnetView.Location = new System.Drawing.Point(186, 416);
            this.SubnetView.Name = "SubnetView";
            this.SubnetView.Size = new System.Drawing.Size(143, 24);
            this.SubnetView.TabIndex = 0;
            this.SubnetView.Text = "View Sub Net:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(40, 411);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(131, 34);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 457);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SubnetView);
            this.Controls.Add(this.SubnetViewList);
            this.Controls.Add(this.SubnetLabel);
            this.Controls.Add(this.SubnetsText);
            this.Controls.Add(this.HostsLabel);
            this.Controls.Add(this.HostsText);
            this.Controls.Add(this.LastHostLabel);
            this.Controls.Add(this.LastHostText);
            this.Controls.Add(this.FirstHostLabel);
            this.Controls.Add(this.FirstHostText);
            this.Controls.Add(this.BroadcastLabel);
            this.Controls.Add(this.BroadcastText);
            this.Controls.Add(this.NetworkText);
            this.Controls.Add(this.NetworkLabel);
            this.Controls.Add(this.IPNetworkGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Driver";
            this.Text = "Network Calculator";
            this.IPNetworkGroupBox.ResumeLayout(false);
            this.IPNetworkGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IPNetworkGroupBox;
        private System.Windows.Forms.ComboBox BorrowedBitsList;
        private System.Windows.Forms.Label BorrowedBitsLabel;
        private System.Windows.Forms.TextBox NetMaskText;
        private System.Windows.Forms.Label NetMaskLabel;
        private System.Windows.Forms.ComboBox PrefixList;
        private System.Windows.Forms.Label PrefixLabel;
        private System.Windows.Forms.TextBox EnteredIPText;
        private System.Windows.Forms.Label EnteredIPLabel;
        private System.Windows.Forms.Label NetworkLabel;
        private System.Windows.Forms.TextBox NetworkText;
        private System.Windows.Forms.TextBox BroadcastText;
        private System.Windows.Forms.Label BroadcastLabel;
        private System.Windows.Forms.TextBox FirstHostText;
        private System.Windows.Forms.Label FirstHostLabel;
        private System.Windows.Forms.TextBox LastHostText;
        private System.Windows.Forms.Label LastHostLabel;
        private System.Windows.Forms.TextBox HostsText;
        private System.Windows.Forms.Label HostsLabel;
        private System.Windows.Forms.TextBox SubnetsText;
        private System.Windows.Forms.Label SubnetLabel;
        private System.Windows.Forms.ComboBox SubnetViewList;
        private System.Windows.Forms.Label SubnetView;
        private System.Windows.Forms.Button CalculateButton;
    }
}


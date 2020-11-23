using System;
using System.Windows.Forms;

namespace SubnetCalculator
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void PrefixList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrefixList.SelectedIndex == 0)
            {
                NetMaskText.Text = "";
            }

            BorrowedBitsList.SelectedIndex = 0;
            BorrowedBitsList.Refresh();
            string mask = "";
            if (!Utilities.CreateNetmask(PrefixList.SelectedIndex + 1, ref mask))
            {
                NetMaskText.Text = "";
                PrefixList.SelectedIndex = 0;
            }
            else
            {
                NetMaskText.Text = mask;
            }
        }

        private void NetMaskText_Leave(object sender, EventArgs e)
        {
            ValidateNetmaskTextBox();
        }

        private void NetMaskText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x0D)
            {
                ValidateNetmaskTextBox();
            }
        }

        private void ValidateNetmaskTextBox()
        {
            if ((NetMaskText.Text == "") ||
                (!Utilities.ValidNetworkMask(NetMaskText.Text)))
            {
                PrefixList.SelectedIndex = 0;
                NetMaskText.Text = "";
            }
            else
            {
                UInt32 prefix = 0;
                if (!Utilities.IPStringToInt(NetMaskText.Text, ref prefix))
                {
                    PrefixList.SelectedIndex = 0;
                    NetMaskText.Text = "";
                }

                var prefixBits = Utilities.CountPrefixBits(prefix);
                PrefixList.SelectedIndex = prefixBits - 1;
                PrefixList.Refresh();
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if ((EnteredIPText.Text == "") ||
                (PrefixList.SelectedIndex == 0))
            {
                MessageBox.Show("Please enter at least an IP and Prefix", "Subnet Calculator",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            DoCalculations();
        }

        private void DoCalculations()
        {
            NetworkText.Text = CalcNetwork();

            UInt32 mask = 0;
            UInt32 hosts = 0;
            if (!Utilities.IPStringToInt(NetMaskText.Text, ref mask))
            {
                return;
            }

            UInt32 noSubnetIncludeIntMask = GetRealMask();
            hosts = Utilities.HostsFromMask(mask) - 1;
            HostsText.Text = hosts.ToString();

            UInt32 network = 0;
            UInt32 broadcast = 0;
            if (!Utilities.IPStringToInt(NetworkText.Text, ref network))
            {
                return;
            }

            network = network & noSubnetIncludeIntMask;
            broadcast = network + hosts;
            BroadcastText.Text = Utilities.CreateIPString(broadcast);
            UInt32 lastHost = broadcast - 1;
            LastHostText.Text = Utilities.CreateIPString(lastHost);
            UInt32 firstHost = network + 1;
            FirstHostText.Text = Utilities.CreateIPString(firstHost);

            int numSubnetBits = BorrowedBitsList.SelectedIndex;
            int totalSubnets = (int)Math.Pow(2, numSubnetBits);
            SubnetsText.Text = totalSubnets.ToString();

            if (totalSubnets > 1)
            {
                SubnetViewList.Items.Clear();
                for (int cnt = 0; cnt < totalSubnets; cnt++)
                {
                    SubnetViewList.Items.Add(cnt + 1);
                }

                SubnetViewList.SelectedIndex = 0;
                SubnetViewList.Enabled = true;
                SubnetViewList.Refresh();
            }
            else
            {
                SubnetViewList.Items.Clear();
                SubnetViewList.Items.Add("");
                SubnetViewList.SelectedIndex = 0;
                SubnetViewList.Enabled = false;
                SubnetViewList.Refresh();
            }
        }

        private string CalcNetwork()
        {
            UInt32 ip = 0, network;

            if (!Utilities.IPStringToInt(EnteredIPText.Text, ref ip))
            {
                return ("");
            }

            UInt32 noSubnetIncludeIntMask = GetRealMask();

            network = ip & noSubnetIncludeIntMask;
            return (Utilities.CreateIPString(network));
        }

        private UInt32 GetRealMask()
        {
            string noSubnetIncludeMask = "";
            int realSubnetBits = (PrefixList.SelectedIndex + 1) -
                                 BorrowedBitsList.SelectedIndex;
            Utilities.CreateNetmask(realSubnetBits, ref noSubnetIncludeMask);
            UInt32 noSubnetIncludeIntMask = 0;
            Utilities.IPStringToInt(noSubnetIncludeMask, ref noSubnetIncludeIntMask);

            return (noSubnetIncludeIntMask);
        }

        private void BorrowedBitsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BorrowedBitsList.SelectedIndex > PrefixList.SelectedIndex)
            {
                BorrowedBitsList.SelectedIndex = 0;
            }
        }

        private void SubnetViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hosts = Convert.ToInt32(HostsText.Text);
            var hostOffset = (hosts + 2) * SubnetViewList.SelectedIndex;
            UInt32 baseNetwork = 0;
            var currBase = CalcNetwork();
            Utilities.IPStringToInt(currBase, ref baseNetwork);
            baseNetwork += (UInt32)hostOffset;
            UInt32 newFirstIP = (baseNetwork + 1);
            UInt32 newLastIP = newFirstIP + (UInt32)(hosts - 1);

            NetworkText.Text = Utilities.CreateIPString(newFirstIP - 1);
            BroadcastText.Text = Utilities.CreateIPString(newLastIP + 1);
            FirstHostText.Text = Utilities.CreateIPString(newFirstIP);
            LastHostText.Text = Utilities.CreateIPString(newLastIP);
        }

        private void EnteredIPText_Leave(object sender, EventArgs e)
        {
            ValidateIPTextBox();
        }

        private void EnteredIPText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x0D)
            {
                ValidateIPTextBox();
            }
        }

        private void ValidateIPTextBox()
        {
            if (!Utilities.IsValidIP(EnteredIPText.Text))
            {
                EnteredIPText.Text = "";
            }
        }
    }
}

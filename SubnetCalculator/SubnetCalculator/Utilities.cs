using System;
using System.Text.RegularExpressions;

namespace SubnetCalculator
{
    public class Utilities
    {
            /// <summary>
            /// method to validate an IP address
            /// using regular expressions. The pattern
            /// being used will validate an ip address
            /// with the range of 1.0.0.0 to 255.255.255.255
            /// </summary>
            /// <param name="addr">
            /// Address to validate
            /// </param>
            /// <returns>
            /// true if valid address range, otherwise false
            /// </returns>

        public static bool IsValidIP(string P_ip)
        {
            //create our match pattern
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            //create our Regular Expression object
            Regex check = new Regex(pattern);
            //boolean variable to hold the status
            bool valid = false;
            //check to make sure an ip address was provided
            if (P_ip == "")
            {
                //no address provided so return false
                valid = false;
            }
            else
            {
                //address provided so use the IsMatch Method
                //of the Regular Expression object
                valid = check.IsMatch(P_ip, 0);
            }
            //return the results
            return valid;
        }

            /// <summary>
            /// This method will convert an IP string into an representative integer
            /// of the IP
            /// </summary>
            /// <param name="P_ip">
            /// IP adress as a dotted quad format
            /// </param>
            /// <param name="P_intVal">
            /// Place holder to return the integer to
            /// </param>
            /// <returns>
            /// true successful conversion, otherwise false
            /// </returns>

        public static bool IPStringToInt(string P_ip, ref UInt32 P_intVal)
        {
            if (!IsValidIP(P_ip))
            {
                return(false);
            }

            string []parts = P_ip.Split('.');
            double num = 0;
            for (int idx = parts.Length - 1; idx >= 0 ; idx --)
            {
                num += ((int.Parse(parts[idx]) % 256) * Math.Pow(256, (3 - idx)));
            }

            P_intVal = (UInt32)num;
            return(true);
        }

            /// <summary>
            /// This method will be given a number of bits and create the
            /// subnet mask for than number of bit and return the string.
            /// </summary>
            /// <param name="P_prefix">
            /// Number of bits to use in the prefix
            /// </param>
            /// <param name="P_mask">
            /// Place holder to return the mask to
            /// </param>
            /// <returns>
            /// ture if the mask was created, otherwise false
            /// </returns>

        public static bool CreateNetmask(int P_prefix, ref string P_mask)
        {
            if ((P_prefix <= 1) || (P_prefix > 32))
            {
                return(false);
            }

            UInt32 intPrefix = 1;
            int cnt;
            for (cnt = 0; cnt < P_prefix; cnt ++)
            {
                intPrefix |= ((intPrefix | 1) << 1);
            }

            for (; cnt < 32; cnt ++)
            {
                intPrefix <<= 1;
            }

            string dottedQuad = String.Format("{0}.{1}.{2}.{3}",
                                    (intPrefix & 0xFF000000) >> 24,
                                    (intPrefix & 0xFF0000) >> 16,
                                    (intPrefix & 0xFF00) >> 8,
                                    (intPrefix & 0xFF));

            P_mask = dottedQuad;
            return(true);
        }

            /// <summary>
            /// This method will count the number of 1 bits in the prefix passed in
            /// </summary>
            /// <param name="P_prefix">
            /// Prefix to count bit in
            /// </param>
            /// <returns>
            /// Number of 1 bits in prefix
            /// </returns>

        public static int CountPrefixBits(UInt32 P_prefix)
        {
            int bitCount = 0;
            UInt32 workPrefix = P_prefix;

            for (int cnt = 0; cnt < 32; cnt ++)
            {
                if ((workPrefix & 0x01) == 1)
                {
                    bitCount ++;
                }

                workPrefix = workPrefix >> 1;
            }

            return(bitCount);
        }

            /// <summary>
            /// This method will check to ensure that a network mask passed
            /// in is a valid network mask
            /// </summary>
            /// <param name="P_netMask">
            /// Mask to check
            /// </param>
            /// <returns>
            /// true valid mask, oterhwise false
            /// </returns>

        public static bool ValidNetworkMask(string P_netMask)
        {
            if (!IsValidIP(P_netMask))
            {
                return(false);
            }

                //
                //  Check each octet for valid bit combination
                //

            string[] parts = P_netMask.Split('.');
            foreach (string octet in parts)
            {
                switch(octet)
                {
                    case "0":
                    case "128":
                    case "192":
                    case "224":
                    case "240":
                    case "248":
                    case "252":
                    case "254":
                    case "255":
                        break;

                    default:
                        return(false);
                }
            }

            return(true);
        }

            /// <summary>
            /// This method will create an IP string from the unsigned int IP
            /// </summary>
            /// <param name="P_intIP">
            /// IP as an int
            /// </param>
            /// <returns>
            /// IP as a string
            /// </returns>

        public static string CreateIPString(UInt32 P_intIP)
        {
            string dottedQuad = String.Format("{0}.{1}.{2}.{3}",
                                    (P_intIP & 0xFF000000) >> 24,
                                    (P_intIP & 0xFF0000) >> 16,
                                    (P_intIP & 0xFF00) >> 8,
                                    (P_intIP & 0xFF));

            return(dottedQuad);
        }

            /// <summary>
            /// This method will get the number of host that a network mask
            /// allows
            /// </summary>
            /// <param name="P_mask">
            /// Network mask to use
            /// </param>
            /// <returns>
            /// Number of hosts
            /// </returns>

        public static UInt32 HostsFromMask(UInt32 P_mask)
        {
            int bitCount = 0;
            UInt32 workPrefix = P_mask, hosts = 0;

            for (int cnt = 0; cnt < 32; cnt++)
            {
                if ((workPrefix & 0x01) == 1)
                {
                    break;
                }

                if ((workPrefix & 0x00) == 0)
                {
                    hosts += (UInt32)Math.Pow(2, (double)bitCount);
                    bitCount ++;
                }

                workPrefix = workPrefix >> 1;
            }

            return (hosts);
        }
    }
}

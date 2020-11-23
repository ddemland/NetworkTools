using System;
using NUnit.Framework;

namespace SubnetCalculator.Tests
{
    public class Tests
    {
        [Test]
        public void TestIPRegEx()
        {
            Assert.IsTrue(Utilities.IsValidIP("192.168.0.1"));
            Assert.IsTrue(Utilities.IsValidIP("255.255.255.255"));
            Assert.IsFalse(Utilities.IsValidIP("0.0.0.0"));
            Assert.IsFalse(Utilities.IsValidIP("192.168.0.256"));
            Assert.IsFalse(Utilities.IsValidIP("192.168.256.1"));
            Assert.IsFalse(Utilities.IsValidIP("192.256.0.1"));
            Assert.IsFalse(Utilities.IsValidIP("256.168.0.1"));
            Assert.IsFalse(Utilities.IsValidIP("256.168.0."));
            Assert.IsFalse(Utilities.IsValidIP("256.168.0"));
            Assert.IsFalse(Utilities.IsValidIP("256.168"));
            Assert.IsFalse(Utilities.IsValidIP("256.168..0"));
        }

        [Test]
        public void TestStrIPToInt()
        {
            UInt32 val = 0;

            Assert.IsTrue(Utilities.IPStringToInt("192.168.0.1", ref val));
            Assert.AreEqual(0xC0A80001, val);

            Assert.IsFalse(Utilities.IPStringToInt("192.168.0.", ref val));
        }

        [Test]
        public void TestCreateMask()
        {
            string mask = "";

            Assert.IsFalse(Utilities.CreateNetmask(1, ref mask));
            Assert.IsFalse(Utilities.CreateNetmask(33, ref mask));
            Assert.IsTrue(Utilities.CreateNetmask(8, ref mask));
            Assert.AreEqual("255.0.0.0", mask);

            Assert.IsTrue(Utilities.CreateNetmask(15, ref mask));
            Assert.AreEqual("255.254.0.0", mask);
        }

        [Test]
        public void TestCountPrefixBits()
        {
            Assert.AreEqual(32, Utilities.CountPrefixBits(0xFFFFFFFF));
            Assert.AreEqual(15, Utilities.CountPrefixBits(0xFFFE0000));
            Assert.AreEqual(8, Utilities.CountPrefixBits(0xFF000000));
        }

        [Test]
        public void TestValidNetworkMask()
        {
            Assert.IsFalse(Utilities.ValidNetworkMask("255.255.123.0"));
            Assert.IsTrue(Utilities.ValidNetworkMask("255.255.0.0"));
        }

        [Test]
        public void TestCreateIPString()
        {
            Assert.AreEqual("192.168.2.125", Utilities.CreateIPString(0xC0A8027D));
        }

        [Test]
        public void TestHostsFromMask()
        {
            Assert.AreEqual(255, Utilities.HostsFromMask(0xFFFFFF00));
        }
    }
}
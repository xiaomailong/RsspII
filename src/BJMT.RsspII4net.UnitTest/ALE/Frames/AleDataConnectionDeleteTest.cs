﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BJMT.RsspII4net.ALE.Frames;

namespace BJMT.RsspII4net.UnitTest.ALE.Frames
{
    [TestFixture]
    class AleDataConnectionDeleteTest
    {
        [Test]
        public void Test1() 
        {
            var data1 = new AleDisconnect();
            data1.UserData = new byte[] { 100, 200};

            var bytes = data1.GetBytes();

            var data2 = new AleDisconnect();
            data2.ParseBytes(bytes, 0, bytes.Length - 1);

            Assert.AreEqual(AleFrameType.Disconnect, data2.FrameType);
            Assert.AreEqual(100, data2.UserData[0]);
            Assert.AreEqual(200, data2.UserData[1]);
        }
    }
}



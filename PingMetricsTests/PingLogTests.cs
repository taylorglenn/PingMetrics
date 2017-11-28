using System;
using System.IO;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace PingMetrics.Tests
{
    [TestFixture]
    public class PingLogTests
    {
        public PingLog testPingLog;
        public string testPingLogFolderPath;
        public string testPingLogFilePath;
        public string testFolderName;
        public static Random random = new Random();

        [SetUp]
        public void SetUp()
        {
            testFolderName = "TESTPINGLOG";
            testPingLogFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), testFolderName);
            testPingLog = new PingLog(testPingLogFolderPath, "TestPingLog.log");
            testPingLogFilePath = Path.Combine(testPingLogFolderPath, testPingLog.Name);
        }
        public string CreateRandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return string.Join("", Enumerable.Range(1, length).Select(x => chars[random.Next(chars.Length)]));
        }
        [Test]
        public void CheckIfPingLogExistsTest()
        {
            Assert.IsTrue(File.Exists(testPingLogFilePath));
        }
        [Test]
        public void WriteLineToLogTest()
        {
            int testListSize = 255;
            List<string> testRandomStringList = Enumerable.Range(0, testListSize).Select(x => CreateRandomString(32)).ToList();
            testPingLog.WriteLineToLog(string.Join("\n", testRandomStringList));
            List<string> allLinesFromTestPingLog = File.ReadAllLines(testPingLogFilePath).ToList();
            CollectionAssert.AreEqual(testRandomStringList, allLinesFromTestPingLog);
        }
        [TearDown]
        public void TearDown()
        {
            GC.Collect();
            Directory.Delete(testPingLogFolderPath, true);
        }
    }
}

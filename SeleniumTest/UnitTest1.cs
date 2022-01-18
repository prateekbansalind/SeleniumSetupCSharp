using NUnit.Framework;

namespace SeleniumTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("SetUp Execution");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Test 1 Execution");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Test 2 Execution");
        }


        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("TearDown Execution");
        }
    }
}
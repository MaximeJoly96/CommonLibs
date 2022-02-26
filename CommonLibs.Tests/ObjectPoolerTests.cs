using NUnit.Framework;

namespace CommonLibs.Tests
{
    [TestFixture]
    public class ObjectPoolerTests
    {
        [Test]
        public void GetElementTest()
        {
            ObjectPooler<int> pooler = new ObjectPooler<int>();

            int item = pooler.GetElement();

            Assert.AreEqual(0, item);
        }
    }
}

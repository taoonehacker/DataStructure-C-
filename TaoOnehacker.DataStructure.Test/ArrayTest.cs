using NUnit.Framework;
using TaoOnehacker.DataStructure.Application;

namespace TaoOnehacker.DataStructure.Test
{
    public class ArrayTest
    {
        private Array _array;
        [SetUp]
        public void Setup()
        {
            _array = new Array(20);
        }

        [Test]
        public void GetCapacityTest()
        {
            Assert.AreEqual(20, _array.GetCapacity());
        }

        [Test]
        public void GetSizeTest()
        {
            Assert.AreEqual(0,_array.GetSize());
        }
        [Test]
        public void AddTest()
        {
            _array.Add(0, 1);
            Assert.AreEqual(1,_array.GetSize());
        }

        [Test]
        public void AddFirstTest()
        {
            _array.AddFirst(1);
            Assert.AreEqual(1,_array.GetSize());
        }
        
        [Test]
        public void AddLastTest()
        {
            _array.AddLast(1);
            Assert.AreEqual(1,_array.GetSize());
        }
        
        
        
    }
}
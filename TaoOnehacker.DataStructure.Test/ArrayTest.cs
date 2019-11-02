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

        [Test]
        public void GetTest()
        {
            for (var i = 0; i < 10; i++){
                _array.AddLast(i);
            }
            
            Assert.AreEqual(5,_array.Get(5));
        }

        [Test]
        public void SetTest()
        {
            for (var i = 0; i < 10; i++){
                _array.AddLast(i);
            }

            _array.Set(1, 20);
            
            Assert.AreEqual(20,_array.Get(1));
        }

        [Test]
        public void Contains()
        {
            for (var i = 0; i < 10; i++){
                _array.AddLast(i);
            }
            
            Assert.IsTrue(_array.Contains(9));
        }

        [Test]
        public void Find()
        {
            for (var i = 0; i < 10; i++){
                _array.AddLast(i);
            }
            Assert.AreEqual(5, _array.Find(5));
            Assert.AreEqual(-1, _array.Find(20));
        }

        [Test]
        public void Remove()
        {
            for (var i = 0; i < 10; i++){
                _array.AddLast(i);
            }

            _array.Remove(5);
            
            Assert.AreEqual(6, _array.Get(5));

        }
        
        
        
    }
}
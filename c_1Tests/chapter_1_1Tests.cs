//using Microsoft.VisualStudio.TestTools.UnitTesting;
using c_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace c_1.Tests
{
    [TestFixture]
    public class chapter_1_1Tests
    {
        private chapter_1_1 _chapter1;
        [SetUp]
        public void SetUp()
        {
            _chapter1 = new chapter_1_1();
        }

        [Test]
        public void Test_NormalArray_Bubble()
        {
            // Given
            var expectedArray = new[] { 1, 2, 3, 4, 5, 6, };
            var unSortedArray = new[] { 4, 5, 6, 1, 2, 3, };

            // When
            var sortedArray = _chapter1.Bubble(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }

        [Test]
        public void Test_Normal2Array_Bubble()
        {
            // Given
            var expectedArray = new[] { 1, 2, 3, 4, 5, 6, };
            var unSortedArray = new[] { 6, 5, 4, 3, 2, 1, };

            // When
            var sortedArray = _chapter1.Bubble(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }

        [Test]
        public void Test_SingleElementArray_Bubble()
        {
            // Given
            var expectedArray = new[] { 6, };
            var unSortedArray = new[] { 6, };

            // When
            var sortedArray = _chapter1.Bubble(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }

        [Test]
        public void Test_NoneArray_Bubble()
        {
            // Given
            int[] expectedArray = { };
            int[] unSortedArray = { };

            // When
            var sortedArray = _chapter1.Bubble(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }


        [Test]
        public void Test_NormalArray_InsertSort()
        {
            // Given
            var expectedArray = new List<int> { 1, 2, 3, 4, 5, 6, };
            var unSortedArray = new List<int> { 4, 5, 6, 1, 2, 3, };

            // When
            var sortedArray = _chapter1.InsertSort(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }

        [Test]
        public void Test_Normal2Array_InsertSort()
        {
            // Given
            var expectedArray = new List<int> { 1, 2, 3, 4, 5, 6, };
            var unSortedArray = new List<int> { 6, 5, 4, 3, 2, 1, };

            // When
            var sortedArray = _chapter1.InsertSort(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }

        [Test]
        public void Test_SingleElementArray_InsertSort()
        {
            // Given
            var expectedArray = new List<int> { 6, };
            var unSortedArray = new List<int> { 6, };

            // When
            var sortedArray = _chapter1.InsertSort(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }

        [Test]
        public void Test_NoneArray_InsertSort()
        {
            // Given
            var expectedArray = new List<int> { };
            var unSortedArray = new List<int> { };

            // When
            var sortedArray = _chapter1.InsertSort(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }



        [Test]
        public void Test_NormalArray_InsertSortA()
        {
            // Given
            int[] expectedArray = { 1, 2, 3, 4, 5, 6, };
            int[] unSortedArray = { 4, 5, 6, 1, 2, 3, };

            // When
            var sortedArray = _chapter1.InsertSort(unSortedArray);

            // Then
            Assert.AreEqual(expectedArray, sortedArray);
        }
    }
}
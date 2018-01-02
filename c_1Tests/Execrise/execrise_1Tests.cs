using c_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace c_1.Execrise.Tests
{
    [TestFixture]
    public class execrise_1Tests
    {
        [Test]
        public void Even_Length_SelectionTest()
        {
            // given
            int[] data = {2, 5, 10, 3, 4, 6, 1, 7, 8, 9};
            int value = 5;

            // when
            int result = execrise_1.Selection(data);

            // then
            Assert.AreEqual(value, result);
        }


        [Test]
        public void Odd_Length_SelectionTest()
        {
            // given
            int[] data = {2, 5, 10, 3, 4, 6, 1, 7, 8, 9, 11};
            int value = 5;

            // when
            int result = execrise_1.Selection(data);

            // then
            Assert.AreEqual(value, result);
        }
    }
}
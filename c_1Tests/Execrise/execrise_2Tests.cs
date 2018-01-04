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
    public class execrise_2Tests
    {
        private execrise_2 execrise2;
        [SetUp]
        public void SetUp()
        {
            execrise2 = new execrise_2();
            execrise2.InitDiction(new[] {"this", "two", "fat", "that"});

            string[,] dict =
            {
                {"t", "h", "i", "s"},
                {"w", "a", "t", "s"},
                {"o", "a", "h", "g"},
                {"f", "g", "d", "t"},
            };
            execrise2.InitCheckBoard(dict);
        }

        [Test]
        public void FindLetterCombinationTest()
        {
            // given TODO: given result
            var letter = new Dictionary<string, string>
            {
                {"[0,0][0,1][0,2][0,3]", "this"},
                {"[0,0][1,0][2,0]", "two"},
                {"[3,0][2,1][1,2]", "fat"},
                {"[3,3][2,2][1,1][0,0]", "that"}
            };

            // when
            var result = execrise2.FindLetter();

            // then
            Assert.AreEqual(result, letter);
        }
    }
}
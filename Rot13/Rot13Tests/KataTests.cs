using Rot13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Rot13.Tests
{
    [TestFixture]
    public class SystemTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ROT13 example.", Kata.Rot13("EBG13 rknzcyr."));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("This is my first ROT13 excercise!", Kata.Rot13("Guvf vf zl svefg EBG13 rkprepvfr!"));
        }
    }
}
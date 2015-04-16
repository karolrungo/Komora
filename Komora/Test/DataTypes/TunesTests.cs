using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Komora.Test.DataTypes
{
    [TestFixture]
    public class TunesTests
    {
        [Test]
        public void equalityOperatorWorksFine()
        {
            Komora.DataTypes.Tunes tunes1 = new Komora.DataTypes.Tunes();
            Komora.DataTypes.Tunes tunes2 = new Komora.DataTypes.Tunes();

            Assert.True(tunes1.Equals(tunes1));

            Assert.True(tunes1 == tunes2);
            Assert.False(tunes1 != tunes2);
            Assert.True(tunes1.Equals(tunes2));

            tunes1.ki = 999;

            Assert.False(tunes1 == tunes2);
            Assert.True(tunes1 != tunes2);
            Assert.False(tunes1.Equals(tunes2));

            tunes2 = null;

            Assert.False(tunes1 == tunes2);
            Assert.True(tunes1 != tunes2);
            Assert.False(tunes1.Equals(tunes2));
        }
    }
}

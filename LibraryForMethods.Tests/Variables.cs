using NUnit.Framework;
using LibraryForMethods;

namespace LibraryForMethods.Tests
{
    public class Variables
    {
        [Test]
      public void SolveTheEquation()
        {
            double expected = 9;
            double actual = LibraryForMethods.Variable.SolveTheEquation(1,2);
            Assert.AreEqual(expected, actual);
        }



    }
}
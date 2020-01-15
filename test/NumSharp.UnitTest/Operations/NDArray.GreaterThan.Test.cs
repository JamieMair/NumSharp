using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumSharp.UnitTest.Operations
{
    [TestClass]
    public class NDArrayGreaterThanTest
    {
        [TestMethod]
        public void IntTwo1D_NDArrayGreaterThan()
        {
            var np1 = np.array(new[] { 1, 2, 3, 4 }).reshape(new Shape(4));
            var np2 = np.array(new[] { 2, 1, 3, 5 }).reshape(new Shape(4));
            

            var np3 = np1 > np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { false, true, false, false }, np3.Data<bool>()));
        }
        [TestMethod]
        public void IntTwo2D_NDArrayGreaterThan()
        {
            var np1 = np.array(new[] { 1, 2, 3, 4 }).reshape(new Shape((2,2)));
            var np2 = np.array(new[] { 2, 1, 3, 5 }).reshape(new Shape((2,2)));

            var np3 = np1 > np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { false, true, false, false }, np3.reshape(new Shape(4)).Data<bool>()));
        }
        [TestMethod]
        public void FloatTwo1D_NDArrayGreaterThan()
        {
            var np1 = np.array(new[] { 1.0f, 2.0f, 3.0f, 4.0f }).reshape(new Shape(4));
            var np2 = np.array(new[] { 2.0f, 1.0f, 3.0f, 5.0f }).reshape(new Shape(4));

            var np3 = np1 > np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { false, true, false, false }, np3.Data<bool>()));
        }
        [TestMethod]
        public void FloatTwo2D_NDArrayGreaterThan()
        {
            var np1 = np.array(new[] { 1.0f, 2.0f, 3.0f, 4.0f }).reshape(new Shape((2, 2)));
            var np2 = np.array(new[] { 2.0f, 1.0f, 3.0f, 5.0f }).reshape(new Shape((2, 2)));

            var np3 = np1 > np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { false, true, false, false }, np3.reshape(new Shape(4)).Data<bool>()));
        }
        [TestMethod]
        public void IntOne2D_NDArrayGreaterThan()
        {
            var np1 = np.array(new[] { 1, 2, 3, 4 }).reshape(new Shape(4));

            var np3 = np1 > 2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { false, false, true, true }, np3.Data<bool>()));
        }
        [TestMethod]
        public void FloatOne2D_NDArrayGreaterThan()
        {
            var np1 = np.array(new[] { 1.0f, 2.0f, 3.0f, 4.0f }).reshape(new Shape(4));

            var np3 = np1 > 2.3f;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { false, false, true, true }, np3.Data<bool>()));
        }
    }
}

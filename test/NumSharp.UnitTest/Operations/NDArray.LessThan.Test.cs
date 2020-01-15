using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumSharp.UnitTest.Operations
{
    [TestClass]
    public class NDArrayLessThanTest
    {
        [TestMethod]
        public void IntTwo1D_NDArrayLessThan()
        {
            var np1 = np.array(new[] { 1, 2, 3, 4 }).reshape(new Shape(4));
            var np2 = np.array(new[] { 2, 1, 3, 5 }).reshape(new Shape(4));
            

            var np3 = np1 < np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { true, false, false, true }, np3.Data<bool>()));
        }
        [TestMethod]
        public void IntTwo2D_NDArrayLessThan()
        {
            var np1 = np.array(new[] { 1, 2, 3, 4 }).reshape(new Shape((2,2)));
            var np2 = np.array(new[] { 2, 1, 3, 5 }).reshape(new Shape((2,2)));

            var np3 = np1 < np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { true, false, false, true }, np3.reshape(new Shape(4)).Data<bool>()));
        }
        [TestMethod]
        public void FloatTwo1D_NDArrayLessThan()
        {
            var np1 = np.array(new[] { 1.0f, 2.0f, 3.0f, 4.0f }).reshape(new Shape(4));
            var np2 = np.array(new[] { 2.0f, 1.0f, 3.0f, 5.0f }).reshape(new Shape(4));

            var np3 = np1 < np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { true, false, false, true }, np3.Data<bool>()));
        }
        [TestMethod]
        public void FloatTwo2D_NDArrayLessThan()
        {
            var np1 = np.array(new[] { 1.0f, 2.0f, 3.0f, 4.0f }).reshape(new Shape((2, 2)));
            var np2 = np.array(new[] { 2.0f, 1.0f, 3.0f, 5.0f }).reshape(new Shape((2, 2)));

            var np3 = np1 < np2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { true, false, false, true }, np3.reshape(new Shape(4)).Data<bool>()));
        }
        [TestMethod]
        public void IntOne2D_NDArrayLessThan()
        {
            var np1 = np.array(new[] { 1, 2, 3, 4 }).reshape(new Shape(4));

            var np3 = np1 < 2;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { true, false, false, false }, np3.Data<bool>()));
        }
        [TestMethod]
        public void FloatOne2D_NDArrayLessThan()
        {
            var np1 = np.array(new[] { 1.0f, 2.0f, 3.0f, 4.0f }).reshape(new Shape(4));

            var np3 = np1 < 2.3f;

            Assert.IsTrue(Enumerable.SequenceEqual(new[] { true, true, false, false }, np3.Data<bool>()));
        }
    }
}

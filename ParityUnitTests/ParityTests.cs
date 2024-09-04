using System.Runtime.CompilerServices;
using Parity;

namespace ParityUnitTests {
  [TestFixture]
  public class ParityTests {
    private ParityCalculator _parityCalculator;

    [SetUp]
    public void Setup() {
      _parityCalculator = new ParityCalculator();
    }

    [Test]
    public void IsEven_TrueTest() {
      int number = 0;

      bool isEven = _parityCalculator.IsEven(number);

      Assert.IsTrue(isEven);
    }

    [Test]
    public void IsEven_FalseTest() {
      int number = -5;

      bool isEven = _parityCalculator.IsEven(number);

      Assert.IsFalse(isEven);
    }
  }
}
using DelightfulBabbler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DelightfulBabblerTests; 
 [TestClass]
 public class BabbleTests {
    [TestMethod()]
    public void RandomTest()
    {
       var x = Babble.Random();
       Assert.IsNotNull(x);
       var y = Babble.Random();
       Assert.IsNotNull(y);
       Assert.AreNotEqual(x,y);
    }
 }
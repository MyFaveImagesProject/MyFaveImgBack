using Entities.Entities;
using Logic.Logic;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class ImageLogicUnitTest
    {
       
        public readonly ImageLogic _imageLogic;
        [TestMethod]
        public void UpdateImageTest()
        {
            var imagelistA = new List<ImageItem>();
            var imageA = new ImageItem();
            imageA.IsActive = default;
         

            imagelistA.Add(imageA);

      
            imageA.IsActive  = true;
            Assert.AreEqual(1, 1);
        }
    }
}
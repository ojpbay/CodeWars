using NUnit.Framework;

namespace CodeWars
{
    public class SpacesRemoverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RemoveSpaces1()
        {
            Assert.AreEqual("8j8mBliB8gimjB8B8jlB", SpacesRemover.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));            
        }

        [Test]
        public void RemoveSpaces2()
        {
            Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", SpacesRemover.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));            
        }

        [Test]
        public void RemoveSpaces3()
        {
            Assert.AreEqual("8aaaaaddddr", SpacesRemover.NoSpace("8aaaaa dddd r     "));
        }
    }
}
using NUnit.Framework;

namespace CodeWars
{
    public class SpacesRemoverTests
    {
        [Test]
        public void SourceStringWithSpaces_SpacesRemoved()
        {
            // arrange
            var source = "8 8 Bi fk8h B 8 BB8B B B B888 c hl8 BhB fd";

            // act
            var result = SpacesRemover.NoSpace(source);

            // assert
            Assert.That(result.Equals("88Bifk8hB8BB8BBBB888chl8BhBfd"));
        }

        [Test]
        public void SourceStringWithAdjacentSpaces_SpacesRemoved()
        {
            // arrange
            var source = "8  j  8   mBliB8g  imjB8B8  jl  B";

            // act
            var result = SpacesRemover.NoSpace(source);

            // assert
            Assert.That(result.Equals("8j8mBliB8gimjB8B8jlB"));
        }

        [Test]
        public void SourceStringWithMultipleAdjacentSpacesAndSingleSpaces_SpacesRemoved()
        {
            // arrange
            var source = "8aaaaa dddd r     ";

            // act
            var result = SpacesRemover.NoSpace(source);

            // assert
            Assert.That(result.Equals("8aaaaaddddr"));
        }
    }
}
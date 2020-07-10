using copilot.Impl;
using FluentAssertions;
using NUnit.Framework;

namespace copilot.test
{
    [TestFixture]
    public class CopilotTests
    {
        [Test]
        public void ShouldCreate()
        {
            var sut = new Copilot();
            sut.Should().NotBeNull();
        }
    }
}
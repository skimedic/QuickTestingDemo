using System;
using TestingDemo.Models;
using Xunit;

namespace XUnitTestProject1
{
    public class ModelTests : IDisposable
    {
        public ModelTests()
        {

        }

        public void Dispose()
        {
            
        }

        [Fact]
        public void ShouldShowRequestIdIfNotEmpty()
        {
            var sut = new ErrorViewModel {RequestId = "123"};
            Assert.True(sut.ShowRequestId);
        }
        [Fact]
        public void ShouldNotShowRequestIdIfEmpty()
        {
            var sut = new ErrorViewModel();
            Assert.False(sut.ShowRequestId);
        }

        [Theory]
        [InlineData("123", true)]
        [InlineData("", false)]
        public void ShouldShowRequestIdBasedOnValue(string requestId, bool expectedResult)
        {
            var sut = new ErrorViewModel { RequestId = requestId};
            Assert.Equal(expectedResult,sut.ShowRequestId);
        }
    }
}
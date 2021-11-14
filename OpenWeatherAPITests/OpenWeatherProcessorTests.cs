
using Moq;
//using Xunit;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenWeatherAPITests
{

    [TestFixture]
    public class OpenWeatherProcessorTests
    {
        private Mock<OpenWeatherProcessor> _mockOpenWeatherProcessor;

        [SetUp]
        public void SetUp()
        {
            _mockOpenWeatherProcessor = new Mock<OpenWeatherProcessor>();
        }

        [Test]
        public void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => _mockOpenWeatherProcessor.Setup(s => s.GetOneCallAsync()));
        }

        [Test]
        public void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _mockOpenWeatherProcessor.Setup(s => s.GetCurrentWeatherAsync()));
        }

    }
}

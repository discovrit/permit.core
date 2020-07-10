using System;
using Kamak.Core.Domain;
using Kamak.Core.Factory;
using Xunit;

namespace Kamak.Core.Processor
{
    public class LessonBookingRequestProcessorTests
    {
        private readonly LessonBookingRequestProcessor _processor;
        private readonly LessonBookingFactory _factory;

        public LessonBookingRequestProcessorTests()
        {
            _processor = new LessonBookingRequestProcessor();
            _factory = new LessonBookingFactory();
        }

        [Fact]
        public void ReturnsLessonBookingResultWIthRequestValues()
        {
            //Arrange
            var request = _factory.GetBaseLessonBookingRequest();

            //Act
            LessonBookingResult result = _processor.BookLesson(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(request.StudentId, result.StudentId);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
            Assert.Equal(request.Hours, result.Hours);
        }

        [Fact]
        public void ThrowsExceptionIFRequestIsNull()
        {
            //Arrange

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.BookLesson(null));

            //Assert
            Assert.Equal("request", exception.ParamName);
        }
    }
}

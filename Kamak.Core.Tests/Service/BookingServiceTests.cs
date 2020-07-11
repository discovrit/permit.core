using System;
using Kamak.Core.Domain;
using Kamak.Core.Factory;
using Xunit;

namespace Kamak.Core.Service
{
    public class BookingServiceTests
    {
        private readonly BookingService _service;
        private readonly BookingFactory _factory;

        public BookingServiceTests()
        {
            _service = new BookingService();
            _factory = new BookingFactory();
        }

        [Fact]
        public void ReturnsLessonBookingResultWIthRequestValues()
        {
            //Arrange
            var request = _factory.GetBaseBooking();

            //Act
            BookingResponse response = _service.BookLesson(request);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(request.StudentId, response.StudentId);
            Assert.Equal(request.FirstName, response.FirstName);
            Assert.Equal(request.LastName, response.LastName);
            Assert.Equal(request.Email, response.Email);
            Assert.Equal(request.Date, response.Date);
            Assert.Equal(request.Hours, response.Hours);
            Assert.Equal(request.Minutes, response.Minutes);
        }

        [Fact]
        public void ThrowsExceptionIFRequestIsNull()
        {
            //Arrange

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _service.BookLesson(null));

            //Assert
            Assert.Equal("request", exception.ParamName);
        }


    }
}

using System;
using Kamak.Core.Processor.Domain;

namespace Kamak.Core.Processor.Factory
{
    public class LessonBookingFactory
    {
        public LessonBookingRequest GetBaseLessonBookingRequest()
        {
            return BaseLessonBookingRequest();
        }




        private LessonBookingRequest BaseLessonBookingRequest()
        {
            return new LessonBookingRequest
            {
                StudentId = 1,
                FirstName = "Melody",
                LastName = "Sunshine",
                Email = "melody.sunshin@permit.com",
                Date = new DateTime(2020, 1, 1),
                Hours = 12,
                Minutes = 00
            };
        }
    }
}
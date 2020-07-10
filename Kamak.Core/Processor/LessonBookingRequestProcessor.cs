using System;

namespace Kamak.Core.Processor
{
    internal class LessonBookingRequestProcessor
    {
        public LessonBookingRequestProcessor()
        {
        }

        internal LessonBookingResult BookLesson(LessonBookingRequest request)
        {
            return new LessonBookingResult
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}
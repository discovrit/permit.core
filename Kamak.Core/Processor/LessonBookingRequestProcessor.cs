using System;
using Kamak.Core.Processor.Domain;

namespace Kamak.Core.Processor
{
     public class LessonBookingRequestProcessor
    {
        public LessonBookingRequestProcessor()
        {
        }

        public LessonBookingResult BookLesson(LessonBookingRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            return new LessonBookingResult
            {
                StudentId = request.StudentId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}
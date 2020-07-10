using System;

namespace Kamak.Core.Processor.Domain
{
    public class LessonBookingResult
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
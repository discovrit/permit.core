using System;
namespace Kamak.Core.Domain
{
    public class LessonBooking
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
    }
}

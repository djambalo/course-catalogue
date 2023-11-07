using System.ComponentModel.DataAnnotations;

namespace CourseCatalog.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }
        public int RoomNumber { get; set; }

        [DataType(DataType.Time)]
        public TimeOnly StartTime { get; set; }
        
        [DataType(DataType.Time)]
        public TimeOnly EndTime { get; set; }
    }
}

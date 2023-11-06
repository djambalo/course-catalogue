using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;
// seeding script 
public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context =
               new CourseCatalogContext(serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("null context");
            }

            if (context.Course.Any())
            {
                return; // leave script
            }
            context.Course.AddRange(
                    new Course()
                    {
                       
                        CourseName= "CIS", 
                        CourseDescription = "C#", 
                        RoomNumber = 116, 
                        StartTime = TimeOnly.Parse("11:00") ,
                        EndTime = TimeOnly.Parse("11:50")
                    },
                new Course()
                    {
                        
                        CourseName= "CIS", 
                        CourseDescription = "Java", 
                        RoomNumber = 120, 
                        StartTime = TimeOnly.Parse("10:00"),
                        EndTime = TimeOnly.Parse("10:50"),
                    },
                new Course()
                    {
                       
                        CourseName= "CIS", 
                        CourseDescription = "JavaScript", 
                        RoomNumber = 200, 
                        StartTime = TimeOnly.Parse("8:00") ,
                        EndTime = TimeOnly.Parse("8:50"),
                    },
                new Course()
                    {
                        
                        CourseName= "CIS", 
                        CourseDescription = "Web Scripting", 
                        RoomNumber = 200, 
                        StartTime= TimeOnly.Parse("9:00") ,
                        EndTime = TimeOnly.Parse("9:50"),
                    },
                new Course(){
                        CourseName= "CIS", 
                        CourseDescription = "Cobol", 
                        RoomNumber = 116, 
                        StartTime= TimeOnly.Parse("1:00"),
                        EndTime = TimeOnly.Parse("1:50"),
                    }
                );
            context.SaveChanges();
        }
    }
    
}
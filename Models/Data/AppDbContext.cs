using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AdvancedSchoolManagment.Models.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUserDTO>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            // builder.Seed();
        }

        public DbSet<StudentDTO> Student { get; set; }
        public DbSet<ParentDTO> Parent { get; set; }
        public DbSet<StudentParentDTO> StudentParent { get; set; }
        public DbSet<WorkerDTO> Worker { get; set; }
        public DbSet<TeacherDTO> Teacher { get; set; }
        public DbSet<ClassroomDTO> Classroom { get; set; }
        public DbSet<SubjectDTO> Subject { get; set; }
        public DbSet<SubjectTeacherDTO> SubjectTeacher { get; set; }
        public DbSet<MarkSchemaDTO> MarkSchema { get; set; }
        public DbSet<MarksDTO> Mark { get; set; }
        public DbSet<LessonDTO> Lesson { get; set; }
        public DbSet<LessonHoursDTO> LessonHour { get; set; }
        public DbSet<AbsenceDTO> Absence { get; set; }
        public DbSet<RebukeDTO> Rebuke { get; set; }


    }
}

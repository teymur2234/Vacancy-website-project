using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Globalization;

namespace Boss_az_Task.Entities
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public string PictureURL { get; set; }
        public Education Education { get; set; }
        public int EducationId { get; set; }
        public string EducationDescription { get; set; }
        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }
        public string ExperienceDescription { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Position { get; set; }
        public City City { get; set; }
        public int CityId { get; set; } 
        public double ExpectedSalary { get; set; }
        public string Skills { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}

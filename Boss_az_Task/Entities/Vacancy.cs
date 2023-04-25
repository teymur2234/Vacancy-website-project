using Microsoft.Identity.Client;

namespace Boss_az_Task.Entities
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Heading { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Position { get; set; }
        public City City { get; set; }
        public int CityId { get; set; } 
        public string Salary { get; set; }
        public string Age { get; set; }
        public Education Education { get; set; }
        public int EducationId { get;set; }
        public Experience Experience { get; set; }
        public int ExperienceId { get; set;}
        public string Requirements { get; set; }
        public string WorkInfo { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public string RelevantPerson { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiredTime { get; set; }
        public bool IsActive { get; set; }
    }
}

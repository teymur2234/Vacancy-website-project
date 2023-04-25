namespace Boss_az_Task.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public List<Vacancy> Vacancies { get; set; }
        public bool IsDeleted { get; set; }
    }
}

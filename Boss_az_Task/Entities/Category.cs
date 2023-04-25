namespace Boss_az_Task.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category? Parent { get; set; }
        public int? ParentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

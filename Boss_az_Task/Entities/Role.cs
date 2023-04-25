namespace Boss_az_Task.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Permission> Permissions { get; set; }
        public bool IsDeleted { get; set; }
    }
}

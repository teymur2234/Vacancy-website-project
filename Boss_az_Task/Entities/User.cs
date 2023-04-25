namespace Boss_az_Task.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public List<Comment> Comments { get; set; }
        public bool IsDeleted { get; set; }
    }
}

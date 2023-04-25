namespace Boss_az_Task.Entities
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public List<Role> Roles { get; set; }
        public  bool IsDeleted { get; set; }
    }
}

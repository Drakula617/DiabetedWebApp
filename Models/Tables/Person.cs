namespace DiabetesWebApp.Models.Tables
{
    public class Person
    {
        public int ID { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Mname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateRegistration { get; set; }
        public virtual ICollection<Profile>? Profiles { get; set; }
        public virtual ICollection<DiaryLine>? DiaryLines { get; set; }
    }
}

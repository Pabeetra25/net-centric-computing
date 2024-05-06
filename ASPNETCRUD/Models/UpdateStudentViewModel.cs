

namespace ASPNETCRUD.Models
{
    public class UpdateStudentViewModel
    {
         public Guid Id { get; set; }
        public string ?Name { get; set; }
      

        public string ?Email { get; set; }
        public string ?Address { get; set; }
    }
}

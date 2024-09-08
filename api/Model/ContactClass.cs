using System.ComponentModel.DataAnnotations;

namespace api.Model
{
    public class ContactClass
    {
        [Key]
        public int Id { get; set; }
        public String Name {  get; set; }

        public String Email { get; set; }

        public String Message { get; set; }
    }
}

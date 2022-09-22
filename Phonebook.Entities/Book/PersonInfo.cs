using System.ComponentModel.DataAnnotations.Schema;

namespace Phonebook.Entities.Book
{
    public class PersonInfo
    {
        public int Id { get; set; }
        public int InfoType { get; set; }
        public string Info { get; set; }
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}

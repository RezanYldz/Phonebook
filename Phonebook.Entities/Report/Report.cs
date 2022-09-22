using Phonebook.Entities.Book;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phonebook.Entities.Report
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}

using Entities.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product : Notifier
    {
        [Column("Id")]
        [Display(Name = "Identificador")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("Value")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("Status")]
        [Display(Name = "Estado")]
        public bool Status { get; set; }
    }
}

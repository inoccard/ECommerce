using Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Base : Notifier
    {
        [Display(Name = "Identificador")]
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}

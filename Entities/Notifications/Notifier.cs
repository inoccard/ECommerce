using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifier
    {
        public Notifier()
        {
            Notifiers = new List<Notifier>();
        }
        
        [NotMapped]
        public string PropertyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifier> Notifiers { get; set; }

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifiers.Add(new Notifier
                {
                    Message = "Campo obriatório",
                    PropertyName = propertyName
                });

                return false;
            }
            return true;
        }

        public bool ValidateIntegerProperty(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifiers.Add(new Notifier
                {
                    Message = "O valor deve ser maior que 0",
                    PropertyName = propertyName
                });

                return false;
            }
            return true;
        }
        
        public bool ValidateDecimalProperty(decimal value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifiers.Add(new Notifier
                {
                    Message = "O valor deve ser maior que 0",
                    PropertyName = propertyName
                });

                return false;
            }
            return true;
        }
    }
}

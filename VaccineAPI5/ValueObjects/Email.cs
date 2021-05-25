using System;
using prmToolkit.NotificationPattern;

namespace VaccineAPI5.ValueObjects
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }

        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, "E-mail inválido!");
        }

        public string Endereco { get; private set; }

    }
}

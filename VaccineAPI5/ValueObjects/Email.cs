using System;
using prmToolkit.NotificationPattern;

namespace VaccineAPI5.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, "E-mail inválido!");
        }

        public string Endereco { get; private set; }

    }
}

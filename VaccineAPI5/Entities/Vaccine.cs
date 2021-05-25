using System;
using prmToolkit.NotificationPattern;

namespace VaccineAPI5.Entities
{
    public class Vaccine : Notifiable
    {
        public Vaccine(string name, string manufacturer, string batch,
            string dueDate, int numberOfDoses, int intervalBetweenDoses)
        {
            Name = name;
            Manufacturer = manufacturer;
            Batch = batch;
            DueDate = dueDate;
            NumberOfDoses = numberOfDoses;
            IntervalBetweenDoses = intervalBetweenDoses;

            new AddNotifications<Vaccine>(this)
                .IfNotDate(x => x.DueDate, "Informe uma data válida!")
                .IfNullOrWhiteSpace(x => x.Name, "Informe o Nome!")
                .IfNullOrWhiteSpace(x => x.Manufacturer, "Informe o Fabricante!")
                .IfNullOrWhiteSpace(x => x.Batch, "Informe o Lote!");
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Manufacturer { get; private set; }

        public string Batch { get; private set; }

        public string DueDate { get; private set; }

        public int NumberOfDoses { get; private set; }

        public int IntervalBetweenDoses { get; private set; }
    }
}

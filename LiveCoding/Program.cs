using System;
using System.IO;

namespace LiveCoding
{
    class Program
    {
        private enum State
        {
            Active,
            Inactive
        }

        

        static void Main(string[] args)
        {
            #region Enumerations

            Veranstaltungsstatus vaStatus = Veranstaltungsstatus.Fixiert;

            vaStatus = Veranstaltungsstatus.Abgesagt;

            string csvValue = "Geplant";
            vaStatus = (Veranstaltungsstatus)Enum.Parse(typeof(Veranstaltungsstatus), csvValue);
            Console.WriteLine(vaStatus);


            //if (Veranstaltungsstatus.TryParse(typeof(Veranstaltungsstatus), csvValue, true, out (Veranstaltungsstatus?)vaStatus))
            //{

            //}


            // OrderType
            // Parsing

            #endregion

            #region Object / Collection Initializers

            // Sensor Initialization
            Sensor temperatureSensor = new Sensor() { Name = "Temperature" };
            temperatureSensor.Age = 3;
            temperatureSensor.Name = "Humidity";

            #endregion

            #region Extension Methods

            int cnt = "Rennerstraße 15c".CountDigits(true);
            Console.WriteLine(cnt);
            #endregion

        }
    }
}

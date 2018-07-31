using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHowToMakeIntAndRestANullTypeV1._0._0
{
    class RobustGuy
    {
        public DateTime? BirthDay { get; private set; }
        public double? Height { get; private set; }

        public RobustGuy(string birthday, string height)
        {
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
                BirthDay = tempDate;
            else
                BirthDay = null;

            double tempDouble;
            if (double.TryParse(height.Replace('.',','), out tempDouble))
                Height = tempDouble;
            else
                Height = null;
        }

        public override string ToString()
        {
            string description;
            if (BirthDay != null)
                description = "Urodziłem się dnia " + BirthDay.Value.ToLongDateString();
            else
                description = "Nie poprawny format daty, spróbuj ponownie (tutaj informacja o formacie daty). \n";
            if (Height != null)
                description += "Mam " + Height + " centymetrów wzrostu.";
            else
                description += ", nie wiem, ile mam wzrostu.";
            return description;
        }


    }
}

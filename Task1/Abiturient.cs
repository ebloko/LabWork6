using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Abiturient
    {
        private string fullName;
        private int baseClass;
        private double avg;

        public string FullName1 { get => fullName; set => fullName = value; }

        public Abiturient()
            : this ("Иванов Иван Иванович", 11, 4.6)
        {
            
        }

        Abiturient abiturient1 = new Abiturient("Петров Петров Петров", 11, 5);
        


        public Abiturient(string fullName, int baseClass, double avg)
        {
            this.fullName = fullName;
            this.baseClass = baseClass;
            this.avg = avg;
        }

        Abiturient[] abiturient;
        public object this [string index]
        {
            get => index.ToString();
        }

        public string this[int index]
        {
            get
            {
                if (index == 1)
                {
                    return fullName;
                }
                if (index == 2)
                {
                    return baseClass.ToString();
                }
                if (index == 3)
                {
                    return avg.ToString();
                }
                return null;
            }
        }
    }
}

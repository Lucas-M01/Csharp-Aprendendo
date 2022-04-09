using System.Globalization;

namespace ExercicioFLista
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string _name;
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            _name = name;
            Salary = salary;
        }

        public string Name 
        {
            get { return _name; }
            set { if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public void increaseSalary(double percentage)
        {
            Salary += ((percentage / 100) * Salary);
        }

        public override string ToString()
        {
            return Id 
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

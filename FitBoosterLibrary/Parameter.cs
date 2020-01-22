using System;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text;
namespace FitBoosterLibrary
{
    // Class that helps storing user parameters;
    public class Parameter
    {
        // Weight parameter.
        private double _weight;
        // Bmi parameter.
        private double _bmi;
        // Target bmi paramter.
        private double _targetBmi;

        public Parameter() { }

        public Parameter(double weight, double bmi, double targetBmi)
        {
            Weight = weight;
            Bmi = bmi;
            TargetBmi = targetBmi;
            LastUpdated = DateTime.Now.Date;
        }

        // Returns or sets weight parameter.
        public double Weight
        {
            get => _weight;
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("Weight cannot be less than 0.");
                _weight = value;
            }
        }

        // Returns or sets bmi parameter.
        public double Bmi
        {
            get => _bmi;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("BMI cannot be less than 0.");
                _bmi = value;
            }
        }

        // Returns or sets target bmi parameter.
        public double TargetBmi
        {
            get => _targetBmi;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Target BMi cannot be less than 0.");
                _targetBmi = value;
            }
        }

        // Returns or sets last update time.
        public DateTime LastUpdated
        {
            get;
            set;
        }
    }
}

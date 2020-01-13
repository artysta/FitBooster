using System;

namespace FitBoosterLibrary
{
    public class Calculator
    {
        // Maximum height in centimeters.
        public readonly static double MAX_HEIGHT = 300D;
        // Maximum weight in kilograms.
        public readonly static double MAX_WEIGHT = 1000D;
        // Maximum age in years.
        public readonly static int MAX_AGE = 150;
        // Maximum activity rate.
        public readonly static double MAX_ACTIVITY_RATE = 2.00D;

        public readonly static double LOW_ACTIVITY = 1.25D;
        public readonly static double MEDIUM_ACTIVITY = 1.40D;
        public readonly static double HIGH_ACTIVITY = 1.60D;

        // BMI (Body Mass Index) - weight in kilograms (kg), height in centimeters (cm).
        // Formula: BMI = weight / height^2.
        public double CalculateBMI(double weight, double height)
        {
            if (weight < 1 || weight > MAX_WEIGHT) throw new ArgumentOutOfRangeException("weight", "Weight must be between 1 and " + MAX_WEIGHT + ".");
            if (height < 1 || height > MAX_HEIGHT) throw new ArgumentOutOfRangeException("height", "Height must be between 1 and " + MAX_HEIGHT + ".");
            return Math.Round(weight / Math.Pow((height / 100), 2), 2);
        }

        // BMR (Basal Metabolic Rate) - weight in kilograms (kg), height in centimeters (cm), age in years (y).
        // Mifflin-St Jeor Equation:
        //  - male (9,99 x weight) + (6,25 x height) - (4,92 x age) + 5,
        //  - female (9,99 x weight) + (6,25 x height) - (4,92 x age) - 161.
        public double CalculateBMR(double weight, double height, int age, Genders gender)
        {
            if (weight < 1 || weight > MAX_WEIGHT) throw new ArgumentOutOfRangeException("weight", "Weight must be between 1 and " + MAX_WEIGHT + ".");
            if (height < 1 || height > MAX_HEIGHT) throw new ArgumentOutOfRangeException("height", "Height must be between 1 and " + MAX_HEIGHT + ".");
            if (age < 1 || age > MAX_AGE) throw new ArgumentOutOfRangeException("age", "Age must be between 1 and " + MAX_AGE + ".");

            if (gender == Genders.Male)
            {
                return Math.Round((9.99 * weight) + (6.25 * height) - (4.92 * age) + 5, 2);
            }
            else
            {
                return Math.Round((9.99 * weight) + (6.25 * height) - (4.92 * age) - 161, 2);
            }
        }

        // AMR (Active Metabolic Rate) - weight in kilograms (kg), height in centimeters (cm), age in years (y), activityRate.
        // Activity rate - 1.00 (sedentary lifestyle, no activity) - 2.00 (really hard physical work, high activity).
        //  - LOW_ACTIVITY - 1.25,
        //  - MEDIUM_ACTIVITY - 1.40,
        //  - HIGH_ACTIVITY - 1.60.
        // Formula: AMR = BMR * activityRate.
        public double CalculateAMR(double weight, double height, int age, Genders gender, double activityRate)
        {
            if (activityRate < 1 || activityRate > MAX_ACTIVITY_RATE) throw new ArgumentOutOfRangeException("activityRate", "Activity rate must be between 1 and " + MAX_ACTIVITY_RATE + ".");
            return CalculateBMR(weight, height, age, gender) * activityRate;
        }
    }
}

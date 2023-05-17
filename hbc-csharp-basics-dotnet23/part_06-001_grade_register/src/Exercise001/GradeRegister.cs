namespace Exercise001
{
    using System.Collections.Generic;
    using System;
    public class GradeRegister
    {
        private List<int> grades;
        private List<int> points;

        public GradeRegister()
        {
            this.grades = new List<int>();
            this.points = new List<int>();
        }

        public void AddGradeBasedOnPoints(int points)
        {
            this.grades.Add(PointsToGrades(points));
            this.points.Add(points);
        }

        public int NumberOfGrades(int grade)
        {
            int count = 0;
            foreach (int received in this.grades)
            {
                if (received == grade)
                {
                    count++;
                }
            }
            return count;
        }

        public static int PointsToGrades(int points)
        {
            int grade = 0;
            if (points < 50)
            {
                grade = 0;
            }
            else if (points < 60)
            {
                grade = 1;
            }
            else if (points < 70)
            {
                grade = 2;
            }
            else if (points < 80)
            {
                grade = 3;
            }
            else if (points < 90)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }
            return grade;
        }

        public double AverageOfGrades()
        {
            // Hint! You don't need to round the -1, but you do need it for all the other results...

            int luku = this.grades.Count;

            if (luku == 0)
            {
                return -1;

            }
            int sum = 0;
            foreach (int value in this.grades)
            {
                sum += value;

            }

            double keskiArvo = (double)sum / luku;
            return Math.Round(keskiArvo, 2);

        }

        public double AverageOfPoints()
        {
            int count = this.points.Count;

            if (count == 1)
            {
                return -1;

            }
            int sum = 0;

            foreach (int value in this.points)
            {
                sum += value;

            }

            double average = (double)sum / count;

            return Math.Round(average, 2);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class StudentsQuiz
    {
        int quizID { get; set; }
        string quizType { get; set; }
        string FN { get; set; }
        int points { get; set; }
        double grade { get; set; }
        double rate { get; set; }
        string passed { get; set; }

        void calc_grade()
        {
            if (this.quizType == "f")
            {
                double[] scal = new double[] { 2.50, 2.75, 3.00, 3.25, 3.50, 3.75, 4.00, 4.25, 4.50, 4.75, 5.00, 5.25, 5.50, 5.75, 6, 6 };
                if (this.points <= 15)
                {
                    this.grade = 2;
                }
                else
                {
                    this.grade = scal[this.points - 15];
                    //the scale start from 15 
                }
            }
            if (this.quizType == "p")
            {
                double[] scal = new double[] { 3.00, 3.00, 3.50, 3.50, 4.50, 4.50, 5.50, 6.00 };
                if (this.points <= 8)
                {
                    this.grade = 2;
                }
                else
                {
                    this.grade = scal[this.points - 8];
                    //the scale start from 8 
                }
            }
            //Console.WriteLine(this.grade);
        }
        void calc_rate()
        {
            int totlePoints = 30; // 30 for totle
            if (this.quizType == "p")
            {
                totlePoints = 15;
            }
            if (this.grade == 2)
            {
                this.rate = 0;
            }
            else
            {
                this.rate = (this.points / totlePoints) * 100;
            }
        }
        void calc_passed()
        {
            if (this.grade > 2)
            {
                this.passed = "passed";
            }
            this.passed = "failed";
        }
        static void Main(string[] args)
        {
            List<StudentsQuiz> studentsQuizs = new List<StudentsQuiz>();

            string command = "";

            while (!command.Equals("4"))
            {
                Console.WriteLine("Operation (1-add;2-list;3-delete;4-end):");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        {
                            StudentsQuiz quiz = new StudentsQuiz();

                            Console.Write("Quiz Type (f-final; p-period): ");
                            quiz.quizType = Console.ReadLine();

                            Console.Write("FN: ");
                            quiz.FN = Console.ReadLine();

                            Console.Write("Points: ");
                            quiz.points = int.Parse(Console.ReadLine());


                            if (studentsQuizs.Exists(sq => sq.FN == quiz.FN && sq.quizType == quiz.quizType))
                            {
                                StudentsQuiz res = studentsQuizs.Find(sq => sq.FN == quiz.FN);
                                string testType = "";
                                if (res.quizType == "f")
                                {
                                    testType = "final";
                                }
                                if (res.quizType == "p")
                                {
                                    testType = "period";
                                }
                                Console.WriteLine($"The points for {testType} quiz of {res.FN} are changed to {quiz.points} ");
                                res.points = quiz.points;
                                res.calc_grade();
                                res.calc_rate();
                                Console.WriteLine($"Exam is {res.passed}");
                            }
                            else
                            {
                                quiz.calc_grade();
                                quiz.quizID = studentsQuizs.Count() + 1;
                                quiz.calc_rate();
                                quiz.calc_passed();
                                Console.WriteLine("New exam is added");
                                Console.WriteLine($"The grade is {quiz.grade}, the rate is {quiz.rate}");
                                Console.WriteLine($"Exam is {quiz.passed}");
                                studentsQuizs.Add(quiz);
                            }
                            break;
                        }
                    case "3":
                        {
                            break;

                        }

                    case "2":
                        {
                            foreach (StudentsQuiz row in studentsQuizs)
                            {
                                Console.WriteLine("QuizID {0}", row.quizID);
                                Console.WriteLine($"Type {row.quizType}, FN {row.FN} Points {row.points}, Grade {row.grade}, Rate {row.rate}, Result passed");

                            }
                            break;
                        }
                    case "4":
                        {

                            //double sum = 0;
                            //foreach (StudentsQuiz row in orders)
                            //{
                            //    sum = sum + row.price_bg * row.quantity;
                            //}
                            //Console.WriteLine("Number of orders: {0},Total amount of order: {1:N2}", orders.Count, sum);
                            //Console.WriteLine("Deleted orders: {0}", orders_deleted.Count);
                            return;
                        }

                }

            }
        }
    }
}

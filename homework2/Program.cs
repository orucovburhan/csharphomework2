using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[] {"Azərbaycan Xalq Cümhuriyyəti hansı ildə yaranıb?",
            "Qafqaz İslam Ordusu Bakını nə zaman azad edib?",
            "SSRİ nə zaman dağıldı?",
            "Azərbaycan BMT-yə nə zaman üzv oldu?",
            "Şuşa şəhəri nə zaman işğaldan azad olundu?",
            "I Dünya Müharibəsi nə vaxt başlayıb?",
            "II Dünya Müharibəsi nə vaxt başa çatdı?",
            "Bakı-Tbilisi-Ceyhan neft kəməri rəsmi olaraq nə zaman açılıb?",
            "Atatürk Türkiyədə respublikanı nə vaxt elan etdi?",
            "Azərbaycan müstəqilliyini nə zaman bərpa edib?"};

            string[] answers = new string[] { "1917", "1918", "1920", "1918", "1920", "1919",
                                              "1989", "1991", "1993", "1991", "1992", "1994",
                                              "2020", "2016", "2022", "1912", "1914", "1916",
                                              "1944", "1945", "1946", "2002", "2005", "2007",
                                              "1920", "1921", "1923", "1991", "1992", "1994" };
            string[] correct_answers = new string[] { "1918", "1918", "1991", "1992", "2020", "1914", "1945", "2005", "1923", "1991" };
            string[] repeated = new string[10];
            string[] wrong_answers = new string[10];

            int point = 0;
            
            int totalPoint = 0;
            Random rand = new Random();
            Random rand2 = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                System.Console.WriteLine($"Total point: {totalPoint}");
                System.Console.WriteLine($"{i + 1}th question: ");

                int random_question = rand.Next(0, 10);

                for (int j = 0; j < 2; j++)
                {
                    if (repeated.Contains(questions[random_question]))
                    {
                        random_question = rand.Next(0, 10);
                        j--;
                    }
                    else
                        break;

                }
                repeated[i] = questions[random_question];

                string A;
                string B;
                string C;
                int random_answer1 = rand.Next(random_question * 3, (random_question * 3) + 3);

                System.Console.WriteLine(questions[random_question]);
                System.Console.WriteLine($"A){answers[random_answer1]}");
                A = answers[random_answer1];
                if (random_answer1 > random_question * 3 + 1)
                {
                    System.Console.WriteLine($"B){answers[random_answer1 - 1]}");
                    System.Console.WriteLine($"C){answers[random_answer1 - 2]}");
                    B = answers[random_answer1 - 1];
                    C = answers[random_answer1 - 2];

                }
                else if (random_answer1 < random_question * 3 + 1)
                {
                    System.Console.WriteLine($"B){answers[random_answer1 + 1]}");
                    System.Console.WriteLine($"C){answers[random_answer1 + 2]}");
                    B = answers[random_answer1 + 1];
                    C = answers[random_answer1 + 2];
                }
                else
                {
                    System.Console.WriteLine($"B){answers[random_answer1 + 1]}");
                    System.Console.WriteLine($"C){answers[random_answer1 - 1]}");
                    B = answers[random_answer1 + 1];
                    C = answers[random_answer1 - 1];
                }

                string user_answer;
                void CorrectScreen()
                {
                    System.Console.WriteLine($"Total point: {totalPoint}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Correct!!!");
                    System.Console.WriteLine($"{i + 1}th question: ");
                    System.Console.WriteLine(questions[random_question]);
                    System.Console.WriteLine($"A){answers[random_answer1]}");

                    if (random_answer1 > random_question * 3 + 1)
                    {
                        System.Console.WriteLine($"B){answers[random_answer1 - 1]}");
                        System.Console.WriteLine($"C){answers[random_answer1 - 2]}");
                        B = answers[random_answer1 - 1];
                        C = answers[random_answer1 - 2];

                    }
                    else if (random_answer1 < random_question * 3 + 1)
                    {
                        System.Console.WriteLine($"B){answers[random_answer1 + 1]}");
                        System.Console.WriteLine($"C){answers[random_answer1 + 2]}");
                        B = answers[random_answer1 + 1];
                        C = answers[random_answer1 + 2];
                    }
                    else
                    {
                        System.Console.WriteLine($"B){answers[random_answer1 + 1]}");
                        System.Console.WriteLine($"C){answers[random_answer1 - 1]}");
                        B = answers[random_answer1 + 1];
                        C = answers[random_answer1 - 1];
                    }
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                void WrongScreen()
                {
                    if (totalPoint != 0)
                    {
                        totalPoint -= 10;
                    
                    }
                    System.Console.WriteLine($"Total point: {totalPoint}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Wrong!!!");
                    System.Console.WriteLine($"{i + 1}th question: ");
                    System.Console.WriteLine(questions[random_question]);
                    System.Console.WriteLine($"A){answers[random_answer1]}");

                    if (random_answer1 > random_question * 3 + 1)
                    {
                        System.Console.WriteLine($"B){answers[random_answer1 - 1]}");
                        System.Console.WriteLine($"C){answers[random_answer1 - 2]}");
                        B = answers[random_answer1 - 1];
                        C = answers[random_answer1 - 2];

                    }
                    else if (random_answer1 < random_question * 3 + 1)
                    {
                        System.Console.WriteLine($"B){answers[random_answer1 + 1]}");
                        System.Console.WriteLine($"C){answers[random_answer1 + 2]}");
                        B = answers[random_answer1 + 1];
                        C = answers[random_answer1 + 2];
                    }
                    else
                    {
                        System.Console.WriteLine($"B){answers[random_answer1 + 1]}");
                        System.Console.WriteLine($"C){answers[random_answer1 - 1]}");
                        B = answers[random_answer1 + 1];
                        C = answers[random_answer1 - 1];
                    }
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    Console.ForegroundColor = ConsoleColor.White;
                }


                System.Console.WriteLine("Enter your answer: ");
                user_answer = Console.ReadLine();
                if (user_answer == "a" || user_answer == "A")
                {
                    if (A == correct_answers[random_question])
                    {
                        totalPoint += 10;
                        Console.Clear();
                        CorrectScreen();
                    }
                    else
                    {
                       
                        Console.Clear();
                        WrongScreen();
                        wrong_answers[i] = questions[random_question];
                    }
                }
                else if (user_answer == "b" || user_answer == "B")
                {
                    if (B == correct_answers[random_question])
                    {
                        totalPoint += 10;
                        Console.Clear();
                        CorrectScreen();
                    }
                    else
                    {
                        
                        Console.Clear();
                        WrongScreen();
                        wrong_answers[i] = questions[random_question];
                    }
                }
                else if (user_answer == "c" || user_answer == "C")
                {
                    if (C == correct_answers[random_question])
                    {
                        totalPoint += 10;
                        Console.Clear();
                        CorrectScreen();
                    }
                    else
                    {
                        
                        Console.Clear();
                        WrongScreen();
                        wrong_answers[i] = questions[random_question];
                    }
                }
                else
                {
                    System.Console.WriteLine("Wrong input!!!");
                    i--;
                }

            }
            Console.Clear();
            System.Console.WriteLine("Exam ended...");
            System.Console.WriteLine("Your total score is: {0}", totalPoint);
            System.Console.WriteLine("Congratulations!!!");
            System.Console.WriteLine("1.See wrong answers");
            System.Console.WriteLine("2.Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                
                for (int i = 0; i < wrong_answers.Length; i++)
                {
                    System.Console.WriteLine(wrong_answers[i]);
                }
            }
            
            
           




            }
            
            
            
          

            
        }
         
    }
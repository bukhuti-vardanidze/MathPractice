namespace Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
             function1();
            function2();
            function3();
            function4();
            function5();
             function6();
             function7();
             function8();
            function9();
            function10();


        }

        // function 1 midarithmetical
        static void function1()
        {
            Console.Write("enter first number :");
            double numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number :");
            double numb2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number :");
            double numb3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter forth number :");
            double numb4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter fifth number :");
            double numb5 = Convert.ToInt32(Console.ReadLine());

            double result = (numb1 + numb2 + numb3 + numb4 + numb5)/5;
            Console.WriteLine($"midarithmetical is - {result}");


        }

        //Perimeter of a triangle
        static void function2()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("----------");
            Console.WriteLine("  *** Perimeter of a triangle ***  P = a+b+c ");
            Console.Write("enter first number :");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number :");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number :");
            double c = Convert.ToInt32(Console.ReadLine());
            
            
            double P = a+b+c;
            Console.WriteLine($"Perimeter of a triangle is - {P}");

        }

        // negative or positive
        static void function3()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("----------");
            Console.WriteLine("  *** negative or positive *** ");
            Console.Write("enter number :");
            double PosNeg = Convert.ToInt32(Console.ReadLine());
            if (PosNeg < 0)
            {
                Console.Write($"{PosNeg} is negative number");
            }
            else
            {
                Console.Write($"{PosNeg} is possitive number");
            }
            
        }

        //MAX Number
        static void function4()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("----------");
            Console.WriteLine("  *** MAX number *** ");
            Console.Write("enter first number : ");
            double maxnum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number : ");
            double maxnum2 = Convert.ToInt32(Console.ReadLine());
            if (maxnum1 > maxnum2)
            {
                Console.Write($"{maxnum1} is greater than {maxnum2}");
            }
            else if (maxnum1 < maxnum2)
            {
                Console.Write($"{maxnum2} is greater than {maxnum1}"); 
            }
            else
            {
                Console.Write($"{maxnum1} quals to {maxnum2}"); 

            }
            
        }

        //min number
        static void function5()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("----------");
            Console.WriteLine("  *** Min number *** ");
            Console.Write("enter first number : ");
            double minnum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number : ");
            double minnum2 = Convert.ToInt32(Console.ReadLine());
            if (minnum1 < minnum2)
            {
                Console.Write($"{minnum1} is lower than {minnum2}");
            }
            else if (minnum1 > minnum2)
            {
                Console.Write($"{minnum2} is lower than {minnum1}"); 
            }
            else
            {
                Console.Write($"{minnum1} quals to {minnum2}"); 

            }
            
        }

          // is Even ?
        static void function6()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("----------");
            Console.WriteLine("  *** Even numbers *** ");
            Console.Write("enter first number : ");
            double isEven1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number : ");
            double isEven2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number : ");
            double isEven3 = Convert.ToInt32(Console.ReadLine());
            if (isEven1 % 2 == 0 && isEven2 % 2 == 0 && isEven3 % 2 == 0)
            {
                Console.WriteLine($"{isEven1} , {isEven2} , {isEven3}  - this numbers are EvenNumber");
            }
            else
            {
                Console.WriteLine($"{isEven1} , {isEven2} , {isEven3}  - one of this numbers are not EvenNumber  ");
                Console.WriteLine("if you want found it");
            }
            
            
        }
    
        // is odd number?
        static void function7()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("      ----------      ");
            Console.WriteLine("  *** Odd numbers *** ");
            Console.Write("enter first number : ");
            double isOdd1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number : ");
            double isOdd2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number : ");
            double isOdd3 = Convert.ToInt32(Console.ReadLine());
            if (isOdd1 % 2 >= 1 && isOdd2 % 2 >= 1 && isOdd3 % 2 >= 1)
            {
                Console.WriteLine($"{isOdd1} , {isOdd2} , {isOdd3}  - this numbers are OddNumber");
            }
            else
            {
                Console.WriteLine($"{isOdd1} , {isOdd2} , {isOdd3}  - one of this numbers are not OddNumber  ");
                Console.WriteLine("if you want found it");
            }
            
            
        }
        
        
        // count odd number
        static void function8()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("      ----------      ");
            Console.WriteLine("  *** Count  Odd numbers *** ");
            Console.Write("enter first number : ");
            double Odd1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number : ");
            double Odd2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number : ");
            double Odd3 = Convert.ToInt32(Console.ReadLine());

            int odd = 0;
            

           if (Math.Abs(Odd1 % 2 - 1) >= 1)
            {
                if (Math.Abs(Odd2 % 2 - 1) >= 1)
                {
                    if (Math.Abs(Odd3 % 2 - 1) >= 1)
                    {
                        odd++;
                    }

                    odd++;
                }

                odd++;
            } 

         Console.WriteLine($"There is {odd} numbers");
            

        }
        
        //count numbers which is greater than 10
        static void function9()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("      ----------      ");
            Console.WriteLine("  *** count />10/ numbers *** ");
            Console.Write("enter first number : ");
            double greaterthan1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number : ");
            double greaterthan2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number : ");
            double greaterthan3 = Convert.ToInt32(Console.ReadLine());

            int greaterThan10 = 0;
            

            if (greaterthan1 > 10)
            {
                if (greaterthan2 > 10)
                {
                    if (greaterthan3 > 10)
                    {
                        greaterThan10++;
                    }

                    greaterThan10++;
                }

                greaterThan10++;
            } 

            Console.WriteLine($"There is {greaterThan10}  numbers which is greater than 10");
            

        }


        static void function10()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("      ----------      ");
            Console.WriteLine("  *** show message if number equlas 30 or lower than 5 *** ");
            Console.Write("enter first number : ");
            double lastOne = Convert.ToInt32(Console.ReadLine());
            if (lastOne == 30)
            {
                Console.Write($"{lastOne} equals to 30 ");
            } 
            else if (lastOne <= 5)
            {
                Console.WriteLine("your answer is right");
            }
            else
            {
                Console.WriteLine("Your number does not meet the requirements");
            }
            
       



        }


    }
}
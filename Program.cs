using System;

namespace ConsoleApp3
{
    class Program
    {
        /*
        задачи
        1) рассказать соседям про немецкий флаг
        2) про швейцарский флаг
        3) про норвежский флаг
        4) про израйльский флаг
        5) про американский флаг

        минимум 2 сделать - в формате какая квартира что делает плюс в консоль флаг
        в идеале все 5
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there general Kenobi!");
            //PadikiFancy(4, 15, 10);
            //GermanFlag(4, 15, 10);
            //SwitzerlandFlag(2, 10, 21);
            Console.ForegroundColor = ConsoleColor.White;
        }


        static void PadikiFancy(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houses:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floor(s) is(are) not lit");
            }
            else
            {
                Console.WriteLine("all flats work");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <= ostatok)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {
                            if (floor >= ((floorCount - ostatok) / 3 * 2 + ostatok - ((floorCount - ostatok) / 3 - 1)) && (floor <= ((floorCount - ostatok) / 3 * 2 + ostatok)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("*");
                            }
                        }
                        flatnumber++;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void GermanFlag(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houses:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floor(s) is(are) not lit");
            }
            else
            {
                Console.WriteLine("all flats work");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <= ostatok)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {
                            if (floor >= ((floorCount - ostatok) / 3 * 2 + ostatok - ((floorCount - ostatok) / 3 - 1)) && (floor <= ((floorCount - ostatok) / 3 * 2 + ostatok)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                            else if (floor >= ((floorCount - ostatok) / 3 * 2))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("*");
                            }
                        }
                        flatnumber++;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void SwitzerlandFlag(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houses:{flatPerFloor * floorCount * padikiCount}");
            //Нада ебануть проверку на минимальный размер флага
            if (floorCount < 5 ||  padikiCount * flatPerFloor < 5)
            {
                Console.WriteLine("Minimum flag size is 5*5");
            }
            //флаг Швейцарии квадратный, значит нужно сделать проверку на квадратность (ну тут конечно норкоманея но работает)
            int noLitColomn =0;
            int noLitFloor =0;

            if (floorCount == padikiCount * flatPerFloor && floorCount % 5 == 0 && padikiCount * flatPerFloor % 5 == 0)
            {
                Console.WriteLine("All right bitches. Light it all.");
            }
            if (floorCount % 5 != 0)
            {
                if (floorCount > padikiCount * flatPerFloor)
                {
                    noLitFloor = floorCount - ((padikiCount * flatPerFloor) / 5) * 5;
                }
                else
                {
                    noLitFloor = floorCount - ((floorCount) / 5) * 5;
                }
                Console.WriteLine($"Your first {noLitFloor} floor(s) is(are) not lit");
            }
            if (padikiCount * flatPerFloor % 5 != 0)
            {
                if (floorCount > padikiCount * flatPerFloor)
                {
                    noLitColomn = padikiCount * flatPerFloor - ((floorCount) / 5) * 5;
                }
                else
                {
                    noLitColomn = padikiCount * flatPerFloor - ((padikiCount * flatPerFloor) / 5) * 5;
                }
                Console.WriteLine($"Your first {noLitColomn} colomn(s) is(are) not lit");
            }
            if (floorCount % 5 == 0 && padikiCount * flatPerFloor % 5 == 0 && floorCount > padikiCount * flatPerFloor)
            {
                noLitFloor = floorCount - padikiCount * flatPerFloor;
                
                Console.WriteLine($"Your first {noLitFloor} floor(s) is(are) not lit");
            }
            if (floorCount % 5 == 0 && padikiCount * flatPerFloor % 5 == 0 && floorCount < padikiCount * flatPerFloor)
            {
                noLitColomn = padikiCount * flatPerFloor - floorCount;

                Console.WriteLine($"Your first {noLitColomn} floor(s) is(are) not lit");
            }
            //Ща буит долго и немного унизительно
            int indexX = 1;
            int indexY = 1;
            for (; indexY <= floorCount; indexY++)
            {
                for (; indexX <= padikiCount * flatPerFloor; indexX++)
                {
                    if (noLitFloor != 0 && indexY <= noLitFloor)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    else
                    {
                        if (noLitColomn != 0 && indexX <= noLitColomn)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                            if ((indexY <= (floorCount - noLitFloor) / 5 + noLitFloor) || (indexY > (floorCount - noLitFloor) * 4 / 5 + noLitFloor))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("*");
                                 }
                            else if ((indexY > (floorCount - noLitFloor) * 2/5 + noLitFloor) && (indexY <= (floorCount - noLitFloor) * 3 / 5 + noLitFloor))
                                 {
                                       if ((indexX > (padikiCount * flatPerFloor - noLitColomn) * 1 / 5 + noLitColomn) && (indexX <= (padikiCount * flatPerFloor - noLitColomn) * 4 / 5 + noLitColomn))
                                          {
                                               Console.ForegroundColor = ConsoleColor.White;
                                               Console.Write("*");
                                          }
                                       else
                                          {
                                              Console.ForegroundColor = ConsoleColor.Red;
                                              Console.Write("*");
                                           }
                            }
                            else
                                   {
                                      if ((indexX > (padikiCount * flatPerFloor - noLitColomn) * 2 / 5 + noLitColomn) && (indexX <= (padikiCount * flatPerFloor - noLitColomn) * 3 / 5 + noLitColomn))
                                         {
                                         Console.ForegroundColor = ConsoleColor.White;
                                         Console.Write("*");
                                         }
                                       else
                                          {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("*");
                                          }
                                   }
                             Console.Write(" ");
                    }
                        
                }
                indexX = 1;
                Console.WriteLine();
            }
            //Кто касавчик? Я красавчик
        }

        static void NorwayFlag(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houses:{flatPerFloor * floorCount * padikiCount}");
            //Нада ебануть проверку на минимальный размер флага
            if (floorCount < 5 || padikiCount * flatPerFloor < 5)
            {
                Console.WriteLine("Minimum flag size is 5*5");
            }
            //флаг Швейцарии квадратный, значит нужно сделать проверку на квадратность (ну тут конечно норкоманея но работает)
            int noLitColomn = 0;
            int noLitFloor = 0;

            if (floorCount == padikiCount * flatPerFloor && floorCount % 5 == 0 && padikiCount * flatPerFloor % 5 == 0)
            {
                Console.WriteLine("All right bitches. Light it all.");
            }
            if (floorCount % 5 != 0)
            {
                if (floorCount > padikiCount * flatPerFloor)
                {
                    noLitFloor = floorCount - ((padikiCount * flatPerFloor) / 5) * 5;
                }
                else
                {
                    noLitFloor = floorCount - ((floorCount) / 5) * 5;
                }
                Console.WriteLine($"Your first {noLitFloor} floor(s) is(are) not lit");
            }
            if (padikiCount * flatPerFloor % 5 != 0)
            {
                if (floorCount > padikiCount * flatPerFloor)
                {
                    noLitColomn = padikiCount * flatPerFloor - ((floorCount) / 5) * 5;
                }
                else
                {
                    noLitColomn = padikiCount * flatPerFloor - ((padikiCount * flatPerFloor) / 5) * 5;
                }
                Console.WriteLine($"Your first {noLitColomn} colomn(s) is(are) not lit");
            }
            if (floorCount % 5 == 0 && padikiCount * flatPerFloor % 5 == 0 && floorCount > padikiCount * flatPerFloor)
            {
                noLitFloor = floorCount - padikiCount * flatPerFloor;

                Console.WriteLine($"Your first {noLitFloor} floor(s) is(are) not lit");
            }
            if (floorCount % 5 == 0 && padikiCount * flatPerFloor % 5 == 0 && floorCount < padikiCount * flatPerFloor)
            {
                noLitColomn = padikiCount * flatPerFloor - floorCount;

                Console.WriteLine($"Your first {noLitColomn} floor(s) is(are) not lit");
            }
            //Ща буит долго и немного унизительно
            int indexX = 1;
            int indexY = 1;
            for (; indexY <= floorCount; indexY++)
            {
                for (; indexX <= padikiCount * flatPerFloor; indexX++)
                {
                    if (noLitFloor != 0 && indexY <= noLitFloor)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    else
                    {
                        if (noLitColomn != 0 && indexX <= noLitColomn)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                            if ((indexY <= (floorCount - noLitFloor) / 5 + noLitFloor) || (indexY > (floorCount - noLitFloor) * 4 / 5 + noLitFloor))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("*");
                        }
                        else if ((indexY > (floorCount - noLitFloor) * 2 / 5 + noLitFloor) && (indexY <= (floorCount - noLitFloor) * 3 / 5 + noLitFloor))
                        {
                            if ((indexX > (padikiCount * flatPerFloor - noLitColomn) * 1 / 5 + noLitColomn) && (indexX <= (padikiCount * flatPerFloor - noLitColomn) * 4 / 5 + noLitColomn))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                        }
                        else
                        {
                            if ((indexX > (padikiCount * flatPerFloor - noLitColomn) * 2 / 5 + noLitColomn) && (indexX <= (padikiCount * flatPerFloor - noLitColomn) * 3 / 5 + noLitColomn))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                        }
                        Console.Write(" ");
                    }

                }
                indexX = 1;
                Console.WriteLine();
            }
        }

    }
}

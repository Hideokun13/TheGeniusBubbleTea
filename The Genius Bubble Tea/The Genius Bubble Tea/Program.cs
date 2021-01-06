using System;
namespace The_Genius_Bubble_Tea
{
    class Program
    {
        // ประกาศ Arrays 
        static string[] M_FavoredTea = new string[] { "Green Tea", "Jasmine Green Tea", "Jasmine Honey Green Tea", "Jasmine Honey Lemon Green Tea", "Apple Green Tea", "Melon Green Tea",
                                  "Lychee Green Tea", "Matcha Green Tea", "Black Tea", "Honey Green Tea" };
        static string[] M_MilkTea = new string[] { "Milk Tea", "Green Tea", "Thai Tea", "Caramel Milk Tea", "Green Tea Macchiato", "Matcha Macchiato" };
        static string[] M_Latte = { "Black Tea Latte", "Green Tea Latte", "Matcha Latte", "Chocolate Milk" };
        static string[] M_FruitSoda = new string[] { "Strawberry Soda", "Kiwi Soda", "Apple Soda", "Blueberry Soda", "Plum Soda", "Melon Soda", "Lychee Soda", "Passion Fruit Soda",
                                "Mixed Fruit Soda", "Mango Soda", };
        static string[] M_Yogurt = new string[] { "Yogurt Green Tea", "Passion Fruit Yogurt Green Tea", "Apple Yogurt Green Tea", "Strawberry Yogurt Green Tea", "Blueberry Yogurt Green Tea",
                            "Plum Yogurt Green Tea" };
        static string[] M_Topping = new string[] { "Bubble", "Glass Jelly", "Golden Bubble", "Pudding Glass Jelly", "Jelly Fruit", "Aloe Vera", "Egg Pudding", "Chocolate Pudding",
                            "Red Bean", "Brown Sugar"};
        static string[] CupsSize = new string[] { "Size S", "Size M", "Size L" };
        static string[] Sweetness = new string[] { "More Sugar", "Full Sugar", "Less Sugar", "Half Sugar", "Quarter Sugar", "No Sugar" };
        static string[] M_Option = new string[] { "\nInvaild Menu, Please Try Again", "Please press Enter to continue...", "Your Choice is: " };

        static void Main()
        {
            // ประกาศตัวแปร

            string Menu, Menu1 = "", Menu2 = "", Menu3 = "", Menu4 = "", Menu5 = "";
            string MenuInput1 = "", MenuInput2 = "", MenuInput3 = "", MenuInput4 = "", MenuInput5 = "";
            string ToppingMenu = "", MenuTopping1 = "", Top1 = "";
            string Size = "", SizeCup = "";
            string sweetnessMenu = "", MenuSweet = "", Sweet1 = "";
            String MenuofSum = "";
            int PriceWater = 0, PriceBuble = 0, PriceSize = 0;
            int CupCount = 1;
            int YesORNo = 0;

            Console.WriteLine("==================================================================\n" +
                              "|                                                                 |\n" +
                              "|                                                                 |\n" +
                              "|                 Welcome to The Genius Bubble Tea                |\n" +
                              "|                                                                 |\n" +
                              "|                                                                 |\n" +
                              "==================================================================\n");
            Console.Write("Please Select the menu\n" +
                              "1 : Favored Tea\n" +
                              "2 : Milk Tea\n" +
                              "3 : Latte\n" +
                              "4 : Fruit Soda\n" +
                              "5 : Yogurt\n" +
                              M_Option[2]);
            int MenuInput = Convert.ToInt32(Console.ReadLine()); // รับค่าการเลือกประเภทเครื่องดื่ม
            switch (MenuInput)
            {
                case 1:
                    {
                        Menu = "Favored Tea";
                        {
                            Console.WriteLine("\n" + M_Option[2] + Menu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                            Console.Clear();
                        }
                        MenuInput1 = FavoredTea(Menu1); // ส่ง Menu ไป Method FavoredTea และกลับรับค่ามาเก็บที่ MenuInput 1
                        break;
                    }
                case 2:
                    {
                        Menu = "Milk Tea";
                        {
                            Console.WriteLine("\n" + M_Option[2] + Menu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                            Console.Clear();
                        }
                        MenuInput2 = MilkTea(Menu2); // ส่ง Menu ไป Method MilkTea และกลับรับค่ามาเก็บที่ MenuInput 2
                        break;
                    }
                case 3:
                    {
                        Menu = "Latte";
                        {
                            Console.WriteLine("\n" + M_Option[2] + Menu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                            Console.Clear();
                        }
                        MenuInput3 = Latte(Menu3); // ส่ง Menu ไป Method Latte และกลับรับค่ามาเก็บที่ MenuInput 3
                        break;
                    }
                case 4:
                    {
                        Menu = "Fruit Soda";
                        {
                            Console.WriteLine("\n" + M_Option[2] + Menu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                            Console.Clear();
                        }
                        MenuInput4 = FruitSoda(Menu4); // ส่ง Menu ไป Method FFruitSoda และกลับรับค่ามาเก็บที่ MenuInput 4
                        break;
                    }
                case 5:
                    {
                        Menu = "Yogurt";
                        {
                            Console.WriteLine("\n" + M_Option[2] + Menu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                            Console.Clear();
                        }
                        MenuInput5 = Yogurt(Menu5); // ส่ง Menu ไป Method Yogurt และกลับรับค่ามาเก็บที่ MenuInput 5
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();

                        Main();
                        break;
                    }
            }
            if (MenuInput1 != "")
            {
                MenuofSum = MenuInput1;
            }
            else if (MenuInput2 != "")
            {
                MenuofSum = MenuInput2;
            }
            else if (MenuInput3 != "")
            {
                MenuofSum = MenuInput3;
            }
            else if (MenuInput4 != "")
            {
                MenuofSum = MenuInput4;
            }
            else if (MenuInput5 != "")
            {
                MenuofSum = MenuInput5;
            }

            switch (MenuofSum)
            {
                case "Green Tea": PriceWater = 30; break;
                case "Jasmine Green Tea": PriceWater = 30; break;
                case "Jasmine Honey Green Tea": PriceWater = 30; break;
                case "Jasmin Honey Lemon Tea": PriceWater = 30; break;
                case "Apple Green Tea": PriceWater = 30; break;
                case "Melon Green Tea": PriceWater = 30; break;
                case "Lychee Green Tea": PriceWater = 30; break;
                case "Matcha Green Tea": PriceWater = 35; break;
                case "Black Tea": PriceWater = 30; break;
                case "Honey Green Tea": PriceWater = 30; break;
                case "Milk Tea": PriceWater = 30; break;
                case "GreenTea": PriceWater = 30; break;
                case "Thai Tea": PriceWater = 30; break;
                case "Caramel Milk Tea": PriceWater = 35; break;
                case "Green Tea Macchiato": PriceWater = 35; break;
                case "Matcha Macchianto": PriceWater = 40; break;
                case "Black Tea Latte": PriceWater = 30; break;
                case "Green Tea Latte": PriceWater = 35; break;
                case "Matcha Latte": PriceWater = 30; break;
                case "Chocolate Milk": PriceWater = 30; break;
                case "Strawberry Soda": PriceWater = 30; break;
                case "Apple Soda": PriceWater = 30; break;
                case "Blueberry Soda": PriceWater = 30; break;
                case "Plum Soda": PriceWater = 30; break;
                case "Melon Soda": PriceWater = 30; break;
                case "Lychee Soda": PriceWater = 30; break;
                case "Passion Fruit Soda": PriceWater = 30; break;
                case "Mixed Fruit Soda": PriceWater = 30; break;
                case "Mango Soda": PriceWater = 30; break;
                case "Yogurt Green Tea": PriceWater = 40; break;
                case "Passion Fruit Yogurt Green Tea": PriceWater = 40; break;
                case "Apple Yogurt Green Tea": PriceWater = 40; break;
                case "Strawberry Yogurt Green Tea": PriceWater = 40; break;
                case "Blueberry Yogurt Green Tea": PriceWater = 40; break;
                case "Plum Yogurt Green Tea": PriceWater = 40; break;
                default: Console.WriteLine(M_Option[0]); break;

            }

            Console.Clear();

            Console.WriteLine("-----------------------------\n" +
                              "| You want to add topping? |\n" +
                              "----------------------------\n");
            Console.Write("1 for add topping || 2 for don't add topping\n" +
                              M_Option[2]);
            int Toppinginput = Convert.ToInt32(Console.ReadLine());
            switch (Toppinginput)
            {
                case 1:
                    {
                        ToppingMenu = "Add topping!!";
                        {
                            Console.WriteLine("\n" + M_Option[2] + ToppingMenu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();

                            Console.Clear();
                        }
                        MenuTopping1 = Topping(Top1); // ส่ง Menu ไป Method FavoredTea และกลับรับค่ามาเก็บที่ MenuInput 1
                        break;
                    }
                case 2:
                    {
                        ToppingMenu = "Don't Add Topping!!";
                        {
                            Console.WriteLine("\n" + M_Option[2] + ToppingMenu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();

                            Console.Clear();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();

                        MenuTopping1 = Topping(Top1);
                        break;
                    }
            }
            switch (MenuTopping1)
            {
                case "Bubble": PriceBuble = 5; break;
                case "Golden Bubble": PriceBuble = 5; break;
                case "Pudding Glass Jelly": PriceBuble = 5; break;
                case "Jelly Fruit": PriceBuble = 5; break;
                case "Aloe Vera": PriceBuble = 5; break;
                case "Glass Jelly": PriceBuble = 5; break;
                case "Egg Pudding": PriceBuble = 5; break;
                case "Chocolate Pudding": PriceBuble = 5; break;
                case "Red Bean": PriceBuble = 5; break;
                case "Brown Sugar": PriceBuble = 10; break;
                default: Console.WriteLine(M_Option[0]); break;

            }
            Console.Clear();

            Console.WriteLine("-----------------------------\n" +
                              "| Choose Your Sweetness Level |\n" +
                              "----------------------------\n");
            Console.Write("1 for Normal || 2 for Select Level\n" +
                              M_Option[2]);
            int sweetnessinput = Convert.ToInt32(Console.ReadLine());
            switch (sweetnessinput)
            {
                case 1:
                    {
                        sweetnessMenu = "Normal Level";
                        {
                            MenuSweet = "Normal Level";
                            Console.WriteLine("\n"+ M_Option[2] + sweetnessMenu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        sweetnessMenu = "Select Sweetness Level!!";
                        {
                            Console.WriteLine("\n" + M_Option[2] + sweetnessMenu);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                            Console.Clear();
                        }
                        MenuSweet = SweetnessLevel(Sweet1); // ส่ง Menu ไป Method FavoredTea และกลับรับค่ามาเก็บที่ MenuInput 1// ส่ง Menu ไป Method MilkTea และกลับรับค่ามาเก็บที่ MenuInput 2
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();

                        MenuSweet = SweetnessLevel(Sweet1);
                        break;
                    }
            }
            Console.Clear();

            Size = TheSizeCup(SizeCup); // ทำไซส์ใน Method TheSizeCup และส่งค่ากลับมาที่ตัวแปร Size
            switch (Size)
            {
                case "Size S": PriceSize = 0; break;
                case "Size M": PriceSize = 10; break;
                case "Size L": PriceSize = 15; break;
                default: Console.WriteLine(M_Option[0]); break;
            }
            Console.Clear();
            int CupCountState = AmounT(CupCount);
            int Sum = 0;
            Sum = Summary(PriceWater, PriceBuble, PriceSize, CupCountState);


            Console.Clear();

            Console.WriteLine("----------------------\n" +
                              "|       Summary       |\n" +
                              "----------------------\n");

            Console.WriteLine("You Have ordered:\n\n" +
                                 "*" + MenuofSum + "\n  |____________________" + PriceWater + ".-");

            {
                if (MenuTopping1 != "")
                {
                    Console.WriteLine("*" + MenuTopping1 + "\n   |___________________" + PriceBuble + ".-");
                }
            }
            Console.WriteLine("*" + Size + "\n   |___________________" + PriceSize + ".-");

            {
                if (MenuSweet != "")
                {
                    Console.WriteLine("*" + MenuSweet);
                }

            }
            Console.WriteLine(" \n* " + "Amount of Cup\n   |___________________" + CupCountState + " Cup");

            Console.WriteLine("\n====================================");
            Console.WriteLine("Total: " + Sum);
            Console.WriteLine("====================================\n\n\n");
            Console.WriteLine("             Thank you!                ");
            Console.ReadKey();

            // ตรวจสอบว่าผู้ใช้ต้องการสั่งเครื่องดื่มเพิ่มหรือไม่
            {
                int YesNoState = YesNo(YesORNo);
            }

        } // จบการทำงาน
        static string FavoredTea(string Menu1) // Method เมนูที่ 1
        {
            Console.Write("----------------------\n" +
                                  "|     Favored Tea    |\n" +
                                  "----------------------\n" +
                                  "1 :" + M_FavoredTea[0] + "\n" +
                                  "2 :" + M_FavoredTea[1] + "\n" +
                                  "3 :" + M_FavoredTea[2] + "\n" +
                                  "4 :" + M_FavoredTea[3] + "\n" +
                                  "5 :" + M_FavoredTea[4] + "\n" +
                                  "6 :" + M_FavoredTea[5] + "\n" +
                                  "7 :" + M_FavoredTea[6] + "\n" +
                                  "8 :" + M_FavoredTea[7] + "\n" +
                                  "9 :" + M_FavoredTea[8] + "\n" +
                                  "10 :" + M_FavoredTea[9] + "\n" +
                                  "Your Choice: ");
            int Menu1Input = Convert.ToInt32(Console.ReadLine()); //รับค่าเมนู
            string MenuSelect1;
            switch (Menu1Input)
            {
                case 1:
                    {
                        MenuSelect1 = M_FavoredTea[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelect1 = M_FavoredTea[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelect1 = M_FavoredTea[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelect1 = M_FavoredTea[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        MenuSelect1 = M_FavoredTea[4];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 6:
                    {
                        MenuSelect1 = M_FavoredTea[5];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 7:
                    {
                        MenuSelect1 = M_FavoredTea[6];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 8:
                    {
                        MenuSelect1 = M_FavoredTea[7];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 9:
                    {
                        MenuSelect1 = M_FavoredTea[8];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 10:
                    {
                        MenuSelect1 = M_FavoredTea[9];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect1);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return FavoredTea(Menu1); //return ไปยัง Method FavoredTea อีกครั้ง

                    }
            }
            return MenuSelect1; //ส่งค่า MenuSelect1 ไปยัง Main
        }
        static string MilkTea(string Menu2) // Method เมนูที่ 2
        {
            Console.Write("----------------------\n" +
                                  "|       Milk Tea      |\n" +
                                  "----------------------\n" +
                                  "1 :" + M_MilkTea[0] + "\n" +
                                  "2 :" + M_MilkTea[1] + "\n" +
                                  "3 :" + M_MilkTea[2] + "\n" +
                                  "4 :" + M_MilkTea[3] + "\n" +
                                  "5 :" + M_MilkTea[4] + "\n" +
                                  "6 :" + M_MilkTea[5] + "\n" +
                                  "Your Choice: ");
            int Menu2Input = Convert.ToInt32(Console.ReadLine()); //รับค่าเมนู
            string MenuSelect2;
            switch (Menu2Input)
            {
                case 1:
                    {
                        MenuSelect2 = M_MilkTea[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect2);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelect2 = M_MilkTea[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect2);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelect2 = M_MilkTea[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect2);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelect2 = M_MilkTea[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect2);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        MenuSelect2 = M_MilkTea[4];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect2);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 6:
                    {
                        MenuSelect2 = M_MilkTea[5];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect2);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return MilkTea(Menu2); //return ไปยัง Method MilkTea อีกครั้ง
                    }
            }
            return MenuSelect2; //ส่งค่า MenuSelect2 ไปยัง Main
        }
        static string Latte(string Menu3)	// Method เมนูที่ 3 
        {
            Console.Write("----------------------\n" +
                          "|        Latte       |\n" +
                          "----------------------\n" +
                          "1 :" + M_Latte[0] + "\n" +
                          "2 :" + M_Latte[1] + "\n" +
                          "3 :" + M_Latte[2] + "\n" +
                          "4 :" + M_Latte[3] + "\n" +
                          "Your Choice: ");

            int Menu3Input = Convert.ToInt32(Console.ReadLine()); // รับค่าเมนู
            string MenuSelect3;
            switch (Menu3Input)
            {
                case 1:
                    {
                        MenuSelect3 = M_Latte[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect3);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelect3 = M_Latte[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect3);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelect3 = M_Latte[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect3);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelect3 = M_Latte[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect3);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return Latte(Menu3); //return ไปยัง Method Latte อีกครั้ง
                    }
            }
            return MenuSelect3; //ส่งค่า MenuSelect3 ไปยัง Main
        }
        static string FruitSoda(string Menu4) // Method เมนูที่ 4
        {
            Console.Write("----------------------\n" +
                                  "|      FruitSoda     |\n" +
                                  "----------------------\n" +
                                  "1 :" + M_FruitSoda[0] + "\n" +
                                  "2 :" + M_FruitSoda[1] + "\n" +
                                  "3 :" + M_FruitSoda[2] + "\n" +
                                  "4 :" + M_FruitSoda[3] + "\n" +
                                  "5 :" + M_FruitSoda[4] + "\n" +
                                  "6 :" + M_FruitSoda[5] + "\n" +
                                  "7 :" + M_FruitSoda[6] + "\n" +
                                  "8 :" + M_FruitSoda[7] + "\n" +
                                  "9 :" + M_FruitSoda[8] + "\n" +
                                  "10:" + M_FruitSoda[9] + "\n" +
                                  "Your Choice: ");
            int Menu4Input = Convert.ToInt32(Console.ReadLine()); // รับค่าเมนู
            string MenuSelect4;
            switch (Menu4Input)
            {
                case 1:
                    {
                        MenuSelect4 = M_FruitSoda[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelect4 = M_FruitSoda[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelect4 = M_FruitSoda[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelect4 = M_FruitSoda[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        MenuSelect4 = M_FruitSoda[4];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 6:
                    {
                        MenuSelect4 = M_FruitSoda[5];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 7:
                    {
                        MenuSelect4 = M_FruitSoda[6];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 8:
                    {
                        MenuSelect4 = M_FruitSoda[7];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 9:
                    {
                        MenuSelect4 = M_FruitSoda[8];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 10:
                    {
                        MenuSelect4 = M_FruitSoda[9];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect4);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return FruitSoda(Menu4); //return ไปยัง Method FruitSoda อีกครั้ง
                    }
            }
            return MenuSelect4; //ส่งค่า MenuSelect4 ไปยัง Main
        }
        static string Yogurt(string Menu5)  // Method เมนูที่ 5
        {

            Console.Write("----------------------\n" +
                             "|        Yogurt      |\n" +
                             "----------------------\n" +
                             "1 :" + M_Yogurt[0] + "\n" +
                             "2 :" + M_Yogurt[1] + "\n" +
                             "3 :" + M_Yogurt[2] + "\n" +
                             "4 :" + M_Yogurt[3] + "\n" +
                             "5 :" + M_Yogurt[4] + "\n" +
                             "6 :" + M_Yogurt[5] + "\n" +
                             "Your Choice: ");
            int Menu5Input = Convert.ToInt32(Console.ReadLine()); //รับค่าเมนู
            string MenuSelect5;
            switch (Menu5Input)
            {
                case 1:
                    {
                        MenuSelect5 = M_Yogurt[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect5);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelect5 = M_Yogurt[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect5);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelect5 = M_Yogurt[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect5);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelect5 = M_Yogurt[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect5);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        MenuSelect5 = M_Yogurt[4];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect5);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 6:
                    {
                        MenuSelect5 = M_Yogurt[5];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelect5);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return Yogurt(Menu5); //return ไปยัง Method Yogurt อีกครั้ง
                    }
            }
            return MenuSelect5; //ส่งค่า MenuSelect5 ไปยัง Main
        }
        static string Topping(string Top) // Method เมนูท็อปปิ้ง
        {
            Console.Write("----------------------\n" +
                          "|  Topping + 5 Baht   |\n" +
                          "----------------------\n" +
                         "1 :" + M_Topping[0] + "\n" +
                         "2 :" + M_Topping[1] + "\n" +
                         "3 :" + M_Topping[2] + "\n" +
                         "4 :" + M_Topping[3] + "\n" +
                         "5 :" + M_Topping[4] + "\n" +
                         "6 :" + M_Topping[5] + "\n" +
                         "7 :" + M_Topping[6] + "\n" +
                         "8 :" + M_Topping[7] + "\n" +
                         "9 :" + M_Topping[8] + "\n" +
                         "10 :" + M_Topping[9] + " (Added 10 Baht) " + "\n" +
                         "Your Choice: ");
            int MenuTopInput = Convert.ToInt32(Console.ReadLine()); // รับค่าท็อปปิ้ง
            string MenuSelectTop;
            switch (MenuTopInput)
            {
                case 1:
                    {
                        MenuSelectTop = M_Topping[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelectTop = M_Topping[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelectTop = M_Topping[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelectTop = M_Topping[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        MenuSelectTop = M_Topping[4];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 6:
                    {
                        MenuSelectTop = M_Topping[5];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 7:
                    {
                        MenuSelectTop = M_Topping[6];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 8:
                    {
                        MenuSelectTop = M_Topping[7];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 9:
                    {
                        MenuSelectTop = M_Topping[8];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 10:
                    {
                        MenuSelectTop = M_Topping[9];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectTop +" (Added 10 Baht) ");
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return Topping(Top); //return ไปยัง Method Topping อีกครั้ง
                    }
            }
            return MenuSelectTop; //ส่งค่า MenuSelectTop ไปยัง Method Main
        }
        static string TheSizeCup(string Size) // Method ไซส์แก้ว
        {
            Console.WriteLine("What's the size do you like?"); // แสดงการเลือกไซส์แก้ว
            Console.WriteLine("\n1.Size S \n2.Size M (Added 10 Baht) \n3.Size L (Added 15 Baht)\n");
            Console.Write("Your Choice: ");
            int SizeInput = Convert.ToInt32(Console.ReadLine()); // รับค่าไซส์แก้ว
            string CupSize = "";
            switch (SizeInput)
            {
                case 1:
                    {
                        CupSize = CupsSize[0];
                        Console.WriteLine("\n" + M_Option[2] + CupSize);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        CupSize = CupsSize[1];
                        Console.WriteLine("\n" + M_Option[2] + CupSize);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        CupSize = CupsSize[2];
                        Console.WriteLine("\n" + M_Option[2] + CupSize);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return TheSizeCup(Size); //return ไปยัง Method TheSizeCup อีกครั้ง
                    }
            }
            return CupSize; //ส่งค่า CupSize ไปยัง Method Main
        }
        static string SweetnessLevel(string Sweet) //Method ความหวาน
        {
            Console.Write("----------------------\n" +
                             "|   Sweetness Level  |\n" +
                             "----------------------\n" +
                             "1 :" + Sweetness[0] + "\n" +
                             "2 :" + Sweetness[1] + "\n" +
                             "3 :" + Sweetness[2] + "\n" +
                             "4 :" + Sweetness[3] + "\n" +
                             "5 :" + Sweetness[4] + "\n" +
                             "6 :" + Sweetness[5] + "\n" +
                             "Your Choice: ");
            int MenuSweetInput = Convert.ToInt32(Console.ReadLine()); //รับค่า Input ระดับความหวาน
            string MenuSelectSweet;
            switch (MenuSweetInput)
            {
                case 1:
                    {
                        MenuSelectSweet = Sweetness[0];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectSweet);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 2:
                    {
                        MenuSelectSweet = Sweetness[1];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectSweet);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 3:
                    {
                        MenuSelectSweet = Sweetness[2];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectSweet);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 4:
                    {
                        MenuSelectSweet = Sweetness[3];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectSweet);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 5:
                    {
                        MenuSelectSweet = Sweetness[4];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectSweet);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                case 6:
                    {
                        MenuSelectSweet = Sweetness[5];
                        {
                            Console.WriteLine("\n" + M_Option[2] + MenuSelectSweet);
                            Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(M_Option[0]);
                        Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                        Console.ReadKey();
                        Console.Clear();
                        return SweetnessLevel(Sweet); //return ไปยัง Method SweetnessLevel อีกครั้ง
                    }
            }
            return MenuSelectSweet; // ส่งค่า MenuSelectSweet ไปยัง Method Main
        }
        static int AmounT(int A)  // Method จำนวนแก้ว
        {
            Console.Write("Amount of Cup\n" +
                              "Enter Amount: ");
            int Amount = Convert.ToInt32(Console.ReadLine()); //รับค่าจำนวนแก้ว
            if (Amount > 0) // เช็คค่า Input จำนวนแก้ว
            {
                Console.WriteLine("\n" + M_Option[2] + Amount);
                Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                Console.ReadKey();
                Console.Clear();
                return Amount; //ส่งค่า Amount ไปยัง Method Main
            }
            else
            {
                Console.WriteLine(M_Option[0]);
                Console.Write(M_Option[1]); //กดปุ่ม Enter เพื่อดำเนินการต่อ
                Console.ReadKey();
                Console.Clear();
                return AmounT(A); //return ไปยัง Method AmounT อีกครั้ง
            }

        }
        static int Summary(int Water, int Buble, int Size, int CupCount) // Method คำนวณราคา
        {
            int Sum = (Water + Buble + Size) * CupCount;
            Console.Clear();

            return Sum; // ส่งค่า Sum กลับไปยัง Method Main
        }

        static int YesNo(int YesORNO)
        {
            Console.WriteLine("What would you like to ordered more?");
            Console.WriteLine("Press 1 to Ordered more \nPress 0 to Exit");
            int YesORNo = Convert.ToInt32(Console.ReadLine());

            if (YesORNo == 1)
            {
                Console.Clear();
                Main();
            }
            else if (YesORNo == 0)
            {
                Console.WriteLine("Thank You to visit The Genuis Bubble Tea!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(M_Option[0]);
                Console.ReadLine();
                Console.Clear();
                YesNo(YesORNo);
            }
            return YesORNo;
        }

    }
}
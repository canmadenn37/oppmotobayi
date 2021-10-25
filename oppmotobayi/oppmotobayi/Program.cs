using System;

namespace oppmotobayi
{
    public   class Motor {


        public int secim { get; set; }

        public int Hscm1 = 1000;
        public int Hscm2 = 1000;
        public int Hscm3 = 1000;
        public int Hscm4 = 1000;
        public int Hscm5 = 1000;
        public int Hscm6 = 1000;
        public int Hscm7 = 1000;
        public int Hscm8 = 1000;
        public int Bakiye { get; set; }



    }
        



    class Program
    {
        




        static void Main(string[] args)
        {


            Motor a = new Motor();








            Console.WriteLine("--------------");
            Console.WriteLine("  Bakiye gir ");
            Console.WriteLine("--------------");
            a.Bakiye = int.Parse(Console.ReadLine());
            Console.WriteLine("---***----Menü---***----");
            Console.WriteLine("-1- Satin Alma \n " + "-2-Ürün Satış\n" + "-3-Bakiye Göster\n" + "Çıkış");

            a.secim = int.Parse(Console.ReadLine());

            switch (a.secim)
            {
                case 1:
                    Salma();
                    break;
                case 2:
                    Syap();
                    break;
                case 3:
                    Console.WriteLine(a.Bakiye);
                    break;
                case 4:
                    break;




                default:
                    break;
            }






        }









        public static void Salma()
        {
            Motor a = new Motor();

            Console.WriteLine("motor türü giriniz");
            Console.WriteLine("{0}{1}", "-1-Honda\n", "-2-Bmw\n");
            a.secim = int.Parse(Console.ReadLine());
            switch (a.secim)
            {
                case 1:
                    Console.WriteLine("seciminiz Honda");
                    Console.WriteLine("Tür seciniz!!");
                    Console.WriteLine("1-Sport\n" + "2-Scoter\n");
                    a.secim = int.Parse(Console.ReadLine());

                    switch (a.secim)
                    {
                        case 1:
                            Console.WriteLine("Secim sport");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye - a.Hscm1;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye - a.Hscm2;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Secim scoter");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye - a.Hscm3;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye - a.Hscm4;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                default:
                                    break;


                            }
                            break;

                    }
                    break;
                case 2:
                    Console.WriteLine("seciminiz Bmw");
                    Console.WriteLine("Tür seciniz!!");
                    Console.WriteLine("1-Sport\n" + "2-Scoter\n");
                    a.secim = int.Parse(Console.ReadLine());

                    switch (a.secim)
                    {
                        case 1:
                            Console.WriteLine("Secim sport");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye - a.Hscm5;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye - a.Hscm6;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Secim scoter");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye - a.Hscm7;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye - a.Hscm8;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                default:
                                    break;


                            }
                            break;

                    }
                    break;






                default:
                    Console.WriteLine("değer aralığı dışı");
                    break;
            }


        }
        public static void Syap()
        {
            Motor a = new Motor();

            Console.WriteLine("motor türü giriniz");
            Console.WriteLine("{0}{1}", "-1-Honda\n", "-2-Bmw\n");
            a.secim = int.Parse(Console.ReadLine());
            switch (a.secim)
            {
                case 1:
                    Console.WriteLine("seciminiz Honda");
                    Console.WriteLine("Tür seciniz!!");
                    Console.WriteLine("1-Sport\n" + "2-Scoter\n");
                    a.secim = int.Parse(Console.ReadLine());

                    switch (a.secim)
                    {
                        case 1:
                            Console.WriteLine("Secim sport");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye + a.Hscm1;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye + a.Hscm2;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Secim scoter");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye + a.Hscm3;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye + a.Hscm4;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                default:
                                    break;


                            }
                            break;

                    }
                    break;
                case 2:
                    Console.WriteLine("seciminiz Bmw");
                    Console.WriteLine("Tür seciniz!!");
                    Console.WriteLine("1-Sport\n" + "2-Scoter\n");
                    a.secim = int.Parse(Console.ReadLine());

                    switch (a.secim)
                    {
                        case 1:
                            Console.WriteLine("Secim sport");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye + a.Hscm5;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye + a.Hscm6;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Secim scoter");
                            Console.WriteLine("Model sec ");
                            Console.WriteLine("1 model a");
                            Console.WriteLine("2 model b ");

                            a.secim = int.Parse(Console.ReadLine());
                            switch (a.secim)
                            {
                                case 1:
                                    Console.WriteLine("Secim model a");
                                    a.Bakiye = a.Bakiye + a.Hscm7;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                case 2:
                                    Console.WriteLine("Secim model b");
                                    a.Bakiye = a.Bakiye + a.Hscm8;
                                    Console.WriteLine("Bakiye" + a.Bakiye);
                                    break;
                                default:
                                    break;


                            }
                            break;

                    }
                    break;






                default:
                    Console.WriteLine("değer aralığı dışı");
                    break;



            }













        }
    }








}
    


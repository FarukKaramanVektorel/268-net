namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Form f = new Form("Abuzer Kömürcü", 48);
                Console.WriteLine(f.Name);
            }
            catch (GecersizYasException e)
            {
               
                Console.WriteLine(e.Message);
            }




            //    Console.WriteLine(1);
            //    int[] numbers = { 5, 6, 7 };
            //    string message = null;
            //    try
            //    {
            //        Console.WriteLine(2);
            //        int x = 1;
            //        Console.WriteLine(5 / x);
            //        Console.WriteLine(3);
            //        Console.WriteLine(numbers[1]);
            //        Console.WriteLine(6);

            //        try
            //        {
            //            Console.WriteLine(message.Length);
            //        }catch(Exception e)
            //        {
            //            Console.WriteLine(9);
            //        }
            //        finally
            //        {
            //            Console.WriteLine(10);
            //        }


            //    }            
            //    catch (DivideByZeroException e)
            //    {
            //        Console.WriteLine(4);

            //    }
            //    catch (IndexOutOfRangeException e)
            //    {
            //        Console.WriteLine(7);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(8);
            //    }
            //    finally
            //    {
            //        Console.WriteLine(11);
            //    }
            //    Console.WriteLine(5);
            //    Console.WriteLine();


            //    myMetod();
            //}// 1-4-5 / 

            //private static void myMetod()
            //{
            //    throw new NotImplementedException("Boş metod ne bekliyorsun?");
            //}
        }
    }
}

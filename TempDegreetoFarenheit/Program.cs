namespace TempDegreetoFarenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Temperature Converter");

            string UserChoice = "";
            String YorN = "y";
            YorN = YorN.ToUpper();

            while (YorN.Equals("Y"))
            {

                Double Farenheit;
                Double Celcius;
                Console.WriteLine("Enter degrees in Farenheit");

                String UserFarenheit = Console.ReadLine();
                Farenheit = Double.Parse(UserFarenheit);

                //Console.WriteLine("Your number is "+Farenheit);

                Celcius = (Farenheit - 32) * 5 / 9;
                Celcius = Math.Round(Celcius, 2);
                Console.WriteLine($"Degrees in Celcius : {Celcius}");
                Boolean Success = false;

                while (!Success) { 
                Console.WriteLine("Continue Y/N?");
                UserChoice = Console.ReadLine();
                UserChoice = UserChoice.ToUpper();

                    if (UserChoice == "Y")
                    {
                        YorN = UserChoice;
                        Success = true;
                        break;
                    }
                    else
                    {
                        if (UserChoice == "N")
                        {
                            YorN = UserChoice;
                            Success = true;
                            break;
                        }
                        else
                            Console.WriteLine("Please enter Y or N");
                    }
                }

            }

            Console.WriteLine("Bye!");
        }
    }
}
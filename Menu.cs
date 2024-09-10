namespace PasswordGenerator
{
    internal class Menu
    {
        private Generating password = new Generating();

        public void PasswordMenu()
        {
            int num = 0;
            Console.WriteLine("Which Password do you need?");
            Console.WriteLine("\n1.EasyPassword\n\n2.MeduimPassword\n\n3.HardPassword\n");

            while (true)
            {
                try
                {
                    Console.Write("Enter: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }

                if (num == 1)
                {
                    Console.WriteLine("\nYour Password: " + password.EasyPass());
                    break;
                }
                else if (num == 2)
                {
                    Console.WriteLine("\nYour Password: " + password.MeduimPass());
                    break;
                }
                else if (num == 3)
                {
                    Console.WriteLine("\nYour Password: " + password.HardPass());
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }
            }
        }
    }
}

namespace PasswordGenerator
{
    internal class Generating
    {
        private const String letters = "J;FBN;OILSDJAs2314BVPKygfjhgvkJH?FytD%ut123456789rdkuhvjhvR@wreKJ#HGkhcjtDTYrdc56732ikugh";
        private Random random = new Random();

        public String EasyPass()
        {
            String EasyPassword = "";

            for (int i = 0; i < 5; i++)
            {
                int RandomNum = random.Next(0, letters.Length);
                EasyPassword += letters[RandomNum];
            }

            return EasyPassword;
        }

        public String MeduimPass()
        {
            String MeduimPassword = "";

            for (int i = 0; i < 10; i++)
            {
                int RandomNum = random.Next(0, letters.Length);
                MeduimPassword += letters[RandomNum];
            }

            return MeduimPassword;
        }

        public String HardPass()
        {
            String HardPassword = "";

            for (int i = 0; i < 15; i++)
            {
                int RandomNum = random.Next(0, letters.Length);
                HardPassword += letters[RandomNum];
            }

            return HardPassword;
        }
    }
}

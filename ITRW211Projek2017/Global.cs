namespace ITRW211Projek2017
{
    public static class Global
    {
        public static string Name = "";
        public static bool Admin = false;

        public static string connString =
                @"Provider=Microsoft.ACE.OlEDB.12.0; Data Source= C:\Users\Danie\Source\Repos\ITRW211\ITRW211Projek.accdb"
            ;

        public static string userLoginInfoFile =
            @"C:\Users\Danie\Source\Repos\ITRW211\Login.txt";

        public static string invoiceLocation =
            @"C:\Users\Danie\Source\Repos\ITRW211\ITRW211Projek2017\";
    }
}
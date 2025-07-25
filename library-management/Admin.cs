public class Admin
{
    private string userName="admin";
    private string password="1234";

    public static bool Authenticate(string name, string pass)
    {
        if (name == "admin" && pass == "1234")
        {
            Console.WriteLine("Login successful! Welcome Admin.");
            return true;
        }
        else
        {
            Console.WriteLine("Login failed! Please check your credentials.");
            return false;
        }
    }

}


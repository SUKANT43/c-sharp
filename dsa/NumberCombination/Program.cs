public class Program
{
    public static List<string> ls = new List<string>();
    public static Dictionary<char, string> map = new Dictionary<char, string>();


    public static void CreateCombination(string num)
    {
        map.Add('2', "abc");
        map.Add('3', "def");
        map.Add('4', "ghi");
        map.Add('5', "jkl");
        map.Add('6', "mno");
        map.Add('7', "pqrs");
        map.Add('8', "tuv");
        map.Add('9', "wxyz");
        Backtrack(num, 0, "");
    }

    public static void Backtrack(string num, int i, string ans)
    {
        if (num.Length == ans.Length)
        {
            ls.Add(ans);
            return;
        }
        foreach (var c in map[num[i]])
        {
            Backtrack(num, i + 1, ans + c);
        }
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the numbers to word combination");
        string num = Console.ReadLine();
        CreateCombination(num);
        foreach (var st in ls)
        {
            Console.WriteLine(st);
        }
        Console.ReadLine();
    }
}


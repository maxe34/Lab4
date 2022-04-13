class Program
{
    private static string _inputString;
    private static int _sBoxNumber;

    static void Main(string[] args)
    {
        _inputString = InputString();
        _sBoxNumber = InputKey();

        Console.WriteLine(_inputString);
        Console.WriteLine(_sBoxNumber);
    }

    private static string InputString()
    {
        Console.WriteLine("Introduceti stringul format din 48 biti");
        Console.WriteLine("Daca nu introduceti nimic stringul va fi generat");
        var s = Console.ReadLine();
        if (s == "")
        {
            s = "101010101010101010101010101010101010101010101010";
        }
        else if (!StringValidator(s))
        {
            s = InputString();
        }

        return s;
    }

    private static int InputKey()
    {
        int sBoxNumber = 0;
        Console.WriteLine("Introduceti cheia de la 1 la 8 ambele inclusiv");
        var keystring = Console.ReadLine();
        if (keystring != null)
        {
            sBoxNumber = short.Parse(keystring);
            if (sBoxNumber < 1 || sBoxNumber > 8)
                sBoxNumber = InputKey();
        }

        return sBoxNumber;
    }

    private static bool StringValidator(string s)
    {
        foreach (var c in s)
        {
            if ((c != '1' && c != '0') || s.Length != 48)
                return false;
        }

        return true;
    }
}
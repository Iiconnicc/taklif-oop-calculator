using System.Threading.Channels;
using taklif_oop;

    Console.WriteLine("prime check = a \n polyndrome = b");
    key_keyboard k1 = new key_keyboard();
    char choice = k1.kkey();

    if (choice == 'a')
    {
        Console.Clear();
        Console.WriteLine(" \n prime check");
        string inp = Console.ReadLine();
        int x = Convert.ToInt32(inp);
        if (x < 1000)
        {

            Risprime risprime = new Risprime();
            bool answer = risprime.istrue(x);
            if (answer) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
        }
        else
        {
            Pisprime a = new Pisprime();
            bool answer = a.istrue(x);
            if (answer) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
        }

    }
    else if (choice == 'b')
    {
        Console.Clear();
        Console.WriteLine("\npalyndrome check");
        string inp = Console.ReadLine();
        int x = Convert.ToInt32(inp);
        if (x < 1000)
        {
            palyndrome1 a = new palyndrome1();
            bool ans = a.istrue(x);
            if (ans) { Console.WriteLine("it is"); }
            else { Console.WriteLine("it isnt"); }
        }
        else
        {
            palyndrome2 a = new palyndrome2();
            bool ans = a.istrue(x);
            if (ans) { Console.WriteLine("it is"); }
            else { Console.WriteLine("it isnt"); }

        }





    }
    else { Console.WriteLine("WTF"); }














//Console.WriteLine("benevis jakesh");
//string input = Console.ReadLine();
//int x = Convert.ToInt32(input);

//Pisprime a1 = new Pisprime();

//bool isprime = a1.istrue(x);
//if (isprime) {
//    Console.WriteLine("true");
//        }
//else { Console.WriteLine("false"); }






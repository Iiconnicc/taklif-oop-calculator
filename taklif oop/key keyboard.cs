
namespace taklif_oop
{
    public class key_keyboard
    {
        public char kkey()
        {
            char _a;

            do
            {
                 _a = Console.ReadKey().KeyChar;
            } while (_a !='a'  && _a != 'b' && _a != 'c');
            return _a;
        }
    }
}

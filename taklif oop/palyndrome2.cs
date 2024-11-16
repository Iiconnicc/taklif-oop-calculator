namespace taklif_oop
{
    internal class palyndrome2 : calculator
    {
        public override bool istrue(int x)
        {
            // تبدیل عدد به رشته
            string strNumber = x.ToString();

            // بررسی آینه‌ای بودن از طریق مقایسه کاراکترها
            int length = strNumber.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (strNumber[i] != strNumber[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

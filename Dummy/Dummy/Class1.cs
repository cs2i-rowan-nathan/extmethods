namespace Dummy.Extensions
{
    public static class IntExtensions
    {
        public static bool NotEven(this int number)
        {
            return number % 2 != 0;
        }
    }
}
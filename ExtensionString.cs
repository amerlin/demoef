namespace ef_demo
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int IntWordCount(this int str)
        {
            return int.Max(1,3);
        }
    }
}

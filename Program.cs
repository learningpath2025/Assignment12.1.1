namespace Assignment12._1._1
{
    internal class Program
    {
        public static bool IsConstructable(string ransomNote, string magazine)
        {
            char[] ransomArr = ransomNote.ToCharArray();
            foreach (char c in ransomArr)
            {
                int index = magazine.IndexOf(c);
                if (index != -1)
                {
                    magazine = magazine.Remove(index, 1);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string ransomNote = "aab";
            string magazine = "baa";
            Console.WriteLine($"Output: {IsConstructable(ransomNote, magazine)}");
        }
    }
}

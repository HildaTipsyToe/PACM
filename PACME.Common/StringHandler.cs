namespace PACME.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }
                    else result += letter;
                }
            }
            return result;
        }
    }
}
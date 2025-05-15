namespace UniqueCodeCreator.Helpers
{
    public static class CodeGenerator
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const string numbers = "0123456789";

        public static string GenerateUniqueCode(int length, bool numbersOnly = false)
        {
            Random random = new Random();
            char[] codeChars = new char[length];
            for (int i = 0; i < codeChars.Length; i++)
            {
                codeChars[i] = numbersOnly 
                    ? numbers[random.Next(numbers.Length)]
                    : chars[random.Next(chars.Length)];
            }
            return new string(codeChars);
        }

        public static string GenerateUniqueCode(int length, string prefix, string sufix, bool numbersOnly = false)
        {
            string code = GenerateUniqueCode(length, numbersOnly);
            string formattedCode = "";

            if (!string.IsNullOrEmpty(prefix))
                formattedCode += $"{prefix}-";

            formattedCode += code;

            if (!string.IsNullOrEmpty(sufix))
                formattedCode += $"-{sufix}";

            return formattedCode;
        }

        public static List<string> GenerateUniqueCodes(int count, int length, string prefix, string sufix, bool numbersOnly = false)
        {
            HashSet<string> uniqueCodes = [];
            while (uniqueCodes.Count < count)
            {
                uniqueCodes.Add(GenerateUniqueCode(length, prefix, sufix, numbersOnly));
            }
            return uniqueCodes.ToList();
        }
    }
}

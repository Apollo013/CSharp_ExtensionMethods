namespace CSharpExtensionMethods
{
    public static class AddExtensionMethods
    {
        /// <summary>
        /// Add the values of 2 strings together (we're assuming that numeric values are passed as strings)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string Add(this string str, string str1, string str2)
        {
            int rv = 0;

            int num1 = 0, num2 = 0;

            if (int.TryParse(str1, out num1))
            {
                if (int.TryParse(str2, out num2))
                {
                    rv = num1 + num2;
                }
            }

            return rv.ToString();
        }

        /// <summary>
        /// Adds 2 integers together
        /// </summary>
        /// <param name="num"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Add(this int num, int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Adds 2 doubles together
        /// </summary>
        /// <param name="num"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double Add(this double num, double num1, double num2)
        {
            return num1 + num2;
        }
    }
}

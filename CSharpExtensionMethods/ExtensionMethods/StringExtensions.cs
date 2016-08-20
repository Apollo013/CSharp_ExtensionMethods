using System.Security;

namespace CSharpExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts plain string to secure string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static SecureString ToSecureString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            SecureString ss = new SecureString();
            foreach (char c in str.ToCharArray())
            {
                ss.AppendChar(c);
            }
            return ss;
        }
    }
}

namespace HidePDF
{
    public static class CesarCifre
    {
        public static string Encrypt(this string message, int shift = 5)
        {
            string newMessage = string.Empty;

            foreach (char c in message)
            {
                char newChar = (char)(((byte)c) + ((byte)shift));

                newMessage += newChar;
            }

            return newMessage;
        }

        public static string Dencrypt(this string message, int shift = 5)
        {
            string newMessage = string.Empty;

            foreach (char c in message)
            {
                char newChar = (char)(((byte)c) - ((byte)shift));

                newMessage += newChar;
            }

            return newMessage;
        }
    }
}

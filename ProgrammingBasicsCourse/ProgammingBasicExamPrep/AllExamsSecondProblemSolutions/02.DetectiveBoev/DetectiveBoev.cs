using System;
using System.Text;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        int mask = 0;

        foreach (var symbol in secretWord)
        {
            mask += symbol;
        }

        while (mask > 9)
        {
            int sum = 0;

            while (mask != 0)
            {
                int remainder = mask % 10;
                mask = mask / 10;
                sum = sum + remainder;
            }

            mask = sum;
        }

        byte[] encryptedMessageArray = Encoding.ASCII.GetBytes(encryptedMessage);


        for (int i = 0; i < encryptedMessageArray.Length; i++)
        {
            if (encryptedMessageArray[i] % mask == 0)
            {
                encryptedMessageArray[i] += (byte)mask;
            }
            else
            {
                encryptedMessageArray[i] -= (byte)mask;
            }
        }

        string encryptedMessageReversed = Encoding.ASCII.GetString(encryptedMessageArray, 0, encryptedMessageArray.Length);
        char[] resultReversed = encryptedMessageReversed.ToCharArray();
        Array.Reverse(resultReversed);
        string result = new string(resultReversed);

        Console.WriteLine(result);
    }
}
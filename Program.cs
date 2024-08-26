// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


            Console.Write("Enter a number between 0 and 999: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Please enter a number between 0 and 999.");
            return;
        }

        string words = ConvertToWords(number);
        Console.WriteLine(words);

    static string ConvertToWords(int number)
    {
        string words = "";

        if (number == 0)
        {
            return "Zero";
        }

        // Hundreds
        if (number >= 100)
        {
            switch (number / 100)
            {
                case 1: words += "One hundred"; break;
                case 2: words += "Two hundred"; break;
                case 3: words += "Three hundred"; break;
                case 4: words += "Four hundred"; break;
                case 5: words += "Five hundred"; break;
                case 6: words += "Six hundred"; break;
                case 7: words += "Seven hundred"; break;
                case 8: words += "Eight hundred"; break;
                case 9: words += "Nine hundred"; break;
            }
            number %= 100;
            if (number > 0) words += " and ";
        }

        // Tens and Units
        if (number >= 20)
        {
            switch (number / 10)
            {
                case 2: words += "Twenty"; break;
                case 3: words += "Thirty"; break;
                case 4: words += "Forty"; break;
                case 5: words += "Fifty"; break;
                case 6: words += "Sixty"; break;
                case 7: words += "Seventy"; break;
                case 8: words += "Eighty"; break;
                case 9: words += "Ninety"; break;
            }
            number %= 10;
            if (number > 0) words += " ";
        }
        else if (number >= 10)
        {
            switch (number)
            {
                case 10: return words + "Ten";
                case 11: return words + "Eleven";
                case 12: return words + "Twelve";
                case 13: return words + "Thirteen";
                case 14: return words + "Fourteen";
                case 15: return words + "Fifteen";
                case 16: return words + "Sixteen";
                case 17: return words + "Seventeen";
                case 18: return words + "Eighteen";
                case 19: return words + "Nineteen";
            }
        }

        // Units
        switch (number)
        {
            case 1: words += "One"; break;
            case 2: words += "Two"; break;
            case 3: words += "Three"; break;
            case 4: words += "Four"; break;
            case 5: words += "Five"; break;
            case 6: words += "Six"; break;
            case 7: words += "Seven"; break;
            case 8: words += "Eight"; break;
            case 9: words += "Nine"; break;
        }

        return words;
    }
// }


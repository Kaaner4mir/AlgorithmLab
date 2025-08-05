class Program
{
    public static void Main()
    {
        #region 1’den N’ye kadar sayıları yazdırın ve ardından ters sırada yazdırın.  

        //Console.Write("Lütfen bir tam sayı giriniz: ");
        //int inputVal = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i < inputVal + 1; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //for (int i = inputVal; i > 0; i--)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion
        #region Verilen bir tamsayı N’in asal olup olmadığını kontrol edin. 

        //Console.Write("Asal olup olmadığını kontrol etmek istediğiniz bir tam sayı giriniz: ");
        //int inputVal = Convert.ToInt32(Console.ReadLine());

        //bool isPrimeNumber = true;

        //if (inputVal < 2)
        //{
        //    isPrimeNumber = false;
        //}
        //else
        //{
        //    for (int i = 2; i <= Math.Sqrt(inputVal); i++)
        //    {
        //        if (inputVal % i == 0)
        //        {
        //            isPrimeNumber &= false;
        //            break;
        //        }
        //    }
        //}

        //if (isPrimeNumber)
        //{
        //    Console.WriteLine("Girmiş olduğunuz sayı ASAL SAYIDIR.");
        //}
        //else
        //{
        //    Console.WriteLine("Girmiş olduğunuz sayı ASAL SAYI DEĞİLDİR.");
        //}

        #endregion
        #region Verilen bir tamsayının basamakları toplamını hesaplayın.  

        //Console.Write("Lütfen bir tam sayı giriniz: ");
        //int inputVal = Convert.ToInt32(Console.ReadLine());

        //int total = 0;
        //int temporaryNumber = Math.Abs(inputVal);

        //while (temporaryNumber > 0)
        //{
        //    total += temporaryNumber % 10;
        //    temporaryNumber /= 10;
        //}

        //Console.WriteLine($"\nGirilen tam sayının basamakları toplamı :{total}");

        #endregion
        #region Verilen bir dizgenin palindrome olup olmadığını belirleyin (büyük/küçük harf ve alfanümerik olmayan karakterleri göz ardı edin).  

        //Console.Write("Palindrom olup olmadığını kontrol etmek istediğiniz kelimeyi giriniz: ");
        //string? text = Console.ReadLine();

        //var cleaned = new string(text.Where(char.IsLetterOrDigit)
        //                             .Select(char.ToLower)
        //                             .ToArray());

        //var reversed = new string(cleaned.Reverse().ToArray());

        //if (cleaned == reversed)
        //    Console.WriteLine("\nGirmiş olduğunuz metin palindromedur.");
        //else
        //    Console.WriteLine("\nGirmiş olduğunuz metin palindrome değildir.");

        #endregion
        #region Bir tamsayı dizisindeki en büyük ve en küçük değeri bulun.  

        //int[] numbers = { 354, 615, 135, 15, 4, 34, 368, 413, 8, 13, 48, 87, };

        //int maxVal = numbers.Max();
        //int minVal = numbers.Min();

        //Console.WriteLine($"Tam sayı dizinisdeki en büyük ve en küçük değer sırasyıla {maxVal} ve {minVal}.");

        #endregion
        Console.ReadLine();
    }
}
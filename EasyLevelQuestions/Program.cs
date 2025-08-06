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
        #region Negatif olmayan bir tamsayının faktöriyelini hesaplayın.  

        //Console.Write("Faktöriyelini öğrenmek istediğiniz sayıyı giriniz: ");
        //int inputVal=Convert.ToInt32(Console.ReadLine());

        //int result = 1;

        //if (inputVal < 0)
        //    Console.WriteLine("\nGirmiş olduğunuz sayı geçerli değildir");
        //else
        //    for (int i = inputVal; i > 0; i--)
        //        result *= i;

        //Console.WriteLine($"\nGirmiş olduğunuz sayının faktöriyeli: {result}");

        #endregion
        #region Bir tamsayı dizisinde yinelenen (duplicate) eleman olup olmadığını kontrol edin. 

        //int[] numbers = { 1, 2, 3, 4, 2 };

        //bool repeatingNumber = numbers.Distinct().Count() != numbers.Length;

        //Console.WriteLine(repeatingNumber); 


        #endregion
        #region Verilen bir dizgedeki sesli harflerin (a, e, ı, i, o, ö, u, ü) sayısını bulun.  

        //Console.Write("Lütfen sesli harfleri kontrol etmek istediğiniz metni giriniz: ");
        //string? text = Console.ReadLine();

        //int vowelCounter = 0;

        //char[] vowels = {'A','E','I','İ','O','Ö','U','Ü',
        //                 'a','e','ı','i','o','ö','u','ü'};

        //foreach (var item in text)
        //{
        //    if (vowels.Contains(item))
        //        vowelCounter++;
        //}

        //Console.WriteLine($"Girilen metindeki sesli harf sayısı: {vowelCounter}");

        #endregion
        #region Yerleşik ters çevirme (Reverse) yöntemlerini kullanmadan bir dizgeyi tersine döndürün.

        //Console.Write("Ters çevirmek istediğiniz metni girin: ");
        //string? text = Console.ReadLine();

        //string reversed = "";

        //for (int i = text.Length - 1; i >= 0; i--)
        //{
        //    reversed += text[i];  
        //}

        //Console.WriteLine("Ters çevrilmiş hali: " + reversed);

        #endregion
        #region 1’den N’ye kadar sayıları yazdırın; 3’ün katları için “Fizz”, 5’in katları için “Buzz”, her ikisinin katıysa “FizzBuzz” yazdırın.  

        //Console.Write("Tavan sayıyı giriniz: ");
        //int maxVal = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i <= maxVal; i++)
        //{
        //    if (i % 15 == 0)
        //        Console.WriteLine("FizzBuzz");
        //    else if (i % 3 == 0)
        //        Console.WriteLine("Fizz");
        //    else if (i % 5 == 0)
        //        Console.WriteLine("Buzz");
        //    else
        //        Console.WriteLine(i);
        //}

        #endregion

        Console.ReadLine();
    }
}
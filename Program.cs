namespace progralamatemelleri.odev._2
{
    
    
        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Başlangıç sayısını seçiniz : ");
                    byte first = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Bitiş sayısını seçiniz : ");
                    byte last = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Kaç adet sayı istiyorsunuz : ");
                    byte numbers = byte.Parse(Console.ReadLine());

                    Random rnd = new Random();
                    int[] ints = new int[numbers];
                    int number;
                    for (int i = 0; i < ints.Length; i++)
                    {
                        number = rnd.Next(first, last);
                        if (i == 0)
                        {
                            ints[i] = number;
                        }

                        for (int j = 0; j < i; j++)
                        {
                            if (ints[j] == number)
                            {
                                i--;
                                break;
                            }
                            else
                            {
                                ints[i] = number;
                            }
                        }
                    }
                    Array.Sort(ints);
                    for (int i = 0; i < ints.Length; i++)
                    {
                        Console.WriteLine(ints[i]);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Lütfen 0-255 arası bir değer giriniz!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen sayıları rakam ile giriniz!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bilinmeyen bir hata oluştu programcı ile bağlantı kurunuz! \nDate:{DateTime.Now} \nMessage: {ex.Message} \nDetail: {ex.StackTrace}");
                }
            }
        }
    
}
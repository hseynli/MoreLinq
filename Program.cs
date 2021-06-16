using System;
using MoreLinq;
using MoreLinq.Extensions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MoreLinqExamples;

namespace MoreLinq
{
    class Program
    {
        static void Main(string[] args)
        {


            //------------------------------------------APPEND---------------------------------------------------------------------------------------
            string[] fruits = { "apple", "banana", "orange", "cheryy", "apricot" };

            IEnumerable<string> result1 = fruits.RandomSubset(3);


            //Console.WriteLine(result1.ToDelimitedString(","));



            Implementator implementator = new Implementator();
            string methodName = "";


            switch (methodName)
            {
                case "AtLeast":
                    //Bu metod hər-hansı kolleksiyadakı elementlərin sayını yoxlamağa imkan verir.
                    //Yoxlayır ki, kolleksiyada ən azı neçə element olmalıdır. Məsələn, AtLeast(3) yoxlayır ki, kolleksiyada ən azı 3 element olmalıdır.
                    implementator.ImplementAtLeast();
                    break;
                case "AtMost":
                    //Bu metod hər-hansı kolleksiyadakı elementlərin sayını yoxlamağa imkan verir.
                    //Yoxlayır ki, kolleksiyada ən çox neçə element ola bilər. Məsələn, AtLeast(10) yoxlayır ki, kolleksiyada ən çoxu 10 element ola bilər.
                    implementator.ImplementAtMost();
                    break;
                case "Backsert":
                    //Bu metod hər-hansı kolleksiayanın sonuna digər kolleksiyanı əlavə etməyə imkan verir. Backsert(numbers2, 1) -> İkinci arqument sondan neçə elementin buraxılmasını göstərir.
                    implementator.ImplementBacksert();
                    break;
                case "Batch":
                    //Bu metod hər-hansı kolleksiayanın hissələrə bölməyə imkan verir.
                    implementator.ImplementBatch();
                    break;
                case "Choose":
                    //Bu metod hər-hansı kolleksiyada şərt əsasında elementləri seçməyə imkan verir.
                    implementator.ImplementChoose();
                    break;
                case "CompareCount":
                    //Bu metod iki kolleksiyda olan element sayını müqayisə edir. Əgər say eynidirsə, 0, əgər birinci kolleksiyada element çoxdursa 1, əks halda -1 qaytarır.
                    implementator.ImplementCompareCount();
                    break;
                case "CountBetween":
                    //Verilən kolleksiyadakı elementlərin sayını metodda göstərilən araqlıqda olmasını yoxlayır. CountBetween(5, 6) -> tutaq ki, 6 ölçülü massiv varsa,
                    //onda bu metod true qaytaracaq, çünki massivdəki element sayı (6) qeyd edilən aralığa [5, 6] uyğun gəlir. CountBetween(7, 100) false qaytaracaq,
                    //çünki 6 ölçülü massivin element sayı (6) [7, 100] aralığına düşmür.
                    implementator.ImplementCountBetween();
                    break;
                case "CountBy":
                    //*Verilən kolleksiyada hansı elementdən neçə dənə olduğunu key-value vasitəsilə geriya qaytarır.
                    implementator.ImplementCountBy();
                    break;
                case "CountDown":
                    //Verilən kolleksiyada sondan n sayda elementi götürmək üçün istifadə olunur. İkinci element indeksi müəyyən edir.
                    implementator.ImplementCountDown();
                    break;
                case "*DistinctBy":
                    //Verilən kolleksiyanı şərt əsasında sort etməyə imkan verir. Adi Distinct() metodunda arqumentə şərt vermək olmur
                    implementator.ImplementDistinctBy();
                    break;
                case "EndsWith":
                    //Hər hansı kolleksiyanın digər kolleksiyaya uyğun bitməsini yoxlayır. Boolean qaytarır.
                    implementator.ImplementEndsWith();
                    break;
                case "StartsWith":
                    //Hər hansı kolleksiyanın digər kolleksiyaya uyğun başlanılmasını yoxlayır. Boolean qaytarır.
                    implementator.ImplementEndsWith();
                    break;
                case "EquiZip":
                    //İki massivi birləşdirməyə imkan verir. Hər iki massivin ölçüsü eyni olmalıdır.
                    implementator.ImplementEquiZip();
                    break;
                case "ZipLongest":
                    //İki massivi birləşdirməyə imkan verir. Hər iki massivin ölçüsü eyni olmasa da olar.
                    implementator.ImplementZipLongest();
                    break;
                case "ZipShortest":
                    //Massivləri birləşdirməyə imkan verir. Hansı massivin ölçüsü ən azdırsa, ona uyğun birşləşmə gedəcək.
                    implementator.ImplementZipShortest();
                    break;

                case "":
                    implementator.Implement_();
                    break;
            }

            Console.ReadKey();
        }
    }

    class Implementator
    {
        public void ImplementAtLeast()
        {
            int[] numbers = new[] { 123, 456, 789 };
            bool result = numbers.AtLeast(2);
            Console.WriteLine(result);
        }

        public void ImplementAtMost()
        {
            int[] numbers = new[] { 123, 456, 789 };
            bool result = numbers.AtMost(10);
            Console.WriteLine(result);
        }

        public void ImplementBacksert()
        {
            int[] numbers = { 123, 456, 789 };
            int[] numbers2 = { 1, 2, 3, 4 };
            IEnumerable<int> result = numbers.Backsert(numbers2, 1);
            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementBatch()
        {
            int[] numbers = { 123, 456, 789, 1, 2, 3, 10, 20, 30, 5 };

            List<IEnumerable<int>> result = numbers.Batch(3).ToList();

            string slice = string.Empty;

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count(); j++)
                {
                    slice += result[i].ToArray()[j] + ",";
                }
                Console.WriteLine(slice.Trim(','));
                slice = string.Empty;
            }
        }

        public void ImplementChoose()
        {
            var str = "O,l,2,3,4,S,6,7,B,9";
            var result = str.Split(',').Choose(s => (int.TryParse(s, out var n), n));

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementCompareCount()
        {
            int[] first = new[] { 123, 456, 12, 34, 55 };
            int[] second = new[] { 789, 222 };
            int result = first.CompareCount(second);
            Console.WriteLine(result);
        }

        public void ImplementCountBetween()
        {
            var numbers = new[] { 123, 456, 789, 12, 55, 110 };
            var result = numbers.CountBetween(7, 100);
            Console.WriteLine(result);
        }

        public void ImplementCountBy()
        {
            var numbers = new[] { 123, 456, 789, 12, 55, 110, 12, 12 };
            IEnumerable<KeyValuePair<int, int>> result = numbers.Where(p => p < 200).CountBy(i => i);

            foreach (KeyValuePair<int, int> item in result)
            {
                Console.WriteLine($"Value: {item.Value}\t Key: {item.Key}");
            }
        }

        public void ImplementCountDown()
        {
            int[] numbers = new[] { 123, 456, 789, 12, 55, 110, 12, 12 };

            IEnumerable<(int, int?)> result = numbers.CountDown(5, (p, k) => { return (p, k); });

            var result2 = result.Where(p => p.Item2 != null); //null qiymətlərin çıxarılması

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementDistinctBy()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "apricot" };

            var result = fruits.DistinctBy(p => p.Length);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementEndsWith()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot" };

            bool result = fruits.EndsWith(new string[] { "papaya", "apricot" }); //true qaytaracaq, çünki fruits massivinin sonuncu elementlər "papaya", "apricot"-dir.

            Console.WriteLine(result);
        }

        public void ImplementStartsWith()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot" };

            bool result = fruits.StartsWith(new string[] { "apple", "banana" }); //true qaytaracaq, çünki fruits massivinin birinci elementlər "papaya", "apricot"-dir.

            Console.WriteLine(result);
        }

        public void ImplementEquiZip()
        {
            int[] numbers = new[] { 1, 2, 3, 4 };
            string[] letters = new[] { "A", "B", "C", "D" };
            //var result = numbers.EquiZip(letters, (n, l) => (n, l));

            IEnumerable<string> result = numbers.EquiZip(letters, (n, l) => n + "!" + l);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementZipLongest()
        {
            var numbers = new[] { 1, 2, 3 };
            var letters = new[] { "A", "B", "C", "D", "D", "F" };

            IEnumerable<string> result = numbers.ZipLongest(letters, (n, l) => n + l);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementZipShortest()
        {
            var numbers = new[] { 1, 2, 3 };
            var letters = new[] { "A", "B", "C", "D" };
            var chars = new[] { 'a', 'b', 'c', 'd', 'e' };
            var flags = new[] { true, false };
            var zipped = numbers.ZipShortest(letters, chars, flags, (n, l, c, f) => n + l + c + f); //Burada massivlər iki dəfə birləşəcək, çünki ən az uzunluğu olan massivin ölçüsü 2-dir { true, false }.

            Console.WriteLine(zipped.ToDelimitedString(","));
        }

        public void Implement_()
        {
            int[] numbers = new[] { 1, 2, 3, 4 };
            string[] letters = new[] { "A", "B", "C", "D" };
            //var result = numbers.EquiZip(letters, (n, l) => (n, l));

            IEnumerable<string> result = numbers.EquiZip(letters, (n, l) => n + "!" + l);

            Console.WriteLine(result.ToDelimitedString(","));
        }
    }
}
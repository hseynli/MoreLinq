using System;
using MoreLinq;
using MoreLinq.Extensions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MoreLinqExamples;
using System.Data;

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
                case "Exclude":
                    //Massivin n-ci elementindən başalayaraq n sayda element xaric etməyə imkan verir.
                    implementator.ImplementExclude();
                    break;
                case "FallbackIfEmpty":
                    //Əgər şərtə uyğun məlumat tapılmasa, onda nəticəni default qiymətə mənimsətmək olar.
                    implementator.ImplementFallbackIfEmpty();
                    break;
                case "Generate":
                    //Şərtə uyğun random ədələr generasiya edir.
                    implementator.ImplementGenerate();
                    break;
                case "Index":
                    //*Ardıcıllığa indeks əlavə edir
                    implementator.ImplementIndex();
                    break;
                case "MaxByMinBy":
                    //Verilmiş şərtə uyğun ən kiçik və ən böyük elementləri tapır. LINQ-də olan Min və Max metodlarından fərqli olaraq kolleksiya qayatarır.
                    implementator.ImplementMaxByAndMinBy();
                    break;
                case "PadAndPadStart":
                    //Hər-hansı kolleksiyanın sonuna və yə qabağına elementlər əlavə etməyə imkan verir.
                    implementator.ImplementPadAndPadStart();
                    break;
                case "PartialSort":
                    //Hər-hansı kolleksiyanın sort etməyə və sortdan sonra n sayda element götürmək üçün istifadə olunur.
                    implementator.ImplementPartialSort();
                    break;
                case "Partition":
                    //Hər-hansı kolleksiyanı iki hissəyə bölür, bir hissədə true olanlar, digər hissədə isə false olanlar yerləşir.
                    implementator.ImplementPartition();
                    break;
                case "RandomSubset":
                    //Hər-hansı kolleksiyadan n sayda təsadüfi olaraq element götürür.
                    implementator.ImplementRandomSubset();
                    break;
                case "Shuffle":
                    //Hər-hansı kolleksiyadan təsadüfi şəkildə qarışdırır.
                    implementator.ImplementShuffle();
                    break;
                case "Sequence":
                    //n addım əsasında ardıcıllıq yaradır.
                    implementator.ImplementSequence();
                    break;
                case "ToDelimitedString":
                    //Kolleksiyanı verilən ayırıcı əsasında string-ə çevirir.
                    implementator.ImplementToDelimitedString();
                    break;
                case "ToDataTable":
                    //Kolleksiyanı DataTable-ə çevirir.
                    implementator.ImplementToDataTable();
                    break;
                case "TakeEvery":
                    //Hər n addımdan bir elementləri götürür.
                    implementator.ImplementTakeEvery();
                    break;
                case "TakeLast":
                    //Sonuncu n elementi götürür.
                    implementator.ImplementTakeLast();
                    break;

                case "":
                    implementator.Implement();
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

        public void ImplementExclude()
        {
            var numbers = new[] { 123, 456, 789, 1, 2, 3, 40, 77 };
            IEnumerable<int> result = numbers.Exclude(0, 4);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementFallbackIfEmpty()
        {
            var numbers = new[] { 123, 456, 789 };
            var result = numbers.Where(x => x == 100).FallbackIfEmpty(666).Single();

            Console.WriteLine(result);
        }

        public void ImplementGenerate()
        {
            IEnumerable<long> result = MoreEnumerable.Generate<long>(2, n => n + n).Take(10);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementIndex()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot" };

            var result = fruits.Index();

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementMaxByAndMinBy()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            var result = fruits.MaxBy(p => p.Length);
            var result2 = fruits.MinBy(p => p.Length);

            Console.WriteLine(result.ToDelimitedString(","));
            Console.WriteLine(result2.ToDelimitedString(","));
        }

        public void ImplementPadAndPadStart()
        {
            int[] numbers = { 123, 456, 789 };

            var pad = numbers.Pad(5);
            var padStart = numbers.PadStart(5);

            Console.WriteLine(pad.ToDelimitedString(","));
            Console.WriteLine(padStart.ToDelimitedString(","));
        }

        public void ImplementPartialSort()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            var result = fruits.PartialSort(fruits.Where(p => p.StartsWith("a")).Count());

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementPartition()
        {
            var (evens, odds) = Enumerable.Range(0, 10).Partition(x => x % 2 == 0);

            Console.WriteLine(evens.ToDelimitedString(","));
            Console.WriteLine(odds.ToDelimitedString(","));
        }

        public void ImplementRandomSubset()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = values.RandomSubset(2);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementShuffle()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            var result = fruits.Take(5).Shuffle();

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementSequence()
        {
            var result = MoreEnumerable.Sequence(0, 10, 3);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementToDelimitedString()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "blueberry", "apricot", "armud" };

            Console.WriteLine(fruits.ToDelimitedString(","));
        }

        public void ImplementToDataTable()
        {
            List<Person> people = RandData.GetRandomPeople("en");

            DataTable table = people.ToDataTable();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Console.Write(table.Rows[i][j] + ",");
                }
                Console.WriteLine();
            }
        }

        public void ImplementTakeEvery()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            string[] result = fruits.TakeEvery(2).ToArray();

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void ImplementTakeLast()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            var result = fruits.TakeLast(2);

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void Implement()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            var result = fruits.PartialSort(fruits.Where(p => p.StartsWith("a")).Count());

            Console.WriteLine(result.ToDelimitedString(","));
        }

        public void Implement_()
        {
            string[] fruits = { "apple", "banana", "orange", "cheryy", "papaya", "apricot", "apricot", "armud" };

            var result = fruits.PartialSort(fruits.Where(p => p.StartsWith("a")).Count());

            Console.WriteLine(result.ToDelimitedString(","));
        }
    }
}
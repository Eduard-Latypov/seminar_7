// Учитывая строку слов, вам нужно найти слово с наивысшим баллом. Каждая буква слова оценивается в зависимости от ее положения в алфавите: a = 1, b = 2, c = 3 и т. д. Вам нужно вернуть слово с наивысшим баллом в виде строки. Если два слова оцениваются одинаково, верните слово, которое появляется первым в исходной строке. Все буквы будут строчными, и все входные данные будут действительными.


// string High(string s)
// {
//     string[] words = s.Split();
//     string abc = "abcdefghijklmnopqrstuvwxyz";
//     int[] arr = { };
//     int count = 0;
//     for (int i = 0; i < words.Length; i++)
//     {
//         count = 0;
//         for (int j = 0; j < words[i].Length; j++)
//         {
//             count = count + (1 + abc.IndexOf(Convert.ToString(words[i][j])));
//         }
//         arr = arr.Append(count).ToArray();
//     }
//     return words[Array.IndexOf(arr, arr.Max())];

// }


// string text = High("what time are we climbing up to the volcano");
// System.Console.WriteLine(text);


// Console.Clear();
// System.Console.WriteLine("Введите длину массива");
// int num = int.Parse(Console.ReadLine());
// int[] array = new int[num];
// int count = 0;
// int number = 0;
// for (int i = 0; i < num; i++)
// {
//     System.Console.WriteLine("Введите очередное число");
//     number = int.Parse(Console.ReadLine());
//     if (number > 0)
//         count += 1;
//     array[i] = number;
// }

// System.Console.WriteLine($"[{String.Join(", ", array)}]");
// System.Console.WriteLine($"Количество положительных чисел {count}");






// int num = 10;
// int number = 20;
// string text = "badri";
// System.Console.WriteLine(text + num + "raz reshil zadachu iz" + number + "urokov");
// System.Console.WriteLine($"{text} {num} raz reshil zadachu iz {number} urokov");


// int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

// foreach (var item in arr)
// {
//     System.Console.Write(item + ", ");
// }

// System.Console.WriteLine();

// System.Console.WriteLine(String.Join(", ", arr));


// string text = "badri sovsem ne ponimayet chto proishodit";
// string[] text_arr = text.Split();
// string new_text = String.Join(" ", text_arr);
// System.Console.WriteLine(new_text);
//string new_new_text = new string(text_arr);
//System.Console.WriteLine(new_new_text);

// char[] chr = { 'b', 'a', 'd', 'r', 'i' };
// string badri = new string(chr);
// System.Console.WriteLine(badri);



// Учитывая массив (arr) в качестве аргумента, завершите функцию countSmileys, которая должна вернуть общее количество улыбающихся лиц. Правила улыбающегося лица: Каждый смайлик должен содержать допустимую пару глаз. Глаза могут быть отмечены как : или ; У смайлика может быть нос, но не обязательно. Допустимые символы для носа - или ~ Каждое улыбающееся лицо должно иметь улыбающийся рот, который должен быть отмечен знаком ) или D. Не допускается использование дополнительных символов, кроме упомянутых. Допустимые примеры смайлов: :) :D ;-D :~) Недопустимые смайлики: ;( :> :} :]


// int CountSmileys(string[] smileys)
// {
//     string smile = ":) :~) ;) ;~) ;-) :-) :-D :D ;-D ;D ;~D :~D";
//     string[] smile_arr = smile.Split();
//     int count = 0;
//     foreach (var item in smileys)
//     {
//         foreach (var items in smile_arr)
//         {
//             if (item == items)
//                 count += 1;
//         }
//     }
//     return count;
// }


// string[] arr = { ";", ")", ";*", ":$", "8-D" };
// System.Console.WriteLine(CountSmileys(arr));



// Напишите простой метод .camelCase (функция camel_case в PHP, CamelCase в C# или camelCase в Java) для строк. Во всех словах первая буква должна быть заглавной без пробелов. Например: camelCase("Привет, кейс"); // => "HelloCase" camelCase("Слово в верблюжьем регистре"); // => "CamelCaseWord"




// string CamelCase(string str)
// {
//     string[] str_arr = str.Trim().Split(" ");
//     string text = String.Empty;
//     for (int i = 0; i < str_arr.Length; i++)
//     {
//         if (str_arr[i].Length > 1)
//             text = text + (str_arr[i][0].ToString().ToUpper() + str_arr[i][1..].ToString().ToLower());
//         else
//             text = text + str_arr[i].ToString().ToUpper();
//     }
//     return text;
// }


// string word = "xufwrt muhbyi zla b wbax llbqktkbv";
// System.Console.WriteLine(CamelCase(word));


// int[] nums = { 11, 21, 32, 43, 15321, 163434, 172321 };
// int[] rev_nums = nums.Reverse().ToArray();
// foreach (var item in rev_nums)
// {
//     System.Console.Write(item + " ");
// }
// System.Console.WriteLine();
// nums = nums.Append(8).ToArray();
// foreach (var item in nums)
// {
//     System.Console.Write(item + " ");
// }
// System.Console.WriteLine();
// int[] new_nums = nums.Where(i => i % 2 == 0).ToArray();
// foreach (var item in new_nums)
// {
//     System.Console.Write(item + " ");
// }
// System.Console.WriteLine();
// int result = nums.Where(i => i % 2 == 1).Sum();
// System.Console.WriteLine(result);

// int[] strange_nums = nums.Where(i => Convert.ToString(i)[0] == '1').ToArray();
// foreach (var item in strange_nums)
// {
//     System.Console.Write(item + " ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine(strange_nums.Sum());

// int[] arr = nums[..5].Reverse().ToArray();
// foreach (var item in arr)
// {
//     System.Console.Write(item + " ");
// }
// System.Console.WriteLine();

// int[] new_arr = nums.OrderByDescending(i => i % 2 == 1).ToArray();
// foreach (var item in new_arr)
// {
//     System.Console.Write(item + " ");
// }

// System.Console.WriteLine();
// int[] new_new_arr = nums.OrderBy(i => i).ToArray();
// foreach (var item in new_new_arr)
// {
//     System.Console.Write(item + " ");
// }
// System.Console.WriteLine();
// string[] words = { "ww", "b", "ccc", "z", "aa" };
// string[] new_words = words.OrderBy(i => i.Length).ToArray();
// System.Console.WriteLine($"{String.Join(", ", new_words)}");
// string[] new_new_words = words.OrderBy(i => i).ToArray();
// System.Console.WriteLine($"{String.Join(", ", new_new_words)}");


// string text = "hello world";
// char[] chr_arr = { };
// for (int i = 0; i < text.Split().Length; i++)
// {
//     for (int j = 0; j < text.Split()[i].Length; j++)
//     {
//         chr_arr = chr_arr.Append(Convert.ToChar(text.Split()[i][j])).ToArray();
//     }
// }
// System.Console.WriteLine($"{String.Join(", ", chr_arr)}");




// int[] numbers = new int[count];
// int A = Convert.ToInt32(input);
// Console.WriteLine(A);
// for (int i = 0; i < numbers.Length; i++)
//     if (A > 0)
//     {
//         int b = A % 10;
//         numbers[numbers.Length - 1 - i] = b;
//     }
//     else
//         break;

// return numbers;




// Волна (известная как мексиканская волна в англоязычном мире за пределами Северной Америки) является примером метахронного ритма, достигаемого на переполненном стадионе, когда последовательные группы зрителей ненадолго встают, кричат ​​и поднимают руки. Сразу после вытягивания в полный рост зритель возвращается в обычное сидячее положение.

// В результате волна стоящих зрителей проходит сквозь толпу, хотя отдельные зрители никогда не отходят от своих мест. На многих больших аренах толпа рассаживается по непрерывному кругу по всему спортивному полю, поэтому волна может непрерывно перемещаться по арене; при несмежном расположении сидений волна может вместо этого отражаться взад и вперед через толпу. Когда щель в посадке узкая, волна иногда может проходить через нее. Обычно на арене в любой момент времени присутствует только один гребень волны, хотя иногда возникают одновременные волны, вращающиеся в противоположных направлениях. (Источник Википедия)
// В этой простой ката ваша задача — создать функцию, которая превращает строку в мексиканскую волну. Вам будет передана строка, и вы должны вернуть эту строку в виде массива, где заглавная буква означает стоящего человека.
// 1. Строка ввода всегда будет в нижнем регистре, но может быть и пустой.
//  2. Если символ в строке является пробелом, пропустите его, как если бы это было пустое место.
// Example: wave("hello") => {"Hello", "hEllo", "heLlo", "helLo", "hellO"}
//{"Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS"}


// string[] wave(string str)
// {
//     string[] str_arr = { };
//     str = str.Trim().ToLower();
//     if (str.Length == 0)
//         return str_arr;
//     else
//     {
//         int num = str.Length;
//         for (int i = 0; i < num; i++)
//         {
//             if (str[i] == ' ')
//                 continue;
//             else
//             {
//                 string chr = str[i].ToString();
//                 str = str.Remove(i, 1);
//                 str = str.Insert(i, chr.ToUpper());
//                 str_arr = str_arr.Append(str).ToArray();
//                 str = str.ToLower();
//             }
//         }
//     }
//     return str_arr;

// }

// string word = "hello world";
// string[] array = wave(word);
// System.Console.WriteLine(String.Join(", ", array));


// char[] chrs = { 'w', 'o', 'r', 'l', 'd' };
// string text = String.Empty;
// for (int i = 0; i < chrs.Length; i++)
// {
//     text += new String(chrs[i], (i + 1));
// }

// System.Console.WriteLine(text);


// int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
// System.Console.WriteLine(Array.IndexOf(nums, nums.Max()));



// Цель этого упражнения — преобразовать строку в новую строку, где каждый символ в новой строке — это «(», если этот символ встречается в исходной строке только один раз, или «)», если этот символ встречается в исходной строке более одного раза. нить. Игнорировать заглавные буквы при определении, является ли символ дубликатом.
// Examples

// "din"      =>  "((("
// "recede"   =>  "()()()"
// "Success"  =>  ")())())"
// "(( @"     =>  "))((" 


// string DuplicateEncode(string word)
// {
//     word = word.ToLower();
//     string text = String.Empty;
//     for (int i = 0; i < word.Length; i++)
//     {
//         if (word.IndexOf(word[i]) == word.LastIndexOf(word[i]))
//             text += "(";
//         else
//             text += ")";
//     }
//     return text;
// }

// string word = "(( @";
// System.Console.WriteLine(DuplicateEncode(word));


// Вы живете в городе Картезия, где все дороги выложены идеальной сеткой. Вы пришли на встречу на десять минут раньше назначенного срока, поэтому решили воспользоваться возможностью прогуляться. Город предоставляет своим горожанам приложение Walk Generating на их телефонах — каждый раз, когда вы нажимаете кнопку, оно отправляет вам массив строк из одной буквы, представляющих направления ходьбы (например, ['n', 's', 'w', «е»]). Вы всегда проходите только один квартал для каждой буквы (направления), и вы знаете, что вам потребуется одна минута, чтобы пройти один городской квартал, поэтому создайте функцию, которая будет возвращать true, если прогулка, которую предлагает вам приложение, займет у вас ровно десять минут (вы не хочу ни рано, ни поздно!) и, конечно же, вернет вас в исходную точку. В противном случае верните false.

// Примечание: вы всегда будете получать допустимый массив, содержащий случайный набор букв направления (только «n», «s», «e» или «w»). Он никогда не даст вам пустой массив (это не прогулка, это стояние на месте!).


// bool IsValidWalk(string[] walk)
// {
//     int north = 0;
//     int west = 0;
//     if (walk.Length != 10)
//         return false;
//     foreach (var item in walk)
//     {
//         if (item == "n") north++;
//         else if (item == "s") north--;
//         else if (item == "w") west++;
//         else if (item == "e") west--;
//     }
//     return (north == 0 && west == 0);
// }


// string[] arr = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };
// System.Console.WriteLine(IsValidWalk(arr));




// Ребенок играет с мячом на n-м этаже высотного здания. Высота этого этажа над уровнем земли h известна.
// Он бросает мяч из окна. Мяч отскакивает (например) на две трети своей высоты (отскок 0,66).
// Его мать смотрит из окна в 1,5 метрах от земли.
// Сколько раз мать увидит, как мяч проходит перед ее окном (в том числе когда он падает и подпрыгивает?
// Для достоверности эксперимента должны быть соблюдены три условия:
// Плавающий параметр "h" в метрах должен быть больше 0
// Плавающий параметр "bounce" должен быть больше 0 и меньше 1
// Плавающий параметр "окно" должен быть меньше h.
// Если все три условия выше выполнены, вернуть положительное целое число, иначе вернуть -1.
// Примечание:
// Мяч можно увидеть только в том случае, если высота отскакивающего мяча строго больше параметра окна.
// - h = 3, bounce = 0.66, window = 1.5, result is 3

// - h = 3, bounce = 1, window = 1.5, result is -1 

// (Condition 2) not fulfilled).


// int bouncingBall(double h, double bounce, double window)
// {
//     if (h <= 0 && (bounce >= 1 || bounce <= 0) && window >= h)
//         return -1;
//     int result = 1;
//     h = h * bounce;
//     while (h > window)
//     {
//         result += 2;
//         h = h * bounce;
//     }
//     return result;
// }


// System.Console.WriteLine(bouncingBall(30.0, 0.66, 1.5));


// int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         System.Console.Write(arr[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }
// int num = arr.Rank;
// System.Console.WriteLine(num);


// Эта проблема получила свое название от, пожалуй, самого важного события в жизни древнего историка Иосифа Флавия: согласно его рассказу, он и его 40 солдат были заперты в пещере римлянами во время осады.
// Отказавшись сдаться врагу, они вместо этого выбрали массовое самоубийство с изюминкой: они образовали круг и продолжали убивать одного человека каждые три, пока не остался последний человек (и что он должен был убить себя, чтобы закончить действие). ).
// Что ж, Иосиф Флавий и еще один человек были последними двумя, и, поскольку мы теперь знаем каждую деталь этой истории, вы, возможно, правильно догадались, что они не совсем следовали первоначальной идее.
// Теперь вам нужно создать функцию, которая возвращает перестановку Иосифа Флавия, принимая в качестве параметров исходный массив/список элементов, подлежащих перестановке, как если бы они были в круге, и подсчитывая каждые k мест, пока не останется ни одного.
// Советы и примечания: помогает начать считать от 1 до n вместо обычного диапазона 0..n-1; k всегда 
//будет >=1.
//josephus([1, 2, 3, 4, 5, 6, 7],3) ==>  [3, 6, 2, 7, 5, 1, 4]
//{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, ==> { 2, 4, 6, 8, 10, 3, 7, 1, 9, 5 });


// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  // 2, 4, 6, 8, 10, 3, 7, 1, 9, 5

// int[] JosephusPermutation(int[] array, int k)
// {
//     int[] died_arr = { };
//     int index = 0;
//     while (array.Length != 0)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             index++;
//             if (index == k)
//             {
//                 died_arr = died_arr.Append(array[i]).ToArray();
//                 array = array[(i + 1)..].Union(array[..i]).ToArray();
//                 index = 0;
//                 break;
//             }
//         }
//     }
//     return died_arr;
// }

// int[] myArray = JosephusPermutation(arr, 2);
// System.Console.WriteLine(String.Join(", ", myArray));



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int m = inputNumber("Введите значение м: ");
int n = inputNumber("Введите значение n: ");
PrintArray(FillArray(m, n, out int result));
System.Console.WriteLine($"Cумма элементов по диагонали: {result}");


int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}


int[,] FillArray(int m, int n, out int result)
{
    result = 0;
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
            if (i == j)
                result += arr[i, j];
        }
    }
    return arr;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();

}





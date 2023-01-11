// //Масивы:
// int max1(int arg1, int arg2, int arg3)
// {
//     int res = arg1;
//     if(arg2 > res) res = arg2;
//     if(arg3 > res) res = arg3;
//     return res;
// }

// // Масив всегда равен 0  1  2  3  4  5  6  7  8  пример:
//        int[] mass = {11,21,31,41,15,61,17,18,19};
//        //mass[0] = 12;// первый 11, присваиваем массиву следующее число.
//        //Console.WriteLine(mass[4]);//Проверка каждого по отдельности.

//        int max = max1(
//            max1(mass[0], mass[1], mass[2]),
//            max1(mass[3], mass[4], mass[5]),
//            max1(mass[6], mass[7], mass[8]));
       
//        Console.WriteLine(max);

//Пример 2: 
//Масив со щотчиком.
// int[] mass = {1, 2, 21, 4, 15, 16, 19, 21};

// int n = mass.Length;
// int mass1 = 21;

// int ind = 0;

// while (ind < n)
// {
//     if(mass[ind] == mass1)
//     {
//         Console.WriteLine(ind);
//         break;   //Команда прервать, если в масиве два одинаковых элемента.
//     }
//     ind++;
// }

//Масив-Метод преобразование

Console.WriteLine("Hello, World!");
//методы:
//Метод 1
/*Console.WriteLine("Метод 1!");
void Met1(){   //Обявление метода.
    Console.WriteLine("Автор Иван! ");
}*/
/*Met1();  //Вызов метода. Вывод в консоль.

//Метод 2
Console.WriteLine("Метод 2!");
void Met2(string msg){ //Обявление.Принимает,Ничего не возвращает.
    Console.WriteLine(msg);
}
Met2("Текст сообщения! ");*/ //Вызов метода.Вывод в консоль.

//Пример 2
/*Console.WriteLine("Метод 1!");
void Met1(){   //Обявление метода.
    Console.WriteLine("Автор Иван! ");
}
Met1();*/  //Вызов метода. Вывод в консоль.

//Метод 2_1
/*Console.WriteLine("Метод 2_1!");
void Met2_1(string msg, int count){ //Обявление.Принимает,Ничего не возвращает.
    int i = 0;
    while (i < count){
        Console.WriteLine(msg);
        i++;
    }
    Console.WriteLine(msg); 
}
Met2_1("Текст сообщения! ", 4); //Вызов метода.Вывод в консоль.
Met2_1(count: 4, msg: "Новый текст сообщения! ");*/

//Метод 3
/*Console.WriteLine("Метод 3!");//Метод. Возвращает но не принимает.
int Met3(){  //Обявление.
    return DateTime.Now.Year;
}
int year = Met3();
Console.WriteLine(year);*/

//Метод 4
/*Console.WriteLine("Метод 4! ");//Метод.Принимает и возвращает.
string Met4(int count, string text){
    int i = 0;
    string res = String.Empty;//Присвоение пустой строки.

    while(i < count){
        res = res + text; 
        i++;
    }
    return res;
}
string res1 = Met4(10, "Иван! ");
Console.WriteLine(res1);*/

//Пример:
//Метод 4 и работа с циклом.
/*Console.WriteLine("Метод 4 с циклом! ");//Метод.Принимает и возвращает.
string Met4(int count, string text){
    
    string res = String.Empty;//Присвоение пустой строки.
    for(int i = 0; i < count; i++){ //Все циклы взаимозаменяемы.
        res = res + text; 
    }
    return res;
}
string res1 = Met4(10, "Иван! ");
Console.WriteLine(res1);*/

//Пример:
//Применение цикла в цикле.
/*Console.WriteLine("Применение Цикл в цикле! ");

for (int i = 2; i <= 10; i++){
    for (int j = 2; j <= 10; j++){
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();//Прерывание при выводе в консоль между строками.
}*/

//Пример:
//Задача.
//В тексте заменить пробелы черточками
//Маленькие буквы ()заменить большими
//Большие заменить()маленькими

//Console.WriteLine("Пример 1: Вставка между пробелом.");
// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

/*string Replace(string text, char oldValue, char newValue)
{
    string res = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++){
        if(text[i] == oldValue) res = res + $"{newValue}";
        else res = res + $"{text[i]}";
    }

    return res;//Возврат результата.
}
string newText = Replace(text, ' ', '/');
Console.WriteLine(newText);*/

/*Console.WriteLine("Пример 2: Работа с текстом.");

string Replace(string text, char oldValue, char newValue)
{
    string res = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++){
        if(text[i] == oldValue) res = res + $"{newValue}";
        else res = res + $"{text[i]}";
    }

    return res;//Возврат результата.
}
string newText = Replace(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);*/

//Упорядочить массив.
//Найти позицию минимального из массива
//Произвести обмен от меньшего к большему И.Т.Д.

Console.WriteLine("Упорядочить массив! ");

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void Print(int[] array){
    int count = array.Length;

    for (int i = 0; i < count; i++){
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void Sort(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++){
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
Print(arr);
Sort(arr);
Print(arr);


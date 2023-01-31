// Напишите программу, кооторая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.
Console.Clear();


// Задача 1
// int num = new Random().Next(10,100);
// Console.WriteLine($"Num = {num}");
// int num1=num/10;
// int num2=num%10;
// int max=num2;
// if(num1>num2){
//    max =num1;

// }
// Console.WriteLine($"Max = {max}");




// Задача 2
// Напишите программу, которая выводит случайное 
// трехзначчное число и удаляет вторую цифру этого числа.
// 456=>46


// int num=new Random().Next (100,1000);
// // Решили математическим путем
// int result = (num/100)*10+num%10; 

// Console.WriteLine($"Num = {num} -> {result}"); 
// // и не математическим->
// Console.WriteLine($"Num = {num} -> {num/100}{num%10}"); 

// Задача 3
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// 34,5-> не кратно, остаток 4
// 16,4 - > кратно

// Console.Write("Введите первое число: "); 
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: "); 
// int num2 = int.Parse(Console.ReadLine());
// int num3 = num1%num2;
// int num4=num1/num2;
// if (num3>0){
//   Console.Write($"Результат деления {num1} на {num2} не кратен, целое число {num4}, остаток {num3} ");}

//   else {Console.Write($"Результат деления {num1} на {num2} кратен и равен {num4}  ");
// }

// Задача 4 (14)
// Напишите прогармму, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 - > да

// Console.Write("Введите число: "); 
// int num1 = int.Parse(Console.ReadLine());

// if (num1%7==0 && num1%23==0 ){
//   Console.Write("Кратно одновременно");}

//   else {Console.Write("Не кратно одновременно");
// }

// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5,25 -> да
// -4, 16 - > да
// 8, 9 -> нет


// Console.Write("Введите первое число: "); 
// int num1 = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: "); 
// int num2 = int.Parse(Console.ReadLine());

// if (num1*num1==num2){
// Console.Write("Является");
// }
// else {
//   Console.Write("Не является"); 
// }


// Доп задача на определение монеток
// На столе лежат n монеток. Некоторые из них лежат вверх решкой,
// а некоторые - гербом. Определите минимальное число монеток, которые нужно перевернуть,
// чтоб все монетки были повернуты вверх одной и той же стороной.
// Console.Write("Введите кол-во элементов: ");
// int n int.Parse(Console.Readline();)
// int [] array1 = new int[n];
// for (int i = 0; i< n; i++){
//   array1[i] = new Random().Next(0,2);
// }
// Console.Write("Массив:");
// for (int i = 0; i< n; i++){
//   Console.Write($"{array1[i]}");
// }

// Задача 10:
// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: "); 
// int num1 = int.Parse(Console.ReadLine());

// if (num1>99 && num1<1000 ){
//   int num2=num1/10;
//   int num3=num2%10;
//   Console.WriteLine($"Вторая цифра числа {num1} равна {num3}"); 
// }
// else { Console.WriteLine("Введено не трехзначное число! "); 
// }





// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет


Console.Write("Введите трехзначное число: "); 
string num = Console.ReadLine ();
int num1=int.Parse (num);
if (99<num1 ){

string otvet2 = Convert.ToString(num [2]);
Console.WriteLine($"Третья цифра: {otvet2}");}
else { Console.WriteLine($"Третьей цифры в числе {num} нет! "); 
}


// Задача 15: Напишите программу которая на вход принимает цифру,
// обозначающую день недели и проверяет, является ли этот день выходным


// Console.Clear();
// Console.Write("Введите номер дня недели: ");
// int numberdayofweek = int.Parse(Console.ReadLine());
// if (numberdayofweek<1 || numberdayofweek>7)
// {
//   Console.WriteLine("Введен неправильный номер");
// return;}
// if (numberdayofweek==6 || numberdayofweek==7){

//   Console.WriteLine("Этот день выходной");}
// else {Console.WriteLine("Этот день не является выходным");}

  
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//Ввод данных:
// int a=5;
// int b=7;
// //Сравниваем два числа:
// if (a>b) {
//     Console.WriteLine (a);
// }
// else {
//     Console.WriteLine (b);
// }


// int a=2;
// int b=10;
// //Сравниваем два числа:
// if (a>b) {
//     Console.WriteLine (a);
// }
// else {
//     Console.WriteLine (b);
// }


// int a=-9;
// int b=-3;
// //Сравниваем два числа:
// if (a>b) {
//     Console.WriteLine (a);
// }
// else {
//     Console.WriteLine (b);
// }


// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Задаем данные: 
//int a=2;
// int b=3;
// int c=7;
// int max=0;
//Сравниваем 1-е число со 2-м, и если оно больше, то присваиваем ему значение мах.
// if (a>b){
//     max=a;
// }
// else {
//     max=b;
// }
//Сравниваем 3-е число с мах, которое нашли в предыдущем действии.
// if (c>max){
//     max=c;
// }
//Выводим на экран мах.
// Console.WriteLine (max);


// int a=44;
// int b=5;
// int c=78;
// int max=0;
// if (a>b){
//     max=a;
// }
// else {
//     max=b;
// }
// if (c>max){
//     max=c;
// }
// Console.WriteLine (max);


// int num1;
// int num2;
// int num3;
// int max=0;
// Console.Write ("Введите первое число: ");
// num1=Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите второе число: ");
// num2=Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите третье число: ");
// num3=Convert.ToInt32 (Console.ReadLine());

// if (num1>num2){
//     max=num1;
// }
// else {
//     max=num2;
// }
// if (num3>max){
//     max=num3;
// }
// Console.WriteLine ("Максимальное число: " +max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// int num;
// //Ввод данных:
// Console.Write ("Введите число: ");
// num=Convert.ToInt32 (Console.ReadLine());
// //Если наше число при делении на 2 имеет остаток 0, то число четное
// if ((num=num%2)==0) {
//     //Вывод на экран, то число четное
//     Console.WriteLine("Четное число ");
// }
// else {
//     //Иначе, вывод на экран число нечетное.
//     Console.WriteLine("Нечетное число ");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// int num;
// int res=1;
// Console.Write ("Введите число: ");
// num = Convert.ToInt32(Console.ReadLine());

// while (res <= num) {
// if (res % 2 == 0)
//      Console.Write(res + " ");
//      res++;
// }


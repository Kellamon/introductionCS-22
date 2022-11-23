// Массивы.
// Расчитать среднюю температуру за неделю.

// массивы это объекты
int N=7;
int[] t; //не присвоенное (null)
t=new int[N];//создаем массив. в t помещаем адрес массива
double s=0;
// заполнить массив
for(int i=0;i<7;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
//обработать массив
for (int i = 0; i < N; i++)
{
    s=s+t[i];
}
//вывод результата
System.Console.WriteLine(s/N);

// 31. Сгенерировать 10 случайных числе и показать кубы чисел, заканчивающихся на четную цифру.

/*
int r=10;
double t=r; не явное приведение типов
double x=23;
//int o=Convert.ToInt32(x); не явное приведение типов через подпрограмму
int o=(int) x; //явное приведение типов*/

bool Predicate(int a)
{
    // if (a%2==0) return true; else return false; вариант решения с проверкой на ложность
    return a*a*a%10%2==0; 
}

Random random=new Random(10); // для генерации постоянной последовательности указать число в скобках
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=a; //(int)Math.Pow(a,3); //Pow возведение в куб(3)
    if (Predicate(b))   //(b%10%2==0) вариант решения без подпрограммы Predicate
    {
      System.Console.WriteLine($"{a}, {b}");  
    }
}
 
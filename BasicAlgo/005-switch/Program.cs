// С клавиатуры вводится число - день недели. Определить день недели.

// goto metka1 оператора безусловного перехода не использующий вход и выход из программы. Использовать не рекомендуется, так как формирует много ошибок в большом коде.
int day = 1;

switch(day) // замена goto
{
    case 1: // разрешается использование условий типа >/<
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    default:
        System.Console.WriteLine("не правильный ввод");
        break;
}


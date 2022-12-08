// боремся с Null

// int? a = 0; равна записи Nullable<int> a=0;  и теперь a=null может быть присвоенно.
// Console.WriteLine(a.HasValue); позволяет проверить наличие значения а

int? Test()
{
    return null;
}
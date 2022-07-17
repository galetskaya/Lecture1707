//View 1

//Method with no return Void

void Method1()
{
    Console.WriteLine("Author: Someone");
}
//Method1();

//View2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "text of the message");


void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "new text", count: 4);


//View3 with return

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

//View4 with return
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
//string res = Method4(10, "abc");
//Console.WriteLine(res);

//View5 with return and cycle "for"
string Method5(int count, string c)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
// string res = Method5(10, "abc");
// Console.WriteLine(res);

//View6 cycle in the cycle

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
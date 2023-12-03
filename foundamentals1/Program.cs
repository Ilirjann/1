// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 1; i < 256; i++)
{
  System.Console.WriteLine(i);  
}
Random random = new Random();
 int nr = 0;
for (int i = 0; i < 6; i++)
{
    nr +=random.Next(10,20);
}
System.Console.WriteLine(nr);
for (int i = 1; i < 100; i++)
{
if ((i%3==0 || i%5==0) && !(i %3==0 && i % 5==0))
 System.Console.WriteLine(i);
}
for (int i = 0; i < 101; i++)
{
    if (i%3==0){
        System.Console.WriteLine("fizz");
    }
    
    if (i%5==0){
        System.Console.WriteLine("buzz");
    }
    
}
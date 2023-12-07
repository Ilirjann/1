// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
int[] integerArray = new int[10];
for (int i = 0; i < 10; i++)
{
    integerArray[i]=i;
}
string[] stringArray = {"tim","Martin","Nikki","Sara"};

bool[] booleAnarray = new bool[10];
for (int i = 0; i < 10; i++)
{
    booleAnarray[i] =i %2 ==0;
}
System.Console.WriteLine("String Array:"+string.Join (", ", stringArray));
System.Console.WriteLine("Boolean Array:"+string.Join (", ", booleanArray));
System.Console.WriteLine("Integer Array:"+string.Join (", ", integerArray));

List<string> icecreamflavors =new List<string>
  {
    "Chokolate", "Vanilla","Strawberry","Mint Chocolate Chip","Cookie Dough",
  };
  System.Console.WriteLine("Initial Length of the List"+icecreamflavors.Count);

  System.Console.WriteLine("Third Flavour in the List"+ icecreamflavors[2]);
  icecreamflavors.RemoveAt(2);
  System.Console.WriteLine("Length of the List after Removal"+icecreamFlavours.Count);


  string[] names2={"Alice","Bob","Charlie","David","Eva"};
  List<string> iceCreamFlavours2 = new List<string>{"Chocolate","Vanilla","Strawberry"}
  
  Dictionary<string,string>userDictionary=new Dictionary<string,string>();

  Random random=newRandom();
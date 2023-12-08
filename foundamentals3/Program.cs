static void PrintList(List<string> MyList)
{
 foreach (var item in MyList)
 {
    System.Console.WriteLine(item);
 }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

static void SumOfNumbers(List<int> IntList)
{ int sum=0;
    foreach(var item in IntList)
{
   sum=sum+item;
}
System.Console.WriteLine(sum);
}

List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);
static int FindMax(List<int> IntList)
{
    int max=IntList[0];
    foreach (var item in IntList)
    {
       if(item>max) {
        max=item;
       }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
int maxValue=FindMax(TestIntList2);
System.Console.WriteLine(maxValue);


static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i]=IntList[i]*IntList[i] ;
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);


static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (var item in MyDictionary)
    {
        System.Console.WriteLine(item);
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);


static void FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    foreach (var item in MyDictionary)
    {
        if (item.Value==SearchTerm){
            System.Console.WriteLine($"value {SearchTerm} eshte tek key {item.Key}");
        }
    }
}
FindKey(TestDict, "Tony Stark");




static Dictionary<string,int> GenerateDictionary(List<string> listaMeFjale, List<int> listaMeInt){
    Dictionary<string,int> DictionaryQeDoKrijohet = new Dictionary<string, int>();

    for (int i = 0; i < listaMeFjale.Count; i++)
    {   
        DictionaryQeDoKrijohet.Add(listaMeFjale[i],listaMeInt[i]);
    }
    return DictionaryQeDoKrijohet;

}

Dictionary<string,int> newDictionary = GenerateDictionary(TestStringList,TestIntList3);

foreach (var item in newDictionary)
{
    System.Console.WriteLine($" {item.Key}  {item.Value}");
}




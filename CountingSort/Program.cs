var listArr = new List<int>();
List<int> arr = new List<int>();
arr.Add(1);
arr.Add(1);
arr.Add(3);
arr.Add(2);
arr.Add(1);

arr.Sort();

listArr.Add(0);
foreach (var line in arr.GroupBy(x => x)
                        .Select(x => x.Count()))
{
    listArr.Add(line);
}
int a = int.MinValue;
string[] str = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","x","y","z",
                             "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","X","Y","Z"
                            };

listArr.Count();
Console.ReadKey();
//// Тема 3: Строки. 
// Метод Join:
int [] array = new int [3]{1,3,4};
string str = string.Join("--", array);
Console.WriteLine(str);

// Метод Format (заменяет интерполяцию $):
string str2 = string.Format ("{0} равно {1} - это {2}", "1+1", 4, false);
Console.WriteLine(str2);

//Метод Concat (складывает строчки):
string str3 = string.Concat("-","+","=");
Console.WriteLine(str3);


// Итоговая проверочная работа.
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения 
// на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.
// Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете 
// ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним 
// коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] stringArray = { "hello", "world", "2", ":-)", "helloworld", "89", "qwerty", "4" };

void PrintArray(string[] stringArray)
{
  Console.Write("["); 
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"\"{stringArray[i]}\"");
    if (i != stringArray.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
}

int StringSearch(string[] stringArray)
{
  int numberOfString = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      numberOfString++;
    }
  }
  return numberOfString;
}

string[] CreatArray(string[] stringArray, int sizeNewArray)
{
  string[] newStringArray = new string[sizeNewArray];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      newStringArray[j] = stringArray[i];
      j++; 
    }
  }
  return newStringArray;
}


PrintArray(stringArray);
// WriteLine();
// WriteLine(StringSearch(stringArray));
int sizeNewArray = StringSearch(stringArray); 
string[] newArray = CreatArray(stringArray, sizeNewArray); 
Console.Write(" -> ");
PrintArray(newArray);

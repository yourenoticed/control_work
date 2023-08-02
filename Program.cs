string[] ElementsWithLengthLessThan4(string[] elements)
{
    int size = 0;
    // finding the length of output array
    foreach (string element in elements)
    {
        if (element.Length <= 3)
        {
            size++;
        }
    }

    // creating a new array, filling it with corresponding elements
    string[] result = new string[size];
    int i = 0;
    foreach (string element in elements)
    {
        if (element.Length <= 3)
        {
            result[i] = element;
            i++;
        }    
    }        
    return result;
}

string[] arr = {"Hello", "2", "world", ":-)"};
string[] result = ElementsWithLengthLessThan4(arr);
foreach (string element in result)
{
    System.Console.WriteLine(element);
}
// See https://aka.ms/new-console-template for more information
//https://www.hackerrank.com/challenges/camelcase/problem?h_r=internal-search

//Test
string str = "saveChangesInTheEditor";
GetNumberCamelCase(str);

void GetNumberCamelCase(string str)
{
    int numberOfUpperLetter = 0;
    if (!char.IsUpper(str[0]))
        numberOfUpperLetter++; //string starts with lowercase
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (char.IsUpper(str[i]))
            numberOfUpperLetter++;

    }
    Console.WriteLine(numberOfUpperLetter);
}

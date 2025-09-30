
(int age, string name) person = (24, "hasan");

person.age = 25;

Console.WriteLine(person.name);


(int, string)[] x = new (int, string)[2];

int[] y = new int[2];


(int, string) Test((int, string) x)
{
    return (25, "hello");
}


int[] numbers = [3, 5, 2, 7, 9, 1, 9, 2, 8, 6, 5, 3, 2, 1, 9]; // an item can be Max int;

(int number, int howMany)[] count = new (int, int)[numbers.Length];
int index = 0;

for(int i = 0; i < numbers.Length; i++)
{
    bool found = false;
    for(int j = 0; j < count.Length; j++)
    {
        if (count[j].number == numbers[i])
        {
            count[j].howMany++;
            found = true;
            break;
        }
    }
    if (!found)
        count[index++] = (numbers[i], 1);
}

for(int i = 0; i < index; i++)
{
    Console.WriteLine($"{count[i].number}:{count[i].howMany}");
}
Console.WriteLine("문제 1: 배열의 합 구하기"); 
// 정수로 이루어진 배열이 주어졌을 때, 배열의 모든 요소의 합을 계산하는 코드를 작성하세요

int[] array = { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (var i in array)
{
    sum += i;
}

Console.WriteLine(sum);
Console.WriteLine(array.Sum());


Console.WriteLine("문제 2: 배열에서 홀수만 출력하기");
//정수로 이루어진 배열이 주어졌을 때, 배열의 요소 중 홀수만 출력하는 코드를 작성하세요.

int[] numbers = { 1, 2, 3, 4, 5, 6 };

foreach (var number in numbers)
{
    if (number % 2 == 1)
        Console.WriteLine(number);
}

Console.WriteLine("문제 3: 배열 요소 제곱하기");

foreach (var number in numbers)
{
    Console.WriteLine(number*number);
}

int[] numbers2 = { 7, 2, 5, 8, 4 };

Console.WriteLine("문제 4: 배열 요소의 최대값 찾기");
int max = 0;
foreach (var number in numbers2)
{
    if(number > max)
    {
        max = number;
    }
}
Console.WriteLine(max);
Console.WriteLine(numbers2.Max());


Console.WriteLine("문제 5: 배열 뒤집기");
//정수로 이루어진 배열이 주어졌을 때, 배열을 거꾸로 뒤집는 코드를 작성하세요. (단, 내장 함수를 사용하지 말고 for문을 활용하세요.)

for(int i = numbers.Length; i!=0; i--)
{
    Console.WriteLine(numbers[i-1]);
}

Console.WriteLine("문제 6: 배열에서 중복 제거하기");

int[] numbers3 = { 1, 2, 2, 3, 4, 4, 5 };

int[] result = numbers3.Distinct().ToArray();
Console.WriteLine(string.Join(", ", result));



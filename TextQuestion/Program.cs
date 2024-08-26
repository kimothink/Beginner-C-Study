using System.Globalization;

Console.WriteLine("문제 1: 문자열 길이 구하기");
//주어진 문자열의 길이를 출력하는 코드를 작성하세요.

string text = "Hello, world!";
Console.WriteLine(text.Length);

Console.WriteLine("문제 2: 문자열 대소문자 변환");
//주어진 문자열을 모두 대문자로 변환하고, 모두 소문자로 변환한 결과를 각각 출력하는 코드를 작성하세요.

text = "Python Programming";

Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());


Console.WriteLine("문제 3: 문자열에서 특정 문자 개수 세기");
//주어진 문자열에서 특정 문자가 몇 번 등장하는지 세는 코드를 작성하세요.

text = "banana";
char txt= 'a';

int count = 0;
foreach(char c in text)
{
    if (c == txt)
        count++;
}
Console.WriteLine(count);

Console.WriteLine("문제 4: 문자열 거꾸로 출력하기");

text = "OpenAI";
Console.WriteLine(text.Reverse().ToArray());

Console.WriteLine("문제 5: 문자열 내 단어 개수 세기");
//주어진 문자열에서 공백으로 구분된 단어의 개수를 세는 코드를 작성하세요.
text = "This is a test string";

count = 0;
foreach(char s in text)
{
    if(s==' ')
    count++;
}

Console.WriteLine(count+1);

Console.WriteLine("문제 6: 문자열에서 모음 제거하기");
//주어진 문자열에서 모든 모음('a', 'e', 'i', 'o', 'u')을 제거하고 결과를 출력하는 코드를 작성하세요.

text = "Beautiful day";
text=text.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
Console.WriteLine(text);

Console.WriteLine("문제 7: 문자열 내 특정 단어 치환하기");
text = "I love programming";
Console.WriteLine(text.Replace("love", "enjoy"));

Console.WriteLine("문제 8: 문자열에서 중복 문자 제거하기");
text = "programming";
Console.WriteLine(string.Concat(text.Distinct()));

Console.WriteLine("문제 9: 문자열 회문 검사하기");
text = "madam";
Console.WriteLine(text.SequenceEqual(text.Reverse()));


Console.WriteLine("문제 10: 문자열 내 단어의 첫 글자 대문자화하기");
text = "hello world from openai";

TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

Console.WriteLine(ti.ToTitleCase(text));


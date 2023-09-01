// See https://aka.ms/new-console-template for more information


//interface 이름은 앞에 I를 붙여서 구별해주기
interface IWing
{
    public void Fly();
}
class Horse
{

}
//상속 => 재정의한다(오버로딩, 오버라이딩)
//interface는 구현한다
//둘이 다름
class Unicorn : Horse, IWing
{
    public void Fly()
    {
        Console.WriteLine("유니콘 날다");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Unicorn unicorn = new Unicorn();
        unicorn.Fly();
    }
}
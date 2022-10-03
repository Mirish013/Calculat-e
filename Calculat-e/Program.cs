namespace Calculat_e
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(NeticeGoster(10,"/",10));
      Console.ReadLine();
    }
    static double NeticeGoster( double x, string emel, double y)
        {
            calculate hes = new calculate();
            hes.Setstr(emel,x,y);
            var qiy = hes.Getstr();
            return qiy;
        }
  }
}

namespace Calculating
{
    public class calculate
    {
        private double qiy;

        public double Getstr()
        {
            return qiy;
        }

        public void Setstr(string str, double x1, double y1)
        {
            switch (str)
            {
                case "/":
                    qiy = x1 / y1;
                    break;
                case "*":
                    qiy = x1 * y1;
                    break;
                case "-":
                    qiy = x1 - y1;
                    break;
                case "+":
                    qiy = x1 + y1;
                    break;
            }
        }
    }
}
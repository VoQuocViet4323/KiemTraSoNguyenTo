internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so: ");
        int so = Convert.ToInt32(Console.ReadLine());
        if(so < 2){
            Console.WriteLine(so + " khong phai la so nguyen to");
        }else {
            int i = 2;
            bool check = true;
            while (i <= Math.Sqrt(so))
            {
                if (so % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }if(check){
                Console.WriteLine(so + " la so nguyen to");                
            }else {
                Console.WriteLine(so + " khong phai la so nguyen to");
            }
        }        
    }
}
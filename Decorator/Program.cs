namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notifier thongbao = new Notifier();
            //thongbao.send("Day la thong bao!");

            //thongbao = new sms();
            //thongbao.send("Day la thong bao!");

            //thongbao = new facebook();
            //thongbao.send("Day la thong bao!");

            //thongbao = new zalo();
            //thongbao.send("Day la thong bao!");

            //thongbao = new sms_facebook();
            //thongbao.send("Day la thong bao!");

            //Notifier notify = new Notifier();
            //Notifier thongbao = new sms(notify);
            //thongbao = new facebook(thongbao);
            //thongbao = new telegram(thongbao);
            //thongbao.send("Day la thong bao 2");

            Notifier thongbao2 = new facebook(new sms(new zalo(new telegram(new Notifier()))));
            thongbao2.send("Day la thong bao 3");
        }
    }
}

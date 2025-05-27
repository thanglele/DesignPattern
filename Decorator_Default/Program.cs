namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotifier notify = new Notifier();
            sms s = new sms(notify);
            facebook facebook = new facebook(s);
            //telegram tele = new telegram(facebook);

            //INotifier thongbao2 = new facebook(new sms(new zalo(new telegram(notify))));
            facebook.send("Day la thong bao 3");
        }
    }
}

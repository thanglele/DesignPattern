using System.ComponentModel.DataAnnotations;

namespace Bridge
{
    public interface Device
    {
        public bool isEnable();
        public void enable();
        public void disable();
        public int getVolume();
        public void setVolume(int percent);
        public int getChannel();
        public void setChannel(int channel);
    }
    public class Radio : Device
    {
        private bool state;
        private int volume = 0, channel = 0;
        public bool isEnable()
        {
            Console.WriteLine("Radio " + state);
            return this.state;
        }
        public void enable()
        {
            Console.WriteLine("Radio turning on!");
            this.state = true;
        }
        public void disable()
        {
            Console.WriteLine("Radio turning off!");
            this.state = false;
        }
        public int getVolume()
        {
            Console.WriteLine("Volume " + volume);
            return volume;
        }
        public void setVolume(int percent)
        {
            Console.WriteLine("Volume dieu chinh " + percent);
            this.volume = percent;
        }
        public int getChannel()
        {
            Console.WriteLine("Channel: " + channel);
            return channel;
        }
        public void setChannel(int channel)
        {
            Console.WriteLine("Chuyen kenh: "+ channel);
            this.channel = channel;
        }
    }
    public class TV
    {
        private bool state;
        private int volume = 0, channel = 0;
        public bool isEnable()
        {
            Console.WriteLine("TV " + state);
            return this.state;
        }
        public void enable()
        {
            Console.WriteLine("TV turning on!");
            this.state = true;
        }
        public void disable()
        {
            Console.WriteLine("TV turning off!");
            this.state = false;
        }
        public int getVolume()
        {
            Console.WriteLine("Volume " + volume);
            return volume;
        }
        public void setVolume(int percent)
        {
            Console.WriteLine("Volume dieu chinh " + percent);
            this.volume = percent;
        }
        public int getChannel()
        {
            Console.WriteLine("Channel: " + channel);
            return channel;
        }
        public void setChannel(int channel)
        {
            Console.WriteLine("Chuyen kenh: " + channel);
            this.channel = channel;
        }
    }
    public class Remote
    {
        protected Device device;
        public Remote(Device device)
        {
            this.device = device;
        }

        public void togglePower()
        {
            if (device.isEnable())
            {
                device.disable();
            }
            else
            {
                device.enable();
            }
        }
        public void volumeDown()
        {
            device.setVolume(device.getVolume() - 1);
        }
        public void volumeUp()
        {
            device.setVolume(device.getVolume() + 1);
        }
        public void channelDown()
        {
            device.setChannel(device.getChannel() - 1);
        }
        public void channelUp()
        {
            int old = device.getChannel();
            device.setChannel(old + 1);
        }
    }
    public class AdvanceRemote : Remote
    {
        public AdvanceRemote(Device device) : base(device)
        {
            this.device = device;
        }

        public void mute()
        {
            device.setVolume(0);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Radio();
            Remote remote = new Remote(device);
            remote.togglePower();
        }
    }
}

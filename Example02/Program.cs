using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public interface Button
    {
        void render();
    }

    public interface CheckBox
    {
        void render();
    }
    public interface TextField
    {
        void render();
    }

    public class WindowsButton : Button
    {
        public void render()
        {
            Console.WriteLine("Rendering a Windows-style button.");
        }
    }

    public class WindowsCheckbox : CheckBox 
    {
        public void render()
        {
            Console.WriteLine("Rendering a Windows-style checkbox.");
        }
    }
    public class WindowsTextField : TextField
    {
        public void render()
        {
            Console.WriteLine("Rendering a Windows-style TextField.");
        }
    }

    public class MacOSButton : Button
    {
        public void render()
        {
            Console.WriteLine("Rendering a macOS-style button.");
        }
    }

    public class MacOSCheckbox : CheckBox
    {
        public void render()
        {
            Console.WriteLine("Rendering a macOS-style checkbox.");
        }
    }
    public class MacOSTextField : TextField
    {
        public void render()
        {
            Console.WriteLine("Rendering a macOS-style TextField.");
        }
    }

    public class LinuxButton : Button
    {
        public void render()
        {
            Console.WriteLine("Rendering a Linux-style button.");
        }
    }

    public class LinuxCheckbox : CheckBox
    {
        public void render()
        {
            Console.WriteLine("Rendering a Linux-style checkbox.");
        }
    }
    public class LinuxTextField : TextField
    {
        public void render()
        {
            Console.WriteLine("Rendering a Linux-style TextField.");
        }
    }

    public interface GUIfactory
    {
        Button createButton();
        CheckBox createCheckbox();
        TextField createTextField();
    }

    public class WindowsGUIFactory : GUIfactory 
    {
        public Button createButton() 
        {
            return new WindowsButton();
        }
        public CheckBox createCheckbox()
        {
            return new WindowsCheckbox();
        }
        public TextField createTextField()
        {
            return new WindowsTextField();
        }
    }
    public class MacOSGUIFactory : GUIfactory
    {
        public Button createButton()
        {
            return new MacOSButton();
        }
        public CheckBox createCheckbox()
        {
            return new MacOSCheckbox();
        }
        public TextField createTextField()
        {
            return new MacOSTextField();
        }
    }
    public class LinuxGUIFactory : GUIfactory
    {
        public Button createButton()
        {
            return new LinuxButton();
        }
        public CheckBox createCheckbox()
        {
            return new LinuxCheckbox();
        }
        public TextField createTextField()
        {
            return new LinuxTextField();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory GUI Demo:\n");

            new WindowsGUIFactory().createButton().render();
            Console.WriteLine("\n");
            new WindowsGUIFactory().createCheckbox().render();
            Console.WriteLine("\n");
            new WindowsGUIFactory().createTextField().render();
            Console.WriteLine("\n");
            new MacOSGUIFactory().createButton().render();
            Console.WriteLine("\n");
            new MacOSGUIFactory().createCheckbox().render();
            Console.WriteLine("\n");
            new MacOSGUIFactory().createTextField().render();
            Console.WriteLine("\n");
            new LinuxGUIFactory().createButton().render();
            Console.WriteLine("\n");
            new LinuxGUIFactory().createCheckbox().render();
            Console.WriteLine("\n");
            new LinuxGUIFactory().createTextField().render();
        }
    }
}

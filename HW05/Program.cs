using System;

public interface IHomework05
{
    void DisplayLEDOnScreen(string[] LEDs);
    void DisplaynameLED(string[] nameLEDs);
    void LEDon();
}

public class HW05 : IHomework05
{
    string[] LED;
    string[] nameLED;

    public void DisplayLEDOnScreen(string[] LEDs)
    {
        LED = LEDs;
    }
    public void DisplaynameLED(string[] nameLEDs)
    {
        nameLED = nameLEDs;
    }
    public void LEDon()
    {
        Console.WriteLine(string.Join(" ", LED));
        Console.WriteLine(string.Join("  ", nameLED));
        Console.WriteLine("Please choose LED to turn On/Off:");
        int count = 1;
        while (count <= 100)
        {
            string number = Console.ReadLine();
            for (int i = 0; i < nameLED.Length; i++)
            {
                if (nameLED[i] == number & LED[i] == "[]")
                {
                    LED[i] = "[!]";
                }
                else if (nameLED[i] == number & LED[i] == "[!]")
                {
                    LED[i] = "[]";
                }
            }
            Console.WriteLine(string.Join(" ", LED));
            Console.WriteLine(string.Join("  ", nameLED));
            Console.WriteLine("Please choose LED to turn On/Off:");
        }
    }
}

public class Program
{
    public static void Main()
    {
        string[] LED = new string[] { "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", };
        string[] nameLED = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", };

        IHomework05 led = new HW05();
        led.DisplayLEDOnScreen(LED);
        led.DisplaynameLED(nameLED);
        led.LEDon();
    }
}

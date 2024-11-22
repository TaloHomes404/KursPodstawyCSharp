namespace ConsoleOOPTraining
{
    class Phone
    {
        public string PhoneProducent;
        public string PhoneModel;
        int volume;
        int batteryPercentage;

        public void volumeUp()
        {
            if (volume < 100)
            {
                this.volume++;
                Console.WriteLine($"Current volume: {volume}");
            }
        }

        public void volumeDown()
        {
            if (volume > 0)
            {
                this.volume--;
                Console.WriteLine($"Current volume: {volume}");
            }
        }

        public void showBatteryPercentage() { Console.WriteLine(batteryPercentage); }
    }
}

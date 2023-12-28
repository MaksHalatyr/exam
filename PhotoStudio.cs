namespace Ekz
{

    public class PhotoStudio : ILamp, ICamera
    {
        public string LampType { get; set; }
        public string Producer { get; set; }
        public int PowerInLumens { get; set; }
        public string LightType { get; set; }
        public int NumberOfLights { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public int OpticalLensSensitivity { get; set; }

        public void ChangePower(int newPower)
        {
            PowerInLumens = newPower;
            Console.WriteLine($"Power has been changed to {newPower} lumens.");
        }

        public void ChangeSensitivity(int newSensitivity)
        {
            OpticalLensSensitivity = newSensitivity;
            Console.WriteLine($"Sensitivity has been changed to {newSensitivity}.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Lamp Information: Type - {Type}, Manufacturer - {Manufacturer}, Power - {PowerInLumens} lumens, Light Type - {LightType}, Number of Lights - {NumberOfLights}");
            Console.WriteLine($"Camera Information: Type - {Type}, Manufacturer - {Manufacturer}, Sensitivity - {OpticalLensSensitivity}");
        }
    }
}

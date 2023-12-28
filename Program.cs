using Ekz;

class Program
{
    static void Main()
    {
        // Створення екземплярів класу PhotoStudio
        PhotoStudio studio1 = new PhotoStudio
        {
            Type = "Studio Lamp",
            Manufacturer = "XYZ Lighting",
            PowerInLumens = 5000,
            LightType = "LED",
            NumberOfLights = 3,
            OpticalLensSensitivity = 200
        };

        PhotoStudio studio2 = new PhotoStudio
        {
            Type = "Camera Flash",
            Manufacturer = "ABC Cameras",
            PowerInLumens = 2000,
            LightType = "Xenon",
            NumberOfLights = 1,
            OpticalLensSensitivity = 400
        };

        // Виведення інформації про об'єкти
        studio1.DisplayInfo();
        studio2.DisplayInfo();

        // Зміна світлочутливості та виведення інформації знову
        studio1.ChangeSensitivity(250);
        studio1.DisplayInfo();
    }
}
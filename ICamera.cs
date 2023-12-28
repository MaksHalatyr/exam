namespace Ekz
{

    public interface ICamera
    {
        //Тип
        string Type { get; set; }
        //Виробник
        string Manufacturer { get; set; }
        //Чутливість
        int OpticalLensSensitivity { get; set; }
        //Вивід інформації
        void DisplayInfo();
        //Зміна чутливості
        void ChangeSensitivity(int newSensitivity);
    }
}

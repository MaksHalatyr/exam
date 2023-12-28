namespace Ekz
{
    public interface ILamp
    {
        //Тип 
        public string LampType { get; set; }
        //Вирбник
        public string Producer {get; set;}
        //Потужніть у люменах
        public int PowerInLumens {get; set;}
        //Вид
        public string LightType {get; set;}
        //кількість
        public int NumberOfLights {get; set;}
        //Метод виводу
        public void DisplayInfo();
        //Метод зміни потужності
        public void ChangePower(int newPower);
    }
}

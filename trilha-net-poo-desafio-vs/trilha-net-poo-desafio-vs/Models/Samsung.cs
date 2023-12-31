namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero,string chip, string imei, string modelo, int memoria) : base (numero, chip, imei, modelo, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Samsung");
        }
        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando o aplicativo \"{nomeApp}\" no Samsung");
        }
    }
}

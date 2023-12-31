namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero,string chip, string imei, string modelo, int memoria) : base (numero, chip, imei, modelo, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Samsung");
        }
    }
}

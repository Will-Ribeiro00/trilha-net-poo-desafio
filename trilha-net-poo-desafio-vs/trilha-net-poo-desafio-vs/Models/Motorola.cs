namespace DesafioPOO.Models
{
    public class Motorola : Smartphone
    {
        public Motorola (string numero,string chip, string imei, string modelo, int memoria) : base(numero, chip, imei, modelo, memoria) { }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Istalando o aplicativo \"{nomeApp}\" no Motorola");
        }
        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando o aplicativo \"{nomeApp}\" no Motorola");
        }
    }
}

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero,string chip, string imei, string modelo, int memoria) : base(numero, chip, imei, modelo, memoria) { }

    
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
}


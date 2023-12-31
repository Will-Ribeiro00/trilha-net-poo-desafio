namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Chip { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string IMEI;
        protected string Modelo;
        protected int Memoria;

        public Smartphone(string numero,string chip, string imei, string modelo, int memoria)
        {
            Numero = numero;
            Chip = chip;
            // TODO: Passar os parâmetros do construtor para as propriedades
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
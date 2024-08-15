namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get;  protected set; }
        public string IMEI { get; protected set; }
        public int Memoria { get; protected set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Random random = new Random();
            
            Numero = Random9DigitString(random);
            Modelo = modelo;
            IMEI = Random12DigitString(random);
            Memoria = memoria;

        }
        private string Random9DigitString (Random random)
        {
            return random.Next(100000000, 1000000000).ToString("D9");
        }
        private string Random12DigitString (Random random)
        {
            return random.NextInt64(100000000000, 1000000000000).ToString("D12");
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
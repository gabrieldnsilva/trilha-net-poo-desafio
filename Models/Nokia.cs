namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero, string.Empty, string.Empty, 0) 
        {
            Random random = new Random();

            string[] modelos_Nokia = {"iPhone XR", "iPhone X", "iPhone 11", "iPhone 12", "iPhone 13", "iPhone 14", "iPhone 15"};
            int mIndex = random.Next(modelos_Nokia.Length);

            int[] memoria_Nokia = {32, 64, 128, 256};
            int memIndex = random.Next(memoria_Nokia.Length);
            
            Modelo = modelos_Nokia[mIndex];
            Memoria = memoria_Nokia[memIndex];
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no dispositivo Nokia... ");
        }
    }
}
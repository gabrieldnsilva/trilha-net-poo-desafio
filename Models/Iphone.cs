namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero, string.Empty, string.Empty, 0) 
        {
            Random random = new Random();

            string[] modelos_iPhone = {"iPhone XR", "iPhone X", "iPhone 11", "iPhone 12", "iPhone 13", "iPhone 14", "iPhone 15"};
            int mIndex = random.Next(modelos_iPhone.Length);
            
            int[] memoria_iPhone = {64, 128, 256, 512};
            int memIndex = random.Next(memoria_iPhone.Length);

            Modelo = modelos_iPhone[mIndex];
            Memoria = memoria_iPhone[memIndex];

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no dispositivo iPhone... ");
        }
    }
}
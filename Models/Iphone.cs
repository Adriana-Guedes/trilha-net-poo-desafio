namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
          
          
        
      public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

         // Override do método InstalarAplicativo da classe base (Smartphone).

     public override void InstalarAplicativo(string nomeApp)
         {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone");
        }
    }
}
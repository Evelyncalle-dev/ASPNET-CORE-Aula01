namespace Aula01.Models
{
    public class Carro
    {

        //PROPIEDADES
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Cor { get; set; }

        //MÉTODOS (AÇOES)

        public string Acelerar()
        {
            return $"0 {Modelo} {Marca} esta acelerando";
        }
    }
}

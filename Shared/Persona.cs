namespace Shared
{
    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin nombre --";

        private string documento = "";
        public string Documento
        {
            get { return documento; }
            set
            {
                if (value.Length >= 7)
                    documento = value;
                else
                    throw new Exception("El documento debe tener al menos 7 caracteres");
            }
        }

        public void Print()
        {
            Console.WriteLine("Persona");
            Console.WriteLine("     Documento:" + this.Documento);
            Console.WriteLine("     Nombre:" + this.Nombre);

        }

    }
}
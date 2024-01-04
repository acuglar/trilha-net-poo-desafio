using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string modelo;
        private string imei;
        private int memoria;
        private string numero;

        public string Numero
        {
            get => numero;
            set
            {
                if (!string.IsNullOrEmpty(value) && !VerificarNumero(value))
                {
                    Console.WriteLine("Número de telefone inválido.\nNúmero informado deve conter de 8 a 9 digitos.\n");
                }
                else
                {
                    numero = value;
                }
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.modelo = modelo;
            this.imei = imei;
            try
            {
            this.memoria = memoria <= 0 ? throw new Exception() : memoria;
            }
            catch
            {
                Console.WriteLine("Quantidade de memória inválida.\nMemória deve ser inteiro maior que 0.\n");
            }
            Numero = numero;
        }

        private bool VerificarNumero(string numero)
        {
            string pattern = @"^\d{4}-\d{5}$|^\d{4}-\d{4}$|^\d{9}$|^\d{8}$";
            return Regex.IsMatch(numero, pattern);
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
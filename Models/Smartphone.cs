namespace DesafioPOO.Models{
    public abstract class Smartphone{
        private string _numero;
        public string numero { 
            get{ return _numero; }
            set{
                if(NumeroEValido(value)){
                    _numero = value;
                }
                else{
                    throw new ArgumentException("O Número de telefone deve ser passado no formato DDD + 9 + Numero sem espços: XX9XXXXXXXX");
                }
            }
        }

        private string modelo { get; set; }

        private string imei { get; set; }

        private int memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria){
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;

            int[] valoresPermitidos = { 16, 32, 64, 128, 256 };
            if (!Array.Exists(valoresPermitidos, valorPassado => valorPassado == memoria)){
                throw new ArgumentException("A memória deve ser um dos valores permitidos: 16, 32, 64, 128, 256.");
            }
            else{
            this.memoria = memoria;
            }
        }

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        private bool NumeroEValido(string numero){
            return System.Text.RegularExpressions.Regex.IsMatch(numero, @"^\d{2}9\d{8}$");
        }
    }
}
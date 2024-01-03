namespace DesafioPOO.Models{
    public abstract class Smartphone{
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string numero { 
            get{ return _numero; }
            set{
                if(NumeroEValido(value)){
                    _numero = value;
                }
                else{
                    Console.WriteLine("O Número de telefone deve ser passado no formato DDD + 9 + Numero sem espços: XX9XXXXXXXX");
                }
            }
        }

        private string modelo {
            get { return _modelo; } 
            set { _modelo = value; }
        }

        private string imei {
            get { return _imei; } 
            set { _imei = value; }
        }

        private int memoria{
            get { return _memoria; } 
            set {
                int[] valoresPermitidos = { 16, 32, 64, 128, 256 };

                if(!Array.Exists(valoresPermitidos, valorPassado => valorPassado == value)){
                    Console.WriteLine("A memória deve ser um dos valores permitidos: 16, 32, 64, 128, 256.");              
                }
                else{
                    _memoria = value; 
                }
            }
        }

        public Smartphone(string numeroCelular, string modeloCelular, string imeiCelular, int memoriaCelular){
            numero = numeroCelular;
            modelo = modeloCelular;
            imei = imeiCelular;
            memoria = memoriaCelular;
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
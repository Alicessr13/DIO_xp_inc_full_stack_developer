using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){ //metodo(pedaço de código que irá fazer alguma ação) somar recebe x e y como parametros 
            //parametros = argumentos que iram ser informados para realizar uma operação
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void Subtrair(int x, int y){ 
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Multiplicar(int x, int y){ 
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void Dividir(int x, int y){ 
            Console.WriteLine($"{x} / {y} = {x/y}");
        }

        public void Potencia(int x, int y){
            double pot = Math.Pow( x , y); //potencia
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano); //o angulo ja precisa estar em radiano para passar no math
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno,4)}"); //math.round arredonda para 4 casa depois da virgula
        }

        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);  //o angulo ja precisa estar em radiano para passar no math
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno,4)}");
        }
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180; 
            double tangente = Math.Tan(radiano);  //o angulo ja precisa estar em radiano para passar no math
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}
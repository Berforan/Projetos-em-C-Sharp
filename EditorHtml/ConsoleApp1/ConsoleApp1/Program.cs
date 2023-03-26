using System;
using System.Globalization;

namespace MyApp 
{
    class Program 
    {

        static void Main(string[] args) {
            //var id = Guid.NewGuid();
            //id.ToString();
            //Console.WriteLine(id);

            //var price = 100;
            //var texto = "o preço do produto é " + price;
            //var texto = String.Format("O preço do produto é {0} apenas na promoção", price);
            //var texto = $"O preço do produto é {price}";
            //Console.WriteLine(texto);

            //var texto = "Este texto é um teste";
            //Console.WriteLine(texto.Contains("teste"));
            //Console.WriteLine(texto.Contains("Teste"));
            //Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(texto.Contains(null));
            //Console.WriteLine(texto.StartsWith("Este"));
            //Console.WriteLine(texto.StartsWith("este"));
            //Console.WriteLine(texto.StartsWith("texto"));

            //Console.WriteLine(texto.EndsWith("teste"));
            //Console.WriteLine(texto.EndsWith("Teste"));
            //Console.WriteLine(texto.EndsWith("xoro"));

            var texto = "este é meu teste";
            //Console.WriteLine(texto.IndexOf("é"));
            //Console.WriteLine(texto.LastIndexOf("t"));
            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto.ToLower());
            //Console.WriteLine(texto.Insert(10, "teste"));
            //Console.WriteLine(texto.Remove(10, 6));
            //Console.WriteLine(texto.Length);

           // Console.WriteLine(texto.Replace("este", "esse");
            //Console.WriteLine(texto.Replace("xxxxxx", "X");

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(6, 4);
            Console.WriteLine(resultado);
            Console.WriteLine(texto.Trim());

        }

      

    }

}
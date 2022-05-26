using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ConsoleApp.Entidades
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            //converte string em lista
            var numeros = numbers.Split(',').Select(Int32.Parse).ToList();
            var soma = 0;
            var erroNumeroNegativo = "Números negativos não permitidos : ";

            //A passagem de um único número deve resultar no próprio número. 
            if (numeros.Count == 1)
                return numeros[0];

            //Se passarmos números negativos, o método deve lançar uma ArgumentException, com a mensagem “Números negativos não permitidos:” seguida dos negativos que foram especificados. 
            foreach (var item in numeros)
                if (item <0)
                    erroNumeroNegativo += ", " + item.ToString() ;
            if (erroNumeroNegativo!= "Números negativos não permitidos : ")
                throw new ArgumentException(erroNumeroNegativo);

            //Devemos retornar uma FormatException caso exista uma sequência sem números. Ex: 1,2,,3,4. Retornndo a mensagem "Sequência inválida".
            foreach (var item in numeros)
                if (item == null)
                    throw new FormatException("Sequência inválida");

            // A sequência não deve exceder 10 números. Caso isso aconteça deve ser retornada uma ArgumentException com a mensagem "Sequência com tamanho inválido"
            if (numeros.Count > 10)
                throw new ArgumentException("Sequência com tamanho inválido");

            //O método pega uma string representando números separados por uma vírgula, e retorna sua soma. 
            //O método deve ignorar números maiores que 1000. Portanto, “1.2.1000” deve resultar em 1003, mas “1.2.1001” deve resultar em 3.

            foreach (var item in numeros)
                if (item < 1001)
                    soma += item;

            return soma;
        }
    }
}

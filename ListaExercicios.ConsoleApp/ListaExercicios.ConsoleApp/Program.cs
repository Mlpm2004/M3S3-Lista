// See https://aka.ms/new-console-template for more information
using ListaExercicios.ConsoleApp.Entidades;

var sc = new StringCalculator();
Console.WriteLine(sc.Add("1,2,3"));
Console.WriteLine(sc.Add("0"));
Console.WriteLine(sc.Add("3"));
Console.WriteLine(sc.Add("1,-2,-3"));
Console.WriteLine(sc.Add("1,,3"));
Console.WriteLine(sc.Add("1,1002,3"));
Console.WriteLine(sc.Add("1,2,3,2,3,2,3,2,3,2,3"));

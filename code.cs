using System;
using CSharpShellCore;
namespace AreaDasFormas{
class Classe{
static void Main(String[] args){

string resposta;
float resultado;
    
Console.WriteLine("qual forma geométrica você deseja saber a area?\n digite: r para o retangulo ou qualquer outro caracter para o circulo");

resposta = Console.ReadLine();

if(resposta == "r"){
    
Console.WriteLine("insira a altura: ");
float altura = float.Parse(Console.ReadLine());

Console.WriteLine("insira a largura: ");
float largura = float.Parse(Console.ReadLine());

resultado = altura * largura;
}

else{
    
Console.WriteLine("insira o raio do circulo: ");
float raio = float.Parse(Console.ReadLine());

resultado = (float)Math.PI * (raio * raio);



}
Console.WriteLine("o resultado é: "+ resultado);
Console.ReadKey();
}
}
}

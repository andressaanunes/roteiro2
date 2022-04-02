/* 1. Faça um programa que receba dois números, calcule e mostre a subtração do primeiro 
número pelo segundo. */
 int a, b, x;
            Console.WriteLine("Digite o primeiro numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            b = int.Parse(Console.ReadLine());
            x = a - b;
            Console.WriteLine(" a subtração do primeiro número pelo segundo é: " + x);
            Console.WriteLine();

/* 2.Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas 
notas, considerando peso 2 para a primeira nota e peso 3 para a segunda nota. */
double n1, n2, p2, p3, MP;

            Console.WriteLine("Digite duas notas");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os pesos 2 e 3:");
            p2 = Convert.ToDouble(Console.ReadLine());
            p3 = Convert.ToDouble(Console.ReadLine());
            MP = (n1 * p2) + (n2 * p3) / p2 + p3;
            Console.WriteLine("Considerando peso 2 para a primeira nota e peso 3 para a segunda nota.");
            Console.WriteLine("A média ponderada será: {0}", MP);

/* 3).Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, 
sabendo-se que este sofreu um desconto de 10%. */
  double preco, desconto, novopreco;

            Console.Write("Digite o preço do produto: "); 
            preco = Convert.ToDouble(Console.ReadLine()); 
            desconto = (preco * 10) / 100; 
            novopreco = preco - desconto;
            Console.Write("O valor do produto com 10% de desconto e: " + novopreco);
            Console.ReadKey();
/* 4. Faça um programa que calcule e mostre a área de um trapézio. Sabe-se que: A = (( base 
maior - base menos) * altura) / 2 */
            double baseMaior, baseMenor, altura, area;

            Console.WriteLine("Digite o maior  valor  da base B, do Trapézio");
            baseMaior=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o menor  valor  da base b, do Trapézio");
            baseMenor=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do trapézio");
            altura=Convert.ToDouble(Console.ReadLine());
            area=(( baseMaior + baseMenor )*altura)/2;
            Console.WriteLine("A área do trapézio é:" +  area);
            Console.ReadKey();
/* 5.Faça um programa que receba o valor do salário mínimo e o valor do salário de um 
funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.*/
            double salarioMinimo, salarioFuncionario, quantidadeSalariosMinimos;

            Console.WriteLine("Informe o valor do salário minimo atual: ");
            salarioMinimo =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o salário do Funcionario: ");
            salarioFuncionario = Convert.ToDouble(Console.ReadLine());
            quantidadeSalariosMinimos= salarioFuncionario/salarioMinimo;
            Console.WriteLine("O Funcionario recebe " +  quantidadeSalariosMinimos  + " salários minimos." );
            Console.ReadKey();


/* 6. Faça um programa que receba o valor dos catetos de um triângulo, calcule e mostre o valor 
da hipotenusa.*/ 
double lado1, lado2, h, r;
Console.WriteLine("Digite o lado A de um triângulo: ");
lado1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o lado B de um triângulo: ");
lado2= Convert.ToDouble(Console.ReadLine());
h= (lado1 * 2) + (lado2 * 2);
Console.WriteLine("O valor da hipotenusa é: " + h);
r= Math.Sqrt(lado1);
Console.WriteLine("A raiz quadra do triângulo é: " + r);
Console.ReadKey();

/*7.Faça um programa que receba o raio, calcule e mostre:   */
/*a) o comprimento de uma esfera, sabe-se que C = 2πR; */
/*b) a área de uma esfera, sabe-se que A = πR2;  */
/*c) o volume de uma esfera, sabe-se que V = 4/3πR3. */

double raio, esfera, area, volume;
Console.WriteLine("Digite o valor do Raio: ");
raio= Convert.ToDouble(Console.ReadLine());
esfera= 2 *Math.PI * raio;
Console.WriteLine("O valor da esfera é : " + esfera);
area= Math.PI * (Math.Pow(raio, 2));
Console.WriteLine("O valor da area é : " + area);
volume= 4 * Math.PI * Math.Pow(raio, 3)/3; 
Console.WriteLine("O valor do volume é : " + volume);

/* 8.Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e mostre a 
medida do terceiro ângulo. Sabe-se que a soma dos ângulos de um triângulo é 180.  */

int a1, a2, a3;
Console.WriteLine("Digite a medida do primeiro ângulo: ");
a1=int.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida do segundo ângulo: ");
a2=int.Parse(Console.ReadLine());
a3= 180;

if (a1+a2 == a3){

Console.WriteLine(" A medida do terceiro ângulo é : " + a3);

}
else
{

 Console.WriteLine(" A soma dos ângulos de um triângulo é 180, logo estas não são as medidas de um triângulo " + a3);

}
Console.ReadKey();







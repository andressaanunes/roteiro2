/* . Faça um programa que receba o valor dos catetos de um triângulo, calcule e mostre o valor 
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
volume= (4/3) * Math.PI * (Math.Pow(raio, 3)); 
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







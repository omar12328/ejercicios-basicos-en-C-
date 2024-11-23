/* 
int numeros enteros 
string cadena de caracteres 
char caracter
float numeros decimales 
bool expresiones logicas
double numeros decimales 
*/
using System.Timers;
using System.Xml;
//suma 
int numero1 = 0;
    int numero2 = 0;
    int total = 0;
Console.WriteLine("ingrese el numero1");
numero1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese numero2");
numero2= Convert.ToInt32(Console.ReadLine());

total = numero1 + numero2;
Console.WriteLine("el resultado de la suma es " + total);



//division
int numero3 = 0;
int numero4 = 0;
int totall = 0;
Console.WriteLine("ingrese el numero3");
numero3= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el numero4");
numero4 = Convert.ToInt32(Console.ReadLine());

//totall = numero3 / numero4;

totall = numero3 / numero4;
Console.WriteLine("el resultado de la division es " + totall);



//resta 
int numero5 = 0;
int numero6 = 0;
int totalll = 0;
Console.WriteLine("ingrese el numero5");
numero5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese numero6");
numero6 = Convert.ToInt32(Console.ReadLine());

totalll = numero5 - numero6;
Console.WriteLine("el resultado de la resta es " + totalll);

//multiplicacion 
int numero7 = 0;
int numero8 = 0;
int totallll = 0;
Console.WriteLine("ingrese el numero7");
numero7  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el numero8");
numero8 =  Convert.ToInt32(Console.ReadLine());

totallll = numero8 * numero7;
Console.WriteLine("el resultado de la multiplicacion es " + totallll);


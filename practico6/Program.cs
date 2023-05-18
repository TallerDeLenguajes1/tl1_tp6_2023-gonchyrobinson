// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:" +a);
Console.WriteLine("valor de b:"+b);
*///EJercicio 1
float a;
Console.WriteLine("Ingrese el numero que desea invertir:  ");
string? b= Console.ReadLine();
bool anda=float.TryParse(b,out a);
if (anda)
{
    if (a>0)
    {    
        float invertido= 1/a;
        Console.WriteLine("El numero invertido es: "+invertido);
    }else
    {
        Console.WriteLine("El numero ingresado no es mayor a 0");
    }
}else
{
    Console.WriteLine("El numero " +b+ " no es valido");
}

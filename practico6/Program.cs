// See https://aka.ms/new-console-template for more information
const float INDEFINIDO = 9999;
int opcion;
Console.WriteLine("\n=====================MENU===================\n1-Sumar\n2-Resta\n3-Multiplicar\n4-Dividir\n\nOpcion Elegida:   ");
string? opcionString=Console.ReadLine();
Console.WriteLine("\nOPERADORES\nOperador 1:  ");
string? operador1string=Console.ReadLine();
Console.WriteLine("Operador 2: ");
string? operador2string=Console.ReadLine();
bool andaOperacion=int.TryParse(opcionString, out opcion);
float operador1;
float operador2;
bool andaOp1=float.TryParse(operador1string,out operador1);
bool andaOp2=float.TryParse(operador2string, out operador2);
float resultado;
if (andaOperacion && andaOp1 && andaOp2)
{
    switch (opcion)
    {
        case 1:
            resultado=operador1+operador2;
        break;
        case 2:
            resultado=operador1-operador2;
        break;
        case 3: 
            resultado=operador1*operador2;
        break;
        case 4:
            if (operador2!=0)
            {
                resultado=operador1/operador2;
            }else
            {
                resultado=INDEFINIDO;
            }
        break;
        default:
            resultado=INDEFINIDO;
        break;
    }
    Console.WriteLine("Resultado= "+resultado);
}else
{
    Console.WriteLine("Hay un dato erroneo");
}

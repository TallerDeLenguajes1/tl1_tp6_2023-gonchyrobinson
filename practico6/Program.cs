// See https://aka.ms/new-console-template for more information
const float INDEFINIDO = 9999;
int opcion;
Console.WriteLine("\n=====================MENU===================\n1-Sumar\n2-Resta\n3-Multiplicar\n4-Dividir\n5-OTRO\n\nOpcion Elegida:   ");
string? opcionString=Console.ReadLine();
bool andaOperacion=int.TryParse(opcionString, out opcion);
Console.WriteLine("\nOPERADORES\nOperador 1:  ");
string? operador1string=Console.ReadLine();
Console.WriteLine("Operador 2: ");
string? operador2string=Console.ReadLine();
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
        case 5:
            Console.WriteLine("Ingrese que operacion desea realizar: \n1-Valor absoluto\n2-Cuadrado\n3-Raiz Cuadrada\n4-seno\n5-coseno\n6-Parte entera de un float\nOpcion:  ");
            int opcion2;
            string? opcion2String=Console.ReadLine();
            bool andaOpcion2=int.TryParse(opcion2String,out opcion2);
            Console.WriteLine("Operador:  ");
            float operador3;
            string? operador3String=Console.ReadLine();
            bool andaOperador3= float.TryParse(operador3String, out operador3);
            if (andaOpcion2 && andaOperador3)
            {
                double resultadoD;
                switch (opcion2)
                {
                    case 1:
                        resultado=Math.Abs(operador3);
                    break;
                    case 2:
                        resultadoD=Math.Pow(operador3,2);
                        resultado=(float)resultadoD;
                    break; 
                    case 3:
                        if (operador3>=0)
                        {
                            resultadoD=Math.Sqrt(operador3);
                            resultado=(float)resultadoD;
                        }else
                        {
                            resultado=INDEFINIDO;
                        }
                    break;
                    case 4:
                        resultadoD=Math.Sin(operador3);
                        resultado=(float)resultadoD;
                    break;
                    case 5:
                        resultadoD=Math.Cos(operador3);
                        resultado=(float)resultadoD;
                    break;
                    case 6:
                        string opString=operador3.ToString();
                        string[] separado=opString.Split(",");
                        bool andaConversion=float.TryParse(separado[0], out resultado);
                        if (!andaConversion)
                        {
                            resultado=INDEFINIDO;
                        }
                    break;
                    default:
                        resultado=INDEFINIDO;
                    break;
                }
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

Console.WriteLine("\n\n=====================================MAXIMO===============================\n");
Console.WriteLine("\nNum1:  ");
float num1;
float num2;
string? num1String=Console.ReadLine();
Console.WriteLine("\nNum 2:  ");
string? num2String=Console.ReadLine();
bool andaNum1=float.TryParse(num1String, out num1);
bool andaNum2=float.TryParse(num2String, out num2);
if (andaNum1 && andaNum2)
{
    if (num1>num2)
    {
        Console.WriteLine("El maximo es: "+num1);
    }else
    {
        if (num2>num1)
        {
            Console.WriteLine("El maximo es:  "+num2);
        }else
        {
            Console.WriteLine("Son iguales");
        }
    }
}

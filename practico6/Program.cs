// See https://aka.ms/new-console-template for more information
const float INDEFINIDO = 9999;
float Calculadora(float operador1, float operador2, int opcion)
{
    float resultado;
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
                if (andaOpcion2 && andaOperador3){
                    resultado=CalculadoraV2(operador3,opcion2);
                }else
                {
                    resultado=INDEFINIDO;
                }
            break;
            default:
                resultado=INDEFINIDO;
            break;
        }
        return(resultado);
}

float CalculadoraV2(float operador3, int opcion2){
    float resultado;
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
        return(resultado);
}


Console.WriteLine("Ingrese una cadena:  ");
string? cadena1=Console.ReadLine();
int longitud= cadena1.Length;
Console.WriteLine("Ingrese otra cadena:  ");
string? cadena2=Console.ReadLine();
string? concatenadas=cadena1+cadena2;
Console.WriteLine($"LONGITUD: {longitud}\nCadenas Concatenadas {concatenadas}");
Console.WriteLine("\n\nIngrese a partir de que caracter de la cadena1 desea guardar la subcadena:  ");
int indice;
Console.WriteLine("indice inicial: ");
string? indiceString=Console.ReadLine();
int longSubcadena;
Console.WriteLine("Longitud subcadena:  ");
string? longSubcadenaString=Console.ReadLine();
bool andaIndice=int.TryParse(indiceString, out indice);
bool andaSubcadena=int.TryParse(longSubcadenaString, out longSubcadena);
if (andaIndice && andaSubcadena)
{
    string subcadenaExtraida=cadena1.Substring(indice,longSubcadena);
    Console.WriteLine($"Subcadena1 = {subcadenaExtraida}");
}else
{
    Console.WriteLine("Dato incorrecto");
}
Console.WriteLine("Ingrese 2 numeros: \n-NUM1: ");
float num1;
string? num1str= Console.ReadLine();
bool andanum1=float.TryParse(num1str, out num1);
float num2;
Console.WriteLine("Num2: ");
string? num2str=Console.ReadLine();
bool andanum2= float.TryParse(num2str, out num2);
Console.WriteLine("Operacion que desea realizar: \n1- suma\n2-resta\n3-multiplicacion\n4-division");
int opcion;
string? opcionstr=Console.ReadLine();
bool andaOpcion=int.TryParse(opcionstr, out opcion);
if (andanum1 && andanum2)
{
    float resultado=Calculadora(num1,num2,opcion);
    string? resultadoStr=resultado.ToString();
    string operador;
    switch (opcion)
    {
        case 1:
            operador="suma";
        break;
        case 2:
            operador="resta";
        break;
        case 3:
            operador="multiplicacion";
        break;
        case 4:
            operador="division";
        break;
        default:
            operador="error";
        break;

    }
    string calculos;
    calculos="la " + operador+ " de " +num1str+ " y "+num2str+ " es: "+ resultadoStr;
    Console.WriteLine(calculos);
    Console.WriteLine("\n\nRecorriendo la cadena:  ");
    foreach (char item in calculos)
    {
        Console.WriteLine(item);
    }
    string[] subcadenas=calculos.Split(' ');
    Console.WriteLine("\n\nIngrese que palabra desea buscar en la cadena:  ");
    string? buscada=Console.ReadLine();
    int comparacion;
    int bandera;
    bandera=0;
    foreach (string s in subcadenas)
    {
        comparacion=string.Compare(buscada,s);
        if (comparacion==0)
        {
            bandera=1;
        }
    }
    if (bandera==1)
    {
        Console.WriteLine($"\n La cadena {buscada}, si se encuentra");
    }else
    {
        Console.WriteLine($"\n La cadena {buscada}, no se encuentra");
        
    }

    Console.WriteLine("\n\nCadena a mayusculas: ");
    calculos=calculos.ToUpper();
    Console.WriteLine(calculos);
    calculos=calculos.ToLower();
    Console.WriteLine("\n\nCadena a minusculas:  ");
    Console.WriteLine(calculos);
}
Console.WriteLine("\n\nIngrese una palabra separada por caracteres:  ");
string? cadenaSep=Console.ReadLine();
Console.WriteLine("\nCaracter separado= ");
string? caracter=Console.ReadLine();
string[] textoSeparado=cadenaSep.Split(caracter);
string? unido=null;
int identificaPrimero=0;
foreach (string elemento in textoSeparado)
{
    if (identificaPrimero==0)
    {
        unido=elemento+ ' ';
        identificaPrimero=1;
    }else
    {
        if (unido!=null)
        {
            
            unido=unido+elemento+' ';
        }
    }
}

Console.WriteLine("\nCadena separada:  "+unido);
Console.WriteLine("\n\nEcuacion:  ");
string? ecuacion=Console.ReadLine();
char separador=' ';
int opcionC;
int banderaC=0;
foreach (char op in ecuacion)
{
    if (banderaC==0)
    {
        
        switch (op)
        {
            case '+':
                separador='+';
                opcion=1;
                banderaC=1;

            break;
            case '-':
                separador='-';
                opcion=2;
                banderaC=1;
            break;
            case '*':
                separador='*';
                opcion=3;
                banderaC=1;
            break;
            case '/':
                separador='/';
                opcion=4;
                banderaC=1;
            break;
            default:
                separador=' ';
                opcion=-1;
            break;
        }
    }
    }
string[] ecuacionSep=ecuacion.Split(separador);
float num1C;
float num2C;
string? num1Cstr=ecuacionSep[0];
string? num2Cstr=ecuacionSep[1];
bool andanum1C=float.TryParse(num1Cstr, out num1C);
bool andanum2C=float.TryParse(num2Cstr, out num2C);
if (andanum1C && andanum2C)
{
    float resultadoC=Calculadora(num1C,num2C,opcion);
    Console.WriteLine(ecuacion + "= "+ resultadoC);
}


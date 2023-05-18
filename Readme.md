¿String es una tipo por valor o un tipo por referencia? 
Un string, es un tipo de dato por referencia.
 Esto significa que cuando asignas una cadena a otra variable o la pasas como argumento a un método, ambas variables o referencias apuntarán a la misma cadena en memoria


¿Qué secuencias de escape tiene el tipo string?
\": Comilla doble (")
\': Comilla simple (')
\\: Barra invertida ()
\n: Nueva línea
\r: Retorno de carro
\t: Tabulación horizontal
\b: Retroceso (backspace)
\f: Avance de página
\v: Tabulación vertical
\0: Carácter nulo
\uXXXX: Carácter Unicode especificado por el valor hexadecimal XXXX (por ejemplo, "\u0041" representa el carácter 'A')


¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando utilizas el carácter "@" antes de una cadena de texto en C#, estás creando una cadena literal llamada "cadena literal verbatim". Al utilizar este carácter, se desactivan las secuencias de escape dentro de la cadena, lo que significa que los caracteres de escape como "", "", y otros caracteres especiales se interpretan literalmente como parte de la cadena en lugar de ser tratados como secuencias de escape.

Por otro lado, cuando utilizas el carácter "$" antes de una cadena de texto, estás creando una cadena de interpolación o cadena interpolada. Las cadenas interpoladas permiten incrustar expresiones dentro de la cadena usando la sintaxis ${expresion}.
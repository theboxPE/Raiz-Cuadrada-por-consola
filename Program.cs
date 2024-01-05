// programa que pida al usuario dos numeros al usuario, que realice la raiz cuadrada del primer numero, y realice una  division con el segundo numero y el resultado del cuadrado del primero.

int num;
int num2;
double cuadr2;
double div;

Console.Clear();
Console.WriteLine("Ingrese un primer numero: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

cuadr2 = Math.Pow(num, 2);
Console.WriteLine("el primer numero elevado al cuadrado es {1}", num,cuadr2);
Console.WriteLine();


div = cuadr2/num2;
Console.WriteLine($"La division de {cuadr2} entre {num2} es:" + div);
Console.WriteLine();

Console.WriteLine("Muchas gracias por realizar este ejercicio, hasta la proxima (; ");

Console.ReadKey();



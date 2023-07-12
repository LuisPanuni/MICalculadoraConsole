
Console.WriteLine("¡Bienvenido a la calculadora!");
Console.WriteLine("=============================\n");
Console.WriteLine("Por favor, ingresa el primer numero:");
// Lee la entrada del usuario
string input1 = Console.ReadLine();
Console.WriteLine("Por favor, ingresa el segundo numero:");
// Lee la entrada del usuario
string input2 = Console.ReadLine();
// Intenta convertir la entrada en un número decimal
Console.WriteLine("Elige la operacion (+, -, *, /):");
string operation = Console.ReadLine();

if (decimal.TryParse(input1, out decimal num1) && decimal.TryParse(input2, out decimal num2))
{
    decimal result = 0;

    switch (operation)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return;
            }
            break;
        default:
            Console.WriteLine("Operación inválida. Por favor, elige una operación válida (+, -, *, /).");
            return;
    }

    Console.WriteLine($"El resultado de la operación es: {result}");
}
else
{
    Console.WriteLine("Error: Los números ingresados no son válidos. Asegúrate de ingresar números válidos.");
}

Console.WriteLine("Presiona cualquier tecla para salir.");
Console.ReadKey();
// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma {Environment.OSVersion}");
Console.WriteLine($".NET Verison: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metados configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en Github");
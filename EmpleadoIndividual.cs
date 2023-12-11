// Hoja (Leaf) - Representa un empleado individual
class EmpleadoIndividual : Empleado
{
    public EmpleadoIndividual(string Nombre)
    {
        this.Nombre = Nombre;
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " " + Nombre);
    }
}
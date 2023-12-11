// Composite - Representa un gerente que puede tener subordinados (empleados o gerentes)
class Manager : Empleado
{
    private readonly List<Empleado> _subordinates = new List<Empleado>();

    public Manager(string Nombre)
    {
        this.Nombre = Nombre;
    }
    //Método para añadir empleado
    public void Add(Empleado empleado)
    {
        _subordinates.Add(empleado);
    }
    //Método para eliminar empleado
    public void Remove(Empleado empleado)
    {
        _subordinates.Remove(empleado);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "+ " + Nombre);

        // Recursivamente muestra la estructura de los subordinados
        foreach (var subordinate in _subordinates)
        {
            subordinate.Display(depth + 2);
        }
    }
}

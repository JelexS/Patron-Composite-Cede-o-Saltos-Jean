// Componente base abstracto
abstract class Empleado
{
    public string Nombre { get; set; }
    public abstract void Display(int depth);
}

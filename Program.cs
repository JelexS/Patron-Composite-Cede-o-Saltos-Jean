using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear la estructura organizativa de la empresa
        var ceo = new Manager("CEO");

        var manager1 = new Manager("Manager 1");
        var manager2 = new Manager("Manager 2");

        var employee1 = new EmpleadoIndividual("Employee 1");
        var employee2 = new EmpleadoIndividual("Employee 2");
        var employee3 = new EmpleadoIndividual("Employee 3");

        ceo.Add(manager1);
        ceo.Add(manager2);

        manager1.Add(employee1);
        manager1.Add(employee2);

        manager2.Add(employee3);

        // Mostrar la estructura organizativa
        Console.WriteLine("Estructura Organizativa de la Empresa:");
        ceo.Display(0);
    }
}

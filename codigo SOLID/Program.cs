using System;

namespace codigo_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
           Director Iver=new Director("Iver",44703698,"ayacucho");
           Console.WriteLine(Iver.Trabajo());
           Iver.AñadirEmpleado();
           Console.WriteLine(Iver.NumEmpleados());
           Persona Arturo=new Psicologo("Arturo", 72684539, "coronel Sanchez");
           Console.WriteLine(Arturo.Trabajo());
           Console.WriteLine(Arturo.Sueldo());
           IJefe John= new Director("John", 78963516, "Heroinas");
        }
    }
}

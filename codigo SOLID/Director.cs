namespace codigo_SOLID
{
    public class Director : Persona, IJefe
    {
        int _empleados;
        public Director(string _name, int _telefono, string _direccion)
        {
            this._name = _name;
            this._telefono = _telefono;
            this._direccion = _direccion;
            _sueldo = 10000;
            _trabajo = "Director";
            _empleados = 0;
        }
        
        public override string Trabajo()
        {
            return "Mi trabajo es ser " + _trabajo;
        }
        public override string Sueldo()
        {
            return "Mi sueldo es de " + _sueldo.ToString();
        }
        public void AñadirEmpleado()
        {
            _empleados++;
        }
        public string NumEmpleados()
        {
            return "tengo "+ _empleados.ToString() + " empleados";
        }
    }
}
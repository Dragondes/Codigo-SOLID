namespace codigo_SOLID
{
    public class Profesor : Persona
    {

        public Profesor(string _name, int _telefono, string _direccion)
        {
            this._name = _name;
            this._telefono = _telefono;
            this._direccion = _direccion;
            _sueldo = 5000;
            _trabajo = "Profesor";
        }
        public override string Trabajo()
        {
            return "Mi trabajo es ser " + _trabajo;
        }
        public override string Sueldo()
        {
            return "Mi sueldo es de " + _sueldo.ToString();
        }
    }
}
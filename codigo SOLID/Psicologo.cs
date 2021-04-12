namespace codigo_SOLID
{
    public class Psicologo : Persona
    {
        public Psicologo(string _name, int _telefono, string _direccion)
        {
            this._name = _name;
            this._telefono = _telefono;
            this._direccion = _direccion;
            _sueldo = 20000;
            _trabajo = "Psicologo";
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
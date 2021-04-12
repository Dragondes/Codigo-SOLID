namespace   codigo_SOLID
{
    public abstract class Persona
    {
        protected string _name;
        protected int _telefono;
        protected string _direccion;
        protected int _sueldo;
        protected string _trabajo;
        public abstract string Trabajo();
        public abstract string Sueldo();
        
    }
}
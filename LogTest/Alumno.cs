public class Alumno{
    private int id;
    private string nombre;
    private string apellido;
    private int dni;
    private int curso;
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Dni { get => dni; set => dni = value; }
    public int Curso { get => curso; set => curso = value; }
    public int Id { get => id; set => id = value; }

    public Alumno(){}

    public Alumno(int _id, string _nombre, string _apellido, int _dni, int _curso){
        Id = _id;
        Nombre = _nombre;
        Apellido = _apellido;
        Dni = _dni;
        Curso = _curso;
    }
}
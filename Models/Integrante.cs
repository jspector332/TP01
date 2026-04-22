namespace TP1.Models;

public class Integrante{
    private int dni;
    private string nombre;
    private DateTime fNacimiento;
    private string foto;
    List<string> familiares;
    List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fNacimiento, string foto, List<string> familiares, List<string> intereses){
        this.dni = dni;
        this.nombre = nombre;
        this.fNacimiento = new DateTime(fNacimiento);
        this.foto = foto;
        List<string> familiares = new List<string>;
        List<string> intereses = new List<string>;
    }

    public List<string> getFamiliares(){
        return familiares;
    }

    public List<string> getIntereses(){
        return intereses;
    }

    public int getDni(){
        return this.dni;
    }

    public string getNombre(){
        return this.nombre;
    }

    public int calcularEdad(){
        DateTime hoy = DateTime.Today;
        return hoy - this.fNacimiento;
    }

    public string getFoto(){
        return this.foto + ".jpg"
    }
}
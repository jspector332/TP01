namespace TP1.Models;

public class Integrante{
    private int dni;
    private string nombre;
    private DateTime fNacimiento;
    private string foto;
    List<string> familiares;
    List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fNacimiento, string foto, List<string> familiaresPar, List<string> interesesPar){
        this.dni = dni;
        this.nombre = nombre;
        this.fNacimiento = fNacimiento;
        this.foto = foto;
        familiares = new List<string>(familiaresPar);
        intereses = new List<string>(interesesPar);
    }

    public List<string> getFamiliares(){
        return this.familiares;
    }

    public List<string> getIntereses(){
        return this.intereses;
    }

    public int getDni(){
        return this.dni;
    }

    public string getNombre(){
        return this.nombre;
    }

    public int calcularEdad(){
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - this.fNacimiento.Year;
        return edad;
    }

    public string getFoto(){
        return this.foto + ".jpg";
    }
}
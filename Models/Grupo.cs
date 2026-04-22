namespace TP1.Models;

public class Grupo{
    private Dictionary<int,Integrante> dicIntegrantes;

    public Grupo(){
        
        cargaDatosManual();
    }

    public void cargaDatosManual(){
        dicIntegrantes = new Dictionary<int,Integrante>();
        List<string> familiaresPar = new List<string> { "Russo", "Silvia" };
        List<string> interesesPar = new List<string> { "Futbol", "Padel" };
        List<string> familiaresDri = new List<string> { "Chacho", "Romina" };
        List<string> interesesDri = new List<string> { "Futbol", "Lesionarse" };
        DateTime nac1 = new DateTime(2009,02,25);
        DateTime nac2 = new DateTime(2018,12,09);
        dicIntegrantes.Add(1, new Integrante(1, "Paredes", nac1, "fotoParedes", familiaresPar, interesesPar));
        dicIntegrantes.Add(2, new Integrante(2, "Drussi", nac2, "fotoDriussi", familiaresDri, interesesDri));
    }

    public Dictionary<int, Integrante> devolverIntegrantes(){
        return dicIntegrantes;
    }

    public Integrante getIntegrante(int dni){
        if(dicIntegrantes.ContainsKey(dni)){
            return dicIntegrantes[dni];
        }
        else{
            return null;
        }
    }
}
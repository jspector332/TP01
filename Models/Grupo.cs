namespace TP1.Models;

public class Grupo{
    private Dictionary<int,Integrante> dicIntegrantes;

    public Grupo(){
        Dictionary<int,Integrante> dicIntegrantes = new Dictionary<int,Integrante>();
        cargaDatosManual();
    }

    public void cargaDatosManual(){
        dicIntegrantes.Add(1, new Integrante(1, "Paredes", (2009,02,25), "fotoParedes", getFamiliares().Add("Papa:Russo", "Mama:Silvia"), getIntereses().Add("Futbol", "Padel")));
        dicIntegrantes.Add(2, new Integrante(2, "Drussi", (2018,12,09), "fotoDriussi", getFamiliares().Add("Papa:Chacho", "Mama:Romina"), getIntereses().Add("Futbol", "Lesionarse")));
        dicIntegrantes.Add(3, new Integrante(3, "LaCobra", (2014,11,27), "fotoCobra", getFamiliares().Add("Papa:Julian Alvarez", "Mama:Teode412"), getIntereses().Add("Ver Futbol", "Stremear")));
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
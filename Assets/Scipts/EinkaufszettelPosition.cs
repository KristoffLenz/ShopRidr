using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EinkaufszettelPosition : MonoBehaviour
{
    int anzahl = 1;
    bool erledigt=false;
    string artikelname;

    public EinkaufszettelPosition(string name)
    {
        this.artikelname = name;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void toggleErledigt()
    {
        erledigt = !erledigt;
    }
    public bool getArtikelErledigt()
    {
        return erledigt;
    }
    public int getAnzahl()
    {
        return anzahl;
    }
    public string getArtikelname()
    {
        return artikelname;
    }
    public void setAnzahl(int an)
    {
        anzahl = an;
    }
}

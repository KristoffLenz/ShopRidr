using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EinkaufszettelPosition : MonoBehaviour {
    int anzahl;
    bool erledigt;
    string artikelname;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void toggleErledigt()
    {

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
}

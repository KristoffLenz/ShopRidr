using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artikel : MonoBehaviour {

    EnumArtikelkategorie artikelkategorie;
    string artikelname;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string getName()
    {
        return this.artikelname;
    }
    public void setName(string neuerName)
    {
        this.artikelname = neuerName;
    }
    public string getKategorie()
    {
        string kategorie= null;
        return kategorie;
    }
    public void anzeigen()
    {

    }
}

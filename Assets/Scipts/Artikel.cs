using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artikel : MonoBehaviour {

    EnumArtikelkategorie artikelkategorie;
    string bezeichnung;
    string marke;
    public UnityEngine.UI.Text UIBezeichnung;
    public UnityEngine.UI.Text UIMarke;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string getName()
    {
        return this.bezeichnung;
    }
    public void setName(string neuerName)
    {
        this.bezeichnung = neuerName;
    }
    public string getKategorie()
    {
        string kategorie= null;
        return kategorie;
    }
    public void anzeigen()
    {

    }

    public void anzeigeLöschen()
    {
        UIBezeichnung.text = "";
        UIMarke.text = "";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artikel : MonoBehaviour {

    EnumArtikelkategorie artikelkategorie;
    string name;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string getName()
    {
        return this.name;
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

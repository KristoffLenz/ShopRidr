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

    public void init(string pBezeichnung, string pMarke)
    {
        UnityEngine.UI.Text[] textFields = FindObjectsOfType<UnityEngine.UI.Text>();
        if (textFields[0].name == "Bezeichnung")
        {
            UIBezeichnung = textFields[0];
            UIMarke = textFields[1];
        }
        else
        {
            UIBezeichnung = textFields[1];
            UIMarke = textFields[0];
        }
        bezeichnung = pBezeichnung;
        marke = pMarke;
        UIBezeichnung.text = bezeichnung;
        UIMarke.text = marke;
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

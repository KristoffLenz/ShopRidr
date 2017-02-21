using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    int levelNummer;
    int anzahlEinkaufszettel;
    int anzahlRegale;
    int anzahlWegpunkte;
    int anzahlArtikelkategorien;
    int anzahlAusgänge;
    int anzahlKassen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public Einkaufszettel erzeugeEinkaufszettel()
    {
        Einkaufszettel neuerEinkaufszettel= null;
        return neuerEinkaufszettel;
    }
    public Regal erzeugeRegale()
    {
        Regal neuesRegal = null;
        return neuesRegal;
    }
    public Kasse erzeugeKassen()
    {
        Kasse neueKasse = null;
        return neueKasse;
    }
}

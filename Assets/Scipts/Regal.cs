using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Regal : MonoBehaviour {

    EnumArtikelkategorie artikelkategorie;
    private enum ausrichtung { senkrecht_rechts,senkrecht_links, waagrecht_oben, waagrechts_unten};
    int positionX;
    int positionY;
    int länge;


    // Use this for initialization
    void Start () {

        string fachBezeichnung;
        GameObject artikel = GameObject.FindGameObjectWithTag("Artikel");

        for (int ebenenNr = 1; ebenenNr <= 4; ebenenNr++)
        {
            for(int fachNr = 1; fachNr <= 5; fachNr++)
            {
                if(ebenenNr == 1 && fachNr == 1)
                {
                    fachNr++;
                }
                fachBezeichnung = "Fach - " + ebenenNr + "/" + fachNr;
                GameObject fach = GameObject.Find(fachBezeichnung);
                GameObject artikel2 = Instantiate(artikel, fach.transform);
                artikel = artikel2;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void anzeigen()
    {

    }
}

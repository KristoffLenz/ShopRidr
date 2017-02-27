using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour {

    int levelNummer;
    int anzahlEinkaufszettel;
    int anzahlRegale;
    int anzahlWegpunkte;
    int anzahlArtikelkategorien;
    int anzahlAusgänge;
    int anzahlKassen;
    public static ArrayList zettel1;

	// Use this for initialization
	void Awake() {
        
        Debug.Log("Artikel werden angelegt");
        
        // zum Testen
        zettel1 = new ArrayList();
        ArrayList zettel2 = new ArrayList();
        ArrayList zettel3 = new ArrayList();
        ArrayList zettel4 = new ArrayList();


        EinkaufszettelPosition artikel1 = new EinkaufszettelPosition("Apfel");
        EinkaufszettelPosition artikel2 = new EinkaufszettelPosition("Salat");
        EinkaufszettelPosition artikel3 = new EinkaufszettelPosition("Trauben");
        EinkaufszettelPosition artikel4 = new EinkaufszettelPosition("Brezel");
        EinkaufszettelPosition artikel5 = new EinkaufszettelPosition("Multivitaminsaft");
        EinkaufszettelPosition artikel6 = new EinkaufszettelPosition("Sekt");
        EinkaufszettelPosition artikel7 = new EinkaufszettelPosition("Kartoffeln");
        EinkaufszettelPosition artikel8 = new EinkaufszettelPosition("Ananas");
        EinkaufszettelPosition artikel9 = new EinkaufszettelPosition("Zucchini");
        EinkaufszettelPosition artikel10 = new EinkaufszettelPosition("Wasser");
        EinkaufszettelPosition artikel11 = new EinkaufszettelPosition("Cola");
        EinkaufszettelPosition artikel12 = new EinkaufszettelPosition("Gurke");
        EinkaufszettelPosition artikel13 = new EinkaufszettelPosition("Tomate");
        EinkaufszettelPosition artikel14 = new EinkaufszettelPosition("Pomelo");
        EinkaufszettelPosition artikel15 = new EinkaufszettelPosition("Fanta");
        EinkaufszettelPosition artikel16 = new EinkaufszettelPosition("Banane");
        EinkaufszettelPosition artikel17 = new EinkaufszettelPosition("Brot");
        EinkaufszettelPosition artikel18 = new EinkaufszettelPosition("Muffin");
        EinkaufszettelPosition artikel19 = new EinkaufszettelPosition("Bier");
        EinkaufszettelPosition artikel20 = new EinkaufszettelPosition("Birne");

        zettel1.Add(artikel1);
        zettel1.Add(artikel2);
        zettel1.Add(artikel3);
        zettel1.Add(artikel4);
        zettel1.Add(artikel5);
       

        zettel2.Add(artikel6);
        zettel2.Add(artikel7);
        zettel2.Add(artikel8);
        zettel2.Add(artikel9);
        zettel2.Add(artikel10);
        zettel2.Add(artikel11);
        zettel2.Add(artikel12);


        zettel3.Add(artikel13);
        zettel3.Add(artikel14);
        zettel3.Add(artikel15);
        zettel3.Add(artikel16);
        zettel3.Add(artikel17);
        zettel3.Add(artikel18);

        zettel4.Add(artikel19);
        zettel4.Add(artikel20);


        LinkedList<string> auftraggeber = new LinkedList<string>();
        auftraggeber.AddFirst("Maier");
        auftraggeber.AddLast("Müller");
        auftraggeber.AddLast("Schmidt");
        auftraggeber.AddLast("Bauer");

        new Einkaufszettel(zettel1,"Maier", auftraggeber,0);
        new Einkaufszettel(zettel2,"Müller",auftraggeber,-1000);
        new Einkaufszettel(zettel3,"Schmidt",auftraggeber,-1000);
        new Einkaufszettel(zettel4,"Bauer",auftraggeber,-1000);
    }
	
	// Update is called once per frame
	
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

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{

    int levelNummer;
    int anzahlEinkaufszettel;
    int anzahlRegale;
    int anzahlWegpunkte;
    int anzahlArtikelkategorien;
    int anzahlAusgänge;
    int anzahlKassen;
    Einkaufszettel ersterZe;
    Einkaufszettel zweiterZe;
    Einkaufszettel dritterZe;
    Einkaufszettel vierterZe;
    ArrayList zettel1;
    ArrayList zettel2;
    ArrayList zettel3;
    ArrayList zettel4;
    ArrayList auftraggeber;
    ArrayList sammlungEinkaufszettel;

    // Use this for initialization
    void Awake()
    {

        Debug.Log("Artikel werden angelegt");

        // zum Testen
        zettel1 = new ArrayList();
        zettel2 = new ArrayList();
        zettel3 = new ArrayList();
        zettel4 = new ArrayList();


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


        auftraggeber = new ArrayList();
        auftraggeber.Add("Maier");
        auftraggeber.Add("Müller");
        auftraggeber.Add("Schmidt");
        auftraggeber.Add("Bauer");

        ersterZe = new Einkaufszettel(zettel1, "Maier", auftraggeber, true);
        zweiterZe = new Einkaufszettel(zettel2, "Müller", auftraggeber, false);
        dritterZe = new Einkaufszettel(zettel3, "Schmidt", auftraggeber, false);
        vierterZe = new Einkaufszettel(zettel4, "Bauer", auftraggeber, false);

        sammlungEinkaufszettel = new ArrayList();
        sammlungEinkaufszettel.Add(ersterZe);
        sammlungEinkaufszettel.Add(zweiterZe);
        sammlungEinkaufszettel.Add(dritterZe);
        sammlungEinkaufszettel.Add(vierterZe);
    }

    // Update is called once per frame

    public Einkaufszettel erzeugeEinkaufszettel()
    {
        Einkaufszettel neuerEinkaufszettel = null;
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

    public void zettelWechseln()
    {
        GameObject button = EventSystem.current.currentSelectedGameObject;
        string Buttontext = button.GetComponentInChildren<Text>().text;

        foreach (Einkaufszettel z in sammlungEinkaufszettel)
        {
            if (z.zeigen)
            {
                Debug.Log("Zerstören");
                z.destroyAnsicht();

            }
            z.zeigen = false;
        }
        if (Buttontext.Equals(auftraggeber[0]))
        {
            Debug.Log("Auftraggeber 1");
            ersterZe.zeigen = true;
            ersterZe.anzeigen();
        }
        else if (Buttontext.Equals(auftraggeber[1]))
        {
            Debug.Log("Auftraggeber 2");
            zweiterZe.zeigen = true;
            zweiterZe.anzeigen();

        }
        else if (Buttontext.Equals(auftraggeber[2]))
        {
            Debug.Log("Auftraggeber 3");
            dritterZe.zeigen = true;
            dritterZe.anzeigen();

        }
        else
        {
            Debug.Log("Auftraggeber 4");
            vierterZe.zeigen = true;
            vierterZe.anzeigen();
        }

        //SceneView.RepaintAll();
    }
    public void artikelErledigtSetzen()
    {
        ArrayList toggles;
        ArrayList zettel;

        if (ersterZe.zeigen)
        {
            toggles = ersterZe.toggles;
            zettel = zettel1;
        }
        else if (zweiterZe.zeigen)
        {
            toggles = zweiterZe.toggles;
            zettel = zettel2;
        }
        else if (dritterZe.zeigen)
        {
            toggles = dritterZe.toggles;
            zettel = zettel3;
        }
        else
        {

            toggles = vierterZe.toggles;
            zettel = zettel4;
        }
        GameObject gewählterToggle = EventSystem.current.currentSelectedGameObject;

        int positionToggle = toggles.IndexOf(gewählterToggle);
        if (positionToggle >= 0)
        {
            EinkaufszettelPosition artikelÄndern = (EinkaufszettelPosition)zettel[positionToggle];

            artikelÄndern.toggleErledigt();
        }
    }
}

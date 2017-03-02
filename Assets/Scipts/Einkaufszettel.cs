using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Einkaufszettel : MonoBehaviour
{

    string auftraggeber;
    int nrArtikel = 0;
    int abstandArtikelY = 875;
    public GameObject einkaufszettelName;
    public GameObject prefabToggle;
    public GameObject prefabButton;
    public GameObject parentPanelGo;
    public RectTransform parentPanel;
    public GameObject prefabArtikelText;
    ArrayList auftraggListe;
    ArrayList zettel = new ArrayList();
   public  ArrayList toggles = new ArrayList();
   public  ArrayList texts = new ArrayList();
    public bool zeigen;
    GameObject goButton;
    GameObject positionZettel;


    public Einkaufszettel(ArrayList ze, string auftr, ArrayList listeAuftr, bool zeigen)
    {
        auftraggListe = listeAuftr;
        zettel = ze;
        auftraggeber = auftr;
        this.zeigen = zeigen;
        einkaufszettelName = GameObject.FindWithTag("EinkaufszettelName");
        prefabArtikelText = GameObject.FindWithTag("PrefabArtikeltext");
        prefabToggle = GameObject.FindWithTag("PrefabToggle");
        parentPanelGo = GameObject.FindWithTag("ParentPanel");
        parentPanel = (RectTransform)parentPanelGo.transform;
        prefabButton = GameObject.FindWithTag("PrefabButton");
        positionZettel = GameObject.FindWithTag("PositionZettel");

        System.Random zufall = new System.Random();
        foreach (EinkaufszettelPosition ein in zettel)
        {

            int number = zufall.Next(1, 5);
            ein.setAnzahl(number);
        }
        if (zeigen)
        {
            anzeigen();
        }


    }

    public void anzeigen()
    {
        einkaufszettelName.GetComponent<Text>().text = auftraggeber;
        

        int positionAuftraggeber = auftraggListe.IndexOf(auftraggeber);

        positionZettel.GetComponent<Text>().text = "Einkaufszettel " + (positionAuftraggeber + 1) + " / " + auftraggListe.Count;

        goButton = (GameObject)Instantiate(prefabButton);
        goButton.transform.SetParent(parentPanel, false);

        goButton.transform.position = new Vector3(250, 600, 0);

        if (positionAuftraggeber == 0)
        {
            prefabButton.GetComponentInChildren<Text>().text = (String)auftraggListe[1];
            goButton.GetComponentInChildren<Text>().text = (String)auftraggListe[3];
        }
        else if (positionAuftraggeber == 1)
        {
            prefabButton.GetComponentInChildren<Text>().text = (String)auftraggListe[2];
            goButton.GetComponentInChildren<Text>().text = (String)auftraggListe[0];
        }
        else if (positionAuftraggeber == 2)
        {
            prefabButton.GetComponentInChildren<Text>().text = (String)auftraggListe[3];
            goButton.GetComponentInChildren<Text>().text = (String)auftraggListe[1];
        }
        else
        {
            prefabButton.GetComponentInChildren<Text>().text = (String)auftraggListe[0];
            goButton.GetComponentInChildren<Text>().text = (String)auftraggListe[2];
        }

        foreach (EinkaufszettelPosition s in zettel)
        {
            
            if (nrArtikel != 0)
            {
                GameObject goArtikel = (GameObject)Instantiate(prefabArtikelText);
                goArtikel.transform.SetParent(parentPanel, false);

                goArtikel.transform.position = new Vector3(637, abstandArtikelY, 0);
                goArtikel.GetComponent<Text>().text = s.getAnzahl() + " x " + s.getArtikelname();

                GameObject goToggle = (GameObject)Instantiate(prefabToggle);
                goToggle.transform.SetParent(parentPanel, false);
                goToggle.transform.position = new Vector3(1480, abstandArtikelY - 15, 0);
                goToggle.GetComponent<Toggle>().isOn = s.getArtikelErledigt();
                texts.Add(goArtikel);
                toggles.Add(goToggle);
            }
            else
            {
                prefabArtikelText.GetComponent<Text>().text = s.getAnzahl() + " x " + s.getArtikelname();
                prefabToggle.GetComponent<Toggle>().isOn = s.getArtikelErledigt();
                texts.Add(prefabArtikelText);
                toggles.Add(prefabToggle);

            }
            Debug.Log(""+ s.getArtikelname());
            abstandArtikelY = abstandArtikelY - 80;
            nrArtikel++;
        }
        nrArtikel = 0;
        abstandArtikelY = 833;
    }

    public void destroyAnsicht()
    {
        int i = 0;
        foreach (GameObject t in toggles)
        {   if (i != 0)
            {
                Destroy(t.gameObject);
            }
            i++;
        }
       
        int b = 0;
        foreach (GameObject t in texts)
        {
            if (b != 0)
            {
                Destroy(t.gameObject);
            }
            b++;
        }
       

        Destroy(goButton.gameObject);
        toggles.Clear();
        texts.Clear();
    }
   
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Einkaufszettel : MonoBehaviour {

    string auftraggeber;
    int nrArtikel = 0;
    int abstandArtikelY = 833;
    int abstandAuftraggeberY = 780;
    public GameObject einkaufszettelName;
    public GameObject prefabToggle;
    public GameObject prefabButton;
    public GameObject parentPanelGo;
    public RectTransform parentPanel;
    public GameObject prefabArtikelText;
    LinkedList<string> auftraggListe;
    ArrayList zettel = new ArrayList();
    ArrayList toggles = new ArrayList();
    ArrayList texts = new ArrayList();
    bool geladen = false;

   


   
    public Einkaufszettel(ArrayList ze, string auftr, LinkedList<string> listeAuftr, int posPanel)
    {
        auftraggListe = listeAuftr;
        zettel = ze;
        auftraggeber = auftr;

        einkaufszettelName = GameObject.FindWithTag("EinkaufszettelName");
        prefabArtikelText = GameObject.FindWithTag("PrefabArtikeltext");
        prefabToggle = GameObject.FindWithTag("PrefabToggle");
        parentPanelGo = GameObject.FindWithTag("ParentPanel");
        parentPanel = (RectTransform)parentPanelGo.transform;

       
        System.Random zufall = new System.Random();
        foreach (EinkaufszettelPosition ein in zettel)
        {
            
            int number = zufall.Next(1, 5);
            ein.setAnzahl(number);
            Debug.Log("" + number);
        }
        if (posPanel == 0)
        {
            anzeigen();
        }
        
        
    }
 
    public void anzeigen()
    {
        einkaufszettelName.GetComponent<Text>().text = auftraggeber; 
            zettel = Level.zettel1;
            foreach (EinkaufszettelPosition s in zettel)
            {
            Debug.Log("Geht");
                if (nrArtikel != 0)
                {
                    GameObject goArtikel = (GameObject)Instantiate(prefabArtikelText);
                    goArtikel.transform.SetParent(parentPanel, false);
                   
                    goArtikel.transform.position = new Vector3(617, abstandArtikelY, 0);
                    goArtikel.GetComponent<Text>().text = s.getAnzahl() + " x " + s.getArtikelname();

                    GameObject goToggle = (GameObject)Instantiate(prefabToggle);
                    goToggle.transform.SetParent(parentPanel, false);
                    goToggle.transform.position = new Vector3(1455, abstandArtikelY -15, 0);
                    goToggle.GetComponent<Toggle>().isOn = s.getArtikelErledigt();
                    texts.Add(goArtikel);
                    toggles.Add(goToggle);
                }
                else
                {
                    Debug.Log("Prefabartikel2" + prefabArtikelText);
                   
                    prefabArtikelText.GetComponent<Text>().text = s.getAnzahl() + " x " + s.getArtikelname();
                    prefabToggle.GetComponent<Toggle>().isOn = s.getArtikelErledigt();
                    texts.Add(prefabArtikelText);
                    toggles.Add(prefabToggle);
                }
                abstandArtikelY = abstandArtikelY - 80;
                nrArtikel++;
            }
        }
    }


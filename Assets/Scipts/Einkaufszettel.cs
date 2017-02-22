using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Einkaufszettel : MonoBehaviour {

    string auftraggeber;
    int nrArtikel = 0;
    int abstandArtikelY = 1180;
    int abstandAuftraggeberY = 780;
    public Text einkaufszettelName;
    public GameObject prefabToggle;
    public GameObject prefabButton;
    public RectTransform parentPanel;
    public GameObject prefabArtikelText;
    ArrayList zettel = new ArrayList();
    ArrayList toggles = new ArrayList();
    ArrayList texts = new ArrayList();


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void anzeigen()
    {
        foreach (EinkaufszettelPosition s in zettel)
        {
            if (nrArtikel != 0)
            {
                GameObject goArtikel = (GameObject)Instantiate(prefabArtikelText);
                goArtikel.transform.SetParent(parentPanel, false);
                goArtikel.transform.position = new Vector3(960, abstandArtikelY, 0);
                goArtikel.GetComponent<Text>().text = s.getAnzahl() + " x " + s.getArtikelname();

                GameObject goToggle = (GameObject)Instantiate(prefabToggle);
                goToggle.transform.SetParent(parentPanel, false);
                goToggle.transform.position = new Vector3(2005, abstandArtikelY + 10, 0);
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
            abstandArtikelY = abstandArtikelY - 130;
            nrArtikel++;
        }
    }
}

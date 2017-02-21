using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenHandler : MonoBehaviour {

    public RectTransform einkaufszettelansicht;
    public RectTransform navigationsansicht;
    public RectTransform regalansicht;

	public void changeSceneToNavigationsansicht()
    {
        RectTransform panelAktuell;
        if (einkaufszettelansicht.GetComponent<RectTransform>().position== new Vector3(424.50F,158.5F,0))
        {
            panelAktuell = einkaufszettelansicht;
        }else
        {
            panelAktuell = regalansicht;
        }
        navigationsansicht.GetComponent<RectTransform>().transform.position = panelAktuell.GetComponent<RectTransform>().transform.position;
        panelAktuell.GetComponent<RectTransform>().transform.position = new Vector3(-1000, -1000, 0);
    }

    public void changeSceneToRegalansicht()
    {
        RectTransform panelAktuell;
        if (einkaufszettelansicht.GetComponent<RectTransform>().position == new Vector3(424.50F, 158.5F, 0))
        {
            panelAktuell = einkaufszettelansicht;
        }
        else
        {
            panelAktuell = navigationsansicht;
        }
        regalansicht.GetComponent<RectTransform>().transform.position = panelAktuell.GetComponent<RectTransform>().transform.position;
        panelAktuell.GetComponent<RectTransform>().transform.position = new Vector3(-1000, -1000, 0);
    }
    public void changeSceneToEinkaufszettelansicht()
    {
        RectTransform panelAktuell;
        if (regalansicht.GetComponent<RectTransform>().position == new Vector3(424.50F, 158.5F, 0))
        {
            panelAktuell = regalansicht;
        }
        else
        {
            panelAktuell = navigationsansicht;
        }
        einkaufszettelansicht.GetComponent<RectTransform>().transform.position = panelAktuell.GetComponent<RectTransform>().transform.position;
        panelAktuell.GetComponent<RectTransform>().transform.position = new Vector3(-1000, -1000, 0);
    }
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

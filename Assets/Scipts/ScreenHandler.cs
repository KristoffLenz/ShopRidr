using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenHandler : MonoBehaviour
{

    public RectTransform einkaufszettelansicht;
    public RectTransform navigationsansicht;
    public RectTransform regalansicht;

    public void changeSceneToNavigationsansicht()
    {
        Debug.Log("ChangeToNavigationsansicht");
        RectTransform panelAktuell;
        if (einkaufszettelansicht.GetComponent<RectTransform>().position == new Vector3(400, 126, 100))
        {
            panelAktuell = einkaufszettelansicht;
        }
        else
        {
            panelAktuell = regalansicht;
        }
        navigationsansicht.GetComponent<RectTransform>().transform.position = panelAktuell.GetComponent<RectTransform>().transform.position;
        panelAktuell.GetComponent<RectTransform>().transform.position = new Vector3(-1000, -1000, 0);
    }

    public void changeSceneToRegalansicht()
    {
        Debug.Log("ChangeToRegalansicht");
        RectTransform panelAktuell;
        if (einkaufszettelansicht.GetComponent<RectTransform>().position == new Vector3(400, 126, 100))
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
        Debug.Log("ChangeToEinkaufszettelansicht");
        RectTransform panelAktuell;
        if (regalansicht.GetComponent<RectTransform>().position == new Vector3(400, 126, 100))
        {
            panelAktuell = regalansicht;
        }
        else
        {
            panelAktuell = navigationsansicht;

        }
        einkaufszettelansicht.GetComponent<RectTransform>().transform.position = panelAktuell.GetComponent<RectTransform>().transform.position;
        panelAktuell.GetComponent<RectTransform>().transform.position = new Vector3(-1000, -1000, 0);
        Debug.Log("Position" + einkaufszettelansicht.GetComponent<RectTransform>().transform.position);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


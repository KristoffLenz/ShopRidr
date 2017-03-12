using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Einkaufswagen : MonoBehaviour, IHasChanged
{
    int positionX;
    int positionY;
    [SerializeField]
    ArrayList laderaum = new ArrayList();
    [SerializeField]
    Transform faecher;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //vermutlich im MoveHandler
    public void bewegen()
    {

    }
    public void inhaltAnzeigen()
    {

    }
    //vermutlich im DragHandler
    public void artikelZurücklegen()
    {

    }
    // vermutlich im DragHandler
    public void artikelInWagenLegen()
    {

    }
    public void setPositionX(int neuePosition)
    {
        this.positionX = neuePosition;
    }
    public void setPositionY(int neuePosition)
    {
        this.positionY = neuePosition;
    }
    public int getPositionX()
    {
        return positionX;
    }
    public int getPositionY()
    {
        return positionY;
    }

    #region IHasChanged implementation
    /**
    * Fügt Artikel dem Einkaufswagen hinzu.
    */
    public void HasChanged()
    {

        foreach (Transform slotTransform in faecher)
        {
            GameObject artikel = slotTransform.GetComponent<Fach>().artikel;

            if (artikel)
            {
                laderaum.Insert(0, artikel);
                artikel.GetComponent<Image>().enabled = false;
                artikel.GetComponent<Artikel>().anzeigeLöschen();
            }

        }

    }
    #endregion
}

namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();
    }
}

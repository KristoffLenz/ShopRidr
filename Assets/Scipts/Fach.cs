using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Fach : MonoBehaviour, IDropHandler
{
    private ArrayList inhalt = new ArrayList();
    /**
    * Gibt die Referenz auf Artikel des Slots zurück. Bei mehreren nach LA-FI.
    */
    public GameObject artikel
    {
        get
        {
            if (transform.childCount > 0)
            {
                Debug.Log(transform.childCount);
                if(transform.childCount > 1)
                {
                    transform.GetChild(1).gameObject.SetActive(true);
                }
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
    #region IDropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(transform.childCount - 1).gameObject.SetActive(false);                     
        }
        DragHandler.itemBeingDragged.transform.SetParent(transform);
        ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
    }
    #endregion

    public void artikelHinzufügen(GameObject pArtikel)
    {
        pArtikel.transform.parent = transform;
    }
}

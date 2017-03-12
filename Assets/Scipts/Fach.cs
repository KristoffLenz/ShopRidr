using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Fach : MonoBehaviour, IDropHandler
{

    /**
    * Gibt die Referenz auf Artikel des Slots zurück. Bei mehreren nach LA-FI.
    */
    public GameObject artikel
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(transform.childCount - 1).gameObject;
            }
            return null;
        }
    }
    #region IDropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {

        {
            DragHandler.itemBeingDragged.transform.SetParent(transform);
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
        }
    }
    #endregion

}

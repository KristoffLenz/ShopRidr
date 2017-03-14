using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Einkaufswagen : MonoBehaviour {
    int positionX;
    int positionY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
}

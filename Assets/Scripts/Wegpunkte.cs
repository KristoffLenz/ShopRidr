using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wegpunkte : MonoBehaviour {

    int positionX;
    int positionY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public int getPositionX()
    {
        return positionX;
    }
    public int getPositionY()
    {
        return positionY;
    }

    public void setPositionX(int neuePosition)
    {
        this.positionX = neuePosition;
    }
    public void setPositionY(int neuePosition)
    {
        this.positionY = neuePosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBuilder : MonoBehaviour {

    public Transform tile;
    public int beginX;
    public int y;
    public int amount;

    public void BuildTiles ()
    {

        int endX = beginX + amount;
	    while(beginX < endX)
	    {
	        //Instantiate(Resources.Load("Regal"));
	        Instantiate(tile, new Vector3(0.5F + beginX++, 0.5F + y, 0), Quaternion.identity);
	    }

	}

}

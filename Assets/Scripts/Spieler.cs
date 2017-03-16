using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour {
    string spielername;
    int punkte;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setName(string neuerName)
    {
        this.spielername = neuerName;
    }
    public string getName()
    {
        return spielername;
    }
}

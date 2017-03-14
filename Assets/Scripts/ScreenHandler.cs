using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenHandler : MonoBehaviour
{

    public RectTransform einkaufszettelansicht;
    public RectTransform navigationsansicht;
    public RectTransform regalansicht;

    public void changeSceneToNavigationsansicht()
    {
        Debug.Log("ChangeToNavigationsansicht");
        SceneManager.LoadScene("Navigationsansicht");
    }

    public void changeSceneToRegalansicht()
    {
        Debug.Log("ChangeToRegalansicht");
        SceneManager.LoadScene("Regalansicht");
    }
    public void changeSceneToEinkaufszettelansicht()
    {
        Debug.Log("ChangeToEinkaufszettelansicht");
        SceneManager.LoadScene("Einkaufszettelansicht");
    }
    
    public void zurück(string szene)
    {
        Debug.Log("ChangeToLastScene");
        SceneManager.LoadScene(szene);
        
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


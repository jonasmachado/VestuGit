using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ViewController : MonoBehaviour {
    public GameObject videoFundo;
    public GameObject[] views;
    //private GameObject controller;
    // Use this for initialization
    void Start () {
        videoFundo = GameObject.Find("videoFundo");
      //  controller = GameObject.Find("Controller");
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    public void leavePresentationView(string viewDestino)
    {
       videoFundo.SetActive(false);
       goView(viewDestino);   
    }

    public void goView(string viewName)
    {

        if (viewName.Equals("SceneAjusteCorporal"))
        {
            SceneManager.LoadScene("AjusteCorporal");
            return;
        }
        else if (viewName.Equals("SceneProvador"))
        {
            SceneManager.LoadScene("Provador");
            return;
        }

        foreach (GameObject view in views)
        {
           
            if (view.name.Equals(viewName))
                view.SetActive(true);
            else
                view.SetActive(false);
        }
    }
}

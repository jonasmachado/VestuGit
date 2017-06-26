using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClothController : MonoBehaviour {

    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    { 
        //gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void mudaRoupa()
    {
        GameObject.Find("roupa").GetComponent<Renderer>().material.mainTexture = this.gameObject.GetComponent<Image>().mainTexture;
    }
}

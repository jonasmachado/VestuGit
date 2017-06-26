using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideScrollResizer : MonoBehaviour {
    RectTransform rectTransform;
    Vector2 deltaInicial;
    // Use this for initialization
    void Start () {
        rectTransform = GetComponent<RectTransform>();
        deltaInicial = rectTransform.sizeDelta;
        float x = deltaInicial.x * 2;
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(x,x);
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log("tamanho = " + gameObject.GetComponent<RectTransform>().sizeDelta.y);
    //    gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(deltaInicial.x, 100);//new Vector2(deltaInicial.x, deltaInicial.y / 8 * transform.childCount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagemCatalogo : MonoBehaviour {

    RectTransform rt;
    RectTransform rtCanvas;
	void Start () {
        rt = gameObject.GetComponent<RectTransform>();
        rtCanvas = GameObject.Find("PainelPrincipalCatalogo").GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        rt.sizeDelta = new Vector2(rtCanvas.rect.width / 4, rt.rect.height);
	}
}

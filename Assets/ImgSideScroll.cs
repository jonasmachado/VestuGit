using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImgSideScroll : MonoBehaviour
{
    public RectTransform parentRect;
    // Use this for initialization
    void Start()
    {
       // parentRect = transform.parent.GetComponent<RectTransform>();
        gameObject.GetComponent<RectTransform>().sizeDelta = parentRect.sizeDelta / 8;
        transform.parent.GetComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
       

    }

    public void aplicaRoupa()
    {
        //deve alterar o primeiro item da lista de roupas da lateral, para a roupa escolhida nesta tela
    }
}

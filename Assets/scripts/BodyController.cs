using MORPH3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyController : MonoBehaviour {
    private M3DCharacterManager CorpoCtrl;
    private Slider slider;

	// Use this for initialization
	void Start () {
        CorpoCtrl = GameObject.Find("avatar").GetComponent<M3DCharacterManager>();
        slider = gameObject.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void controlaGordura()
    {
        CorpoCtrl.SetBlendshapeValue("FBMHeavy", slider.value);
    }

    public void controlaAntebraco()
    {
        CorpoCtrl.SetBlendshapeValue("PBMForearmsSize", slider.value);
    }

    public void controlaPerna()
    {
        if(slider.value < 0)
            CorpoCtrl.SetBlendshapeValue("PBMThighsSize_NEGATIVE_", slider.value * -1);
        else
            CorpoCtrl.SetBlendshapeValue("PBMThighsSize", slider.value);
    }

    public void controlaPearFigure()
    {
        CorpoCtrl.SetBlendshapeValue("FBMPearFigure", slider.value);
    }

    public void controlaBusto()
    {
        if (slider.value < 0)
            CorpoCtrl.SetBlendshapeValue("PBMBreastsSmall", slider.value * -1);
        else
            CorpoCtrl.SetBlendshapeValue("PBMBreastsSize", slider.value);
    }
    
    public void salvaValorPernas()
    {
        if (slider.value < 0)
        {
            BodyAtributesController bac = GameObject.Find("Controller").GetComponent<BodyAtributesController>();
            bac.valores.Add("PBMThighsSize_NEGATIVE_" + '#' + (slider.value*(-1)).ToString());
            bac.procurarAvatar = true;
        }
        else
            salvaValor("PBMThighsSize");
    }

    public void salvaValorBusto()
    {
        if (slider.value < 0)
        {
            BodyAtributesController bac = GameObject.Find("Controller").GetComponent<BodyAtributesController>();
            bac.valores.Add("PBMBreastsSmall" + '#' + (slider.value * (-1)).ToString());
            bac.procurarAvatar = true;
        }
        else
            salvaValor("PBMBreastsSize");
    }

    public void salvaValor(string atributo)
    {
        try
        {
            BodyAtributesController bac = GameObject.Find("Controller").GetComponent<BodyAtributesController>();
            bac.valores.Add(atributo + '#' + slider.value.ToString());
            bac.procurarAvatar = true;
        }
        catch(UnityException ue)
        {
            Debug.LogWarning(ue);
        }
    }
}

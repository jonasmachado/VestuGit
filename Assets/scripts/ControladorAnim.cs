using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnim : MonoBehaviour {

    public GameObject menuDireita;
    Animation rightMenuAnim;
    bool mostrando;
	// Use this for initialization
	void Start () {
	}
	
    public void playEntraSaiMenuDireita()
    {
        menuDireita.SetActive(true);

        if (mostrando)
        {
            rightMenuAnim.Play("SaiMenuDireita");
            mostrando = false;
        }
        else
        {
            rightMenuAnim.Play("EntraMenuDireita");
            mostrando = true;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour {

    Animator anim;
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	public void setAnimatorState(int valor)
    {
        anim.SetInteger("estado", valor);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redirect : MonoBehaviour {
    public bool direcionarProvadorNoStart;
    // Use this for initialization
    void Start() {
        if (direcionarProvadorNoStart)
            SceneManager.LoadScene("Provador");
    }

    public void goScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

using MORPH3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BodyAtributesController : MonoBehaviour {
    public List<string> valores;
    public bool procurarAvatar;
    private M3DCharacterManager CorpoCtrl;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start () {
        procurarAvatar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!procurarAvatar || SceneManager.GetActiveScene().name != "Provador")
            return;
        try
        {
            CorpoCtrl = GameObject.Find("avatar").GetComponent<M3DCharacterManager>();
        }
        catch (UnityException ue)
        {
            Debug.LogWarning(ue);
            return;
        }

        foreach (string s in valores)
        {
            string[] split = s.Split('#');
            CorpoCtrl.SetBlendshapeValue(split[0], float.Parse(split[1]));
        }

        procurarAvatar = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera camRef;
    const int In = 1;
    const int Out = 2;
    const double defNormal = 1.142911;
    const double inZoom = 0.9621992;
    int zoom = 0;
    int lastZoom;
    public float velocidade;
    // Use this for initialization
    void Start()
    {
        camRef = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (zoom)
        {
            case In:
                if (lastZoom == In)
                {
                    zoom = 0;
                    return;
                }
                camRef.orthographicSize -= velocidade * Time.deltaTime;

                if (camRef.orthographicSize <= inZoom)
                {
                    zoom = 0;
                    lastZoom = In;
                }
                break;
            case Out:

                if (lastZoom == Out)
                {
                    zoom = 0;
                    return;
                }

                camRef.orthographicSize += velocidade * Time.deltaTime;

                if (camRef.orthographicSize >= defNormal)
                {
                    zoom = 0;
                    lastZoom = Out;
                }
                break;
            default:
                break;
        }
    }

    public void setZoom(int zoom)
    {
        this.zoom = zoom;
    }

}

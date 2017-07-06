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
    const double posleft = -99.8;
    const double posMiddle = -100.03;
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

                if (camRef.orthographicSize >= inZoom)
                    camRef.orthographicSize -= (velocidade*0.8f) * Time.deltaTime;

                Debug.Log(transform.localPosition.x  );
                if(transform.localPosition.x <= posleft)
                {
                    transform.Translate(velocidade * Time.deltaTime, 0, 0);
                }

                if (camRef.orthographicSize <= inZoom && transform.localPosition.x >= posleft)
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

                if (camRef.orthographicSize <= defNormal)
                  camRef.orthographicSize += (velocidade*0.8f) * Time.deltaTime;

                if(transform.localPosition.x >= posMiddle)
                  transform.Translate(-velocidade * Time.deltaTime, 0, 0);

                if (camRef.orthographicSize >= defNormal && transform.localPosition.x <= posMiddle)
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

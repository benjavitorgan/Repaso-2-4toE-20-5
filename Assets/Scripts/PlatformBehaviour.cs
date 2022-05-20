using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    public float speed;
    public bool toRight;
    public GameObject cDer;
    public GameObject cIzq;
    public GameObject prefab1;
    public GameObject prefab2;
    int yOffset;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
        yOffset = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3 (speed, 0, 0);
        } else
        {
            transform.position -= new Vector3(speed,0,0);
        }

        if (transform.position.x > cDer.transform.position.x -1)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = cDer.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }

        if (transform.position.x < cIzq.transform.position.x + 1)
        {
            toRight = true;
            GameObject clon2;
            clon2 = Instantiate(prefab2);
            clon2.transform.position = cIzq.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }
        
    }
}

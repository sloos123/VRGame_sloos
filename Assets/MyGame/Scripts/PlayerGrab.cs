using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{

    public GameObject GrabCube;
    public GameObject GrabCube1;
    public GameObject Myhand;

    bool inHands = false;
    bool inHands1 = false;
    Vector3 GrabCubePos;
    Vector3 GrabCubePos1;

    // Start is called before the first frame update
    void Start()
    {
        GrabCubePos = GrabCube.transform.position;
        GrabCubePos1 = GrabCube1.transform.position;

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                GrabCube.transform.SetParent(Myhand.transform);
                GrabCube.transform.localPosition = new Vector3(0f, -.45f, 0f);
                
                inHands = true;
            } else if(inHands)
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                GrabCube.transform.SetParent(null);
                GrabCube.transform.localPosition = GrabCubePos;
               
                inHands = false;
            }

        }


        if (Input.GetButtonDown("Fire2"))
        {
            if (!inHands1)
            {
         
                GrabCube1.transform.SetParent(Myhand.transform);
                GrabCube1.transform.localPosition = new Vector3(0f, -.45f, 0f);
                inHands1 = true;
            }
            else if (inHands1)
            {
                this.GetComponent<PlayerGrab>().enabled = false;
             
                GrabCube1.transform.SetParent(null);
                GrabCube1.transform.localPosition = GrabCubePos1;
                inHands1 = false;
            }

        }
    }
}

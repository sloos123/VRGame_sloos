using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{

    public GameObject GrabCube;
    public GameObject Myhand;

    bool inHands = false;
    Vector3 GrabCubePos;
    // Start is called before the first frame update
    void Start()
    {
        GrabCubePos = GrabCube.transform.position;
        
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
    }
}

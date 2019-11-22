using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrystal : MonoBehaviour
{

    public GameObject Crystal;
    public GameObject Myhand;


    bool inHands = false;
    Vector3 CrystalPos;

    // Start is called before the first frame update
    void Start()
    {
        CrystalPos = Crystal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


    


        if (Input.GetButtonDown("Fire3"))
        {
            if (!inHands)
            {
                Crystal.transform.SetParent(Myhand.transform);
                Crystal.transform.localPosition = new Vector3(0f, -.45f, 0f);

                inHands = true;
            }
            else if (inHands)
            {
                this.GetComponent<PlayerCrystal>().enabled = false;
                Crystal.transform.SetParent(null);
                Crystal.transform.localPosition = CrystalPos;

                inHands = false;
            }

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : MonoBehaviour
{

  
    public GameObject Sword;

    public GameObject Myhand;


    bool inHands = false;
    Vector3 SwordPos;


    // Start is called before the first frame update
    void Start()
    {

       
        SwordPos = Sword.transform.position;

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Fire2"))
        {
            if (!inHands)
            {
                Sword.transform.SetParent(Myhand.transform);
                Sword.transform.localPosition = new Vector3(0f, -.45f, 0f);

                inHands = true;
            }
            else if (inHands)
            {
                this.GetComponent<PlayerSword>().enabled = false;
                Sword.transform.SetParent(null);
                Sword.transform.localPosition = SwordPos;

                inHands = false;
            }

        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrown : MonoBehaviour
{

    public GameObject Crown;
  

    public GameObject Myhand;

 
    bool inHands = false;
    Vector3 CrownPos;

 

    // Start is called before the first frame update
    void Start()
    {
 
        CrownPos = Crown.transform.position;
      
       
    }

    // Update is called once per frame
    void Update() {


        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                Crown.transform.SetParent(Myhand.transform);
                Crown.transform.localPosition = new Vector3(0f, -.45f, 0f);

                inHands = true;
            }
            else if (inHands)
            {
                this.GetComponent<PlayerCrown>().enabled = false;
                Crown.transform.SetParent(null);
                Crown.transform.localPosition = CrownPos;

                inHands = false;
            }

        }

    


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrag_Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Wrag;
    
    void Start()
    {
        Wrag = GameObject.FindWithTag("Wrag1");

        //transform.position = Wrag.transform.position - Vector3.forward * 1f;


    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position.x > -2.5)
        {
            transform.position = transform.position - new Vector3(0.007f, 0, 0);


        }
        else
        {
            //transform.position = transform.position + new Vector3(0.07f, 0, 0);
        }


        //if (transform.position.x < 3)
        //{

        //    transform.position = transform.position + new Vector3(0.07f, 0, 0);

        //}

    }
   

}

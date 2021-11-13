using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;

    void Start()
    {
        player= GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        float distanceHor = 2 * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * distanceHor);

        float distanceVer = 2 * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * distanceVer);
    }
}

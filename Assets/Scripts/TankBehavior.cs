using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehavior : MonoBehaviour
{
    GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        Tank = GameObject.Find("Bomb");
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            if (transform.rotation.z <= 0.7)
            {
                //Debug.Log(transform.rotation.z);
                transform.Rotate(Vector3.forward);

            }
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            if (transform.rotation.z > 0)
            {

                transform.Rotate(Vector3.back);
            }
        }



    }
}

using System.Collections;
using Systems.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBBehaviour
{
    // Start is called before the first frame update 
    void Update()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMove : MonoBehaviour
{
    private GameScript _script;
    private int speed;
    private int distance;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        
        _script = FindObjectOfType<GameScript>();
        rb =  GetComponent<Rigidbody>();
        distance = Int32.Parse(_script.Distance.text);
        speed = Int32.Parse(_script.Speed.text);
    }
    private void Update()
    {
        if (gameObject.transform.position.z > -distance)
        {
            rb.velocity =  -Vector3.forward * speed;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

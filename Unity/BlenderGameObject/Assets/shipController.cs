using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    bool _move = false;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            _move = !_move;

        if (_move)
            transform.GetComponent<Rigidbody>().velocity = new Vector3(Speed, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{

    public float moveSpeed;
    float xInput;
    float yInput;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizantal");
        yInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    { 
        rb.AddForce(xInput * moveSpeed, 0, yInput * moveSpeed);
    }
    //redo script with one for idle animation *sagh*
}

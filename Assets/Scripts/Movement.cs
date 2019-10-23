using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float moveSpeed = 10.0f; // m/s

    // Update is called once per frame
    void Update() {
        var moveDir = new Vector3(
            Input.GetAxis("Horizontal"),
            0.0f,
            Input.GetAxis("Vertical")
        );
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }
}

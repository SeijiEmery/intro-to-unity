using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float factor = 0.5f;

    // Update is called once per frame
    void Update() {
        if (target != null) {
            transform.LookAt(target);
            var offset = Vector3.up * 2f + transform.rotation * Vector3.back * 5f;
            var targetPos = transform.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, 
                Mathf.Clamp(Time.deltaTime * this.factor, 0f, 1f));

        }
    }
}

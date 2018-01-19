using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public Transform to;
    public float speed = 0.01f;
    void Update() {
        float step = speed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, to.rotation,-Time.time * speed);
    }
}

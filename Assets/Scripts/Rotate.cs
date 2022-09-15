using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private Transform objectTransform;
    private float oldRotation;
    private void Awake()
    {
        oldRotation = 0;
        this.objectTransform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        oldRotation += 0.1f;
        this.objectTransform.eulerAngles = new Vector3(0, oldRotation, 0);
    }
}

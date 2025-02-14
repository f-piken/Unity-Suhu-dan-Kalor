using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotasi : MonoBehaviour
{
    public float rotationSpeed = 50f;

    public Vector3 rotationAxis = Vector3.up;
    void Update()
    {
        transform.Rotate(rotationAxis * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0f,0f,0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundObject : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject pivotObject;
    public float rotateX;
    public float rotateY;
    public float rotateZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(rotateX, rotateY, rotateZ), rotationSpeed * Time.deltaTime);
    }
}

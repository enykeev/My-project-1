using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeScript : MonoBehaviour
{
    GameObject parentObject;
    public GameObject targetObject;
    void Start()
    {
        this.parentObject = gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 parentPos = this.parentObject.transform.position;
        Vector3 targetPos = this.targetObject.transform.position;
        bool obstructed = Physics.Raycast(parentPos, targetPos, Mathf.Infinity);
        Debug.Log(this.parentObject.name + " -> " + this.targetObject.name + " is " + Vector3.Distance(parentPos, targetPos) + " and LOS is " + obstructed);
        Debug.DrawLine(parentPos, targetPos, obstructed ? Color.red : Color.green);
    }
}

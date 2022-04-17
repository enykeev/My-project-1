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
        Vector3 parentPos = this.parentObject.transform.position + Vector3.down;
        Vector3 targetPos = this.targetObject.transform.position;
        Ray ray = new Ray(parentPos, targetPos - parentPos);
        float distance = Vector3.Distance(parentPos, targetPos);
        RaycastHit hitInfo;
        bool obstructed = Physics.Raycast(ray, out hitInfo, distance, ~(1 << 10));
        Debug.DrawRay(ray.origin, ray.direction * distance, obstructed ? Color.red : Color.green, 10);

        if (obstructed) {
            Debug.Log(hitInfo.collider.name);
        }
    }
}

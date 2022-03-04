using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public Transform rotateTarget;
    private Vector3 offset;
    private Quaternion rotateOffset;

    private void Awake()
    {
        offset = rotateTarget.position - transform.position;
        rotateOffset = Quaternion.FromToRotation(rotateTarget.rotation.eulerAngles, transform.rotation.eulerAngles);
    }

    void Update()
    {
        rotateTarget.position = 100 * transform.position + offset;
        rotateTarget.rotation = transform.rotation * rotateOffset;
    }
}

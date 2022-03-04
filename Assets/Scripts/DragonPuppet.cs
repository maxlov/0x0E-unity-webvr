using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DragonPuppet : MonoBehaviour
{
    [SerializeField] private Transform puppeteer;

    private Rigidbody dragonRigidBody;

    [SerializeField] private float speed;

    private Vector3 rotateVector;

    private void Start()
    {
        dragonRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        dragonRigidBody.velocity = speed * Time.deltaTime * transform.forward;
        dragonRigidBody.transform.rotation = puppeteer.rotation;
        //rotateVector = Quaternion.FromToRotation(transform.rotation.eulerAngles, puppeteer.rotation.eulerAngles).eulerAngles;
        //dragonRigidBody.AddRelativeTorque(Time.deltaTime * rotateVector);
    }


}

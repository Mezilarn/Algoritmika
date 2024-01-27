using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnCollisionEnter(Collision collision)
    {
        transform.position = teleportPoint.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Player player;

    private void OnCollisionEnter(Collision collision)
    {
        Jump jump = player.GetComponent<Jump>();
        jump.jumpStrength = 10;
    }

    private void OnCollisionExit(Collision collision)
    {
        Jump jump = player.GetComponent<Jump>();
        jump.jumpStrength = 2;
    }
}

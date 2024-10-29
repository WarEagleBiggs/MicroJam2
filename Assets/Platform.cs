using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Rigidbody rb;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Drop());
        }
    }

    public IEnumerator Drop()
    {
        yield return new WaitForSeconds(5);
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}

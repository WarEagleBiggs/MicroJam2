using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotateArrow());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.forward);
        }
    }

    public IEnumerator RotateArrow()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            //rotate arrow
            transform.Rotate(0,90,0);
        }
    }
}

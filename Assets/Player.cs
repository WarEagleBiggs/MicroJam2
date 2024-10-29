using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Master Mscript;

    public bool isDead;

    public GameObject PauseScreen;

    public GameObject ThingsToDisable;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotateArrow());
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            ThingsToDisable.SetActive(false);
            PauseScreen.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Game");
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //call snap
            transform.Translate(Vector3.forward);
            Mscript.SpawnNew();
        }
    }

    public IEnumerator RotateArrow()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.25f);
            //rotate arrow
            transform.Rotate(0,90,0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {
            //lose
            isDead = true;
        }
    }
}

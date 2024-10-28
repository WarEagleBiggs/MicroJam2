using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public GameObject CameraToFollow;

    public GameObject PlayerObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraToFollow.transform.position = new Vector3(PlayerObj.transform.position.x + 10,
            PlayerObj.transform.position.y + 18, PlayerObj.transform.position.z - 10);
    }
}

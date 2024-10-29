using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public GameObject CameraToFollow;
    public GameObject PlayerObj;
    public GameObject FloorObj;

    private Vector3 lastPosition; 
    private HashSet<Vector3> occupiedPositions = new HashSet<Vector3>(); 

    void Update()
    {
        CameraToFollow.transform.position = new Vector3(
            PlayerObj.transform.position.x + 10,
            PlayerObj.transform.position.y + 18,
            PlayerObj.transform.position.z - 10
        );
    }

    public void SpawnNew()
    {
        Vector3 newPosition;
        do
        {
            newPosition = GetRandomNewPosition();
        } 
        while (newPosition == lastPosition || occupiedPositions.Contains(newPosition));

        lastPosition = newPosition;
        occupiedPositions.Add(newPosition);

        GameObject obj = Instantiate(FloorObj, newPosition, Quaternion.identity);
        FloorObj = obj;
    }

    private Vector3 GetRandomNewPosition()
    {
        
        int move = Random.Range(0, 3);

        if (move == 0) 
            return FloorObj.transform.position + new Vector3(0, 0, 1);
        else if (move == 1) 
            return FloorObj.transform.position + new Vector3(-1, 0, 0);
        else 
            return FloorObj.transform.position + new Vector3(1, 0, 0);
    }
}
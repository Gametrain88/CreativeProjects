using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayTeleporterScript : MonoBehaviour
{
    public GameObject[] teleporterLocations;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPos = new Vector3(teleporterLocations[1].transform.position.x, 
            teleporterLocations[1].transform.position.y + 0.8f, teleporterLocations[1].transform.position.z);
        other.gameObject.transform.position = newPos;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Public Variables
    public GameObject player;
    // Private Variables
    private Vector3 offset = new Vector3(0, 9, -9);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // We make the camera follow the vehicle
        transform.position = player.transform.position + offset;
    }
}

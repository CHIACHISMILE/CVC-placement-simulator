using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public new Camera camera;
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = camera.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera behind the vehicle
        transform.position = player.transform.position + offset;
    }
}

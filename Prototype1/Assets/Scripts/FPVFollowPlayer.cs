using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPVFollowPlayer : MonoBehaviour
{
    public GameObject player;   // GameObject for camera to follow.
    private Vector3 offset = new Vector3(0, 4.3f, 0);

    private float horizontalInput;
    private float turnSpeed = 50.0f;

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }
}

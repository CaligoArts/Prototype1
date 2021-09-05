using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    public float damping = 1;
    Vector3 offset;

    void Start()
    {
        //offset = player.transform.position - transform.position;
        offset = new Vector3(-0.13f, -11, 1); //working how I want.
        //offset = new Vector3(-0.13f, -8, 4); testing
    }

    void LateUpdate()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = player.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, desiredAngle, damping);

        Quaternion rotation = Quaternion.Euler(-55, angle, -5); //working
        //Quaternion rotation = Quaternion.Euler(0, angle, 0); //testing
        transform.position = player.transform.position - (rotation * offset);

        transform.LookAt(player.transform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    public Vector3 offsetWithPlayer;
    void Update()
    {
        this.transform.position = PlayerTransform.position + offsetWithPlayer;
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
    }
}

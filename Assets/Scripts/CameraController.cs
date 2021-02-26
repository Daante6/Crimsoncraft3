using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Transform offset;

    public float xMin, xMax;
    public float yMin, yMax;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp( player.position.x + offset.position.x, xMin,xMax), 
            Mathf.Clamp(player.position.y + offset.position.y, yMin, yMax), 
            offset.position.z); // Camera follows the player with specified offset (0,0,-10) position
    }
}

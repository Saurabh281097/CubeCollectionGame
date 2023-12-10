using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform Cube;
    public float velocity;

    const float CameraYPos = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Cube.transform.position;
        transform.position = new Vector3(position.x,CameraYPos,position.z-10);
    }

    void OnTriggerEnter(Collider otherObj)
    {
        Debug.Log("Cube is collided");
    }
}

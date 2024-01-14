using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollowByCamera;
    
    void LateUpdate()
    {
        transform.position = thingToFollowByCamera.transform.position + new Vector3(0,0,-10);
    }
}

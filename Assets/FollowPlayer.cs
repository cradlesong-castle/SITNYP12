using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = player.position;
        newPos.y += 5.5f;
        transform.position = newPos;
    }
}

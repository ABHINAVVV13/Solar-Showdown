using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FollowSpawn : MonoBehaviour
{
    public Transform player; // The player's transform
    public Transform spawn1, spawn2, spawn3, spawn4; // The enemy spawners

    // The offsets for the enemy spawners
    Vector3 offset1 = new Vector3(-7f, 0f, 0f);
    Vector3 offset2 = new Vector3(7f, 0f, 0f);
    Vector3 offset3 = new Vector3(0f, 7f, 0f);
    Vector3 offset4 = new Vector3(0f, -7f, 0f);

    void Update()
    {
        if (spawn1 != null) spawn1.position = player.position + offset1;
        if (spawn2 != null) spawn2.position = player.position + offset2;
        if (spawn3 != null) spawn3.position = player.position + offset3;
        if (spawn4 != null) spawn4.position = player.position + offset4;
    }
}
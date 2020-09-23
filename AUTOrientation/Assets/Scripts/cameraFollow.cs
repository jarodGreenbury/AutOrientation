
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 rotOffset;

    // Update is called once per frame
    void Update()
    {
        //transform.eulerAngles = player.rotation.eulerAngles.y * rotOffset;
        transform.position = player.position + offset;


        
    }
}

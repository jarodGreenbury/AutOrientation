using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Controls position and rotation of secondary camera which functions as a minimap.
 */
public class minimapScript : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}

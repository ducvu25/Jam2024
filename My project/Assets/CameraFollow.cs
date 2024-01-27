using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform poPlayerA, poPlayerB;
    [SerializeField] float delay;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 p = (poPlayerA.position + poPlayerB.position)/2;
        Vector3 result = Vector3.Lerp(transform.position, new Vector3(p.x, p.y, -10), delay* Time.fixedDeltaTime);
        transform.position = new Vector3(result.x, result.y, transform.position.z);
    }
}

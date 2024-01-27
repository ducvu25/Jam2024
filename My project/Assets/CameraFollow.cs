using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform poPlayerA, poPlayerB;
    [SerializeField] float delay;
    [SerializeField] Vector2 limitX, limitY;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 p = (poPlayerA.position + poPlayerB.position)/2;
        Vector3 result = Vector3.Lerp(transform.position, new Vector3(p.x, p.y, -10), delay* Time.fixedDeltaTime);
        transform.position = new Vector3(result.x, result.y, transform.position.z);
        if(transform.position.x < limitX.x)
        {
            transform.position = new Vector3(limitX.x, transform.position.y, transform.position.z);
        }else if(transform.position.x > limitX.y) {
            transform.position = new Vector3(limitX.y, transform.position.y, transform.position.z);
        }

        if (transform.position.y < limitY.x)
        {
            transform.position = new Vector3(transform.position.x, limitY.x, transform.position.z);
        }
        else if (transform.position.y > limitY.y)
        {
            transform.position = new Vector3(transform.position.x, limitY.x, transform.position.z);
        }
    }
}

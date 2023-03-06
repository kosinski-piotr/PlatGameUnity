using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform NavStartPoint;
    public Transform NavEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    public float speed;

    private Vector2 currentPlatformPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = NavStartPoint.position;
        endPoint = NavEndPoint.position;
        Destroy(NavStartPoint.gameObject);
        Destroy(NavEndPoint.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(speed, 0, 0);
        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;

    }
}

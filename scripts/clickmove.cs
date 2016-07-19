using UnityEngine;
using System.Collections;

public class clickmove : MonoBehaviour {

    private bool objectMoving = false;
    private Vector3 endPoint;
    public float duration = 50.0f;
    private float yAxis;

    void Start()
    {

    }

    void OnMouseDown()
    {

    }

    void Update()
    {
        var epochStart = new System.DateTime(1970, 1, 1, 8, 0, 0, System.DateTimeKind.Utc);
        var timestamp = (System.DateTime.UtcNow - epochStart).TotalSeconds;
        if (Input.GetMouseButtonDown(0))
        {

        }

        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown(0)))
        { //cursor clicked somewhere
            RaycastHit hit;
            Ray ray;
#if UNITY_EDITOR
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //for touch device
#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
   ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
#endif

            if (Physics.Raycast(ray, out hit))
            {//saving click-position 
                objectMoving = true;
                endPoint = hit.point;
                endPoint.y = yAxis;
            }

        }
       if (objectMoving && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        {//object is moving
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1 / (duration * (Vector3.Distance(gameObject.transform.position, endPoint))));
        }
        else if (objectMoving && Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        {//object is in goal
            print(timestamp + " F");
            objectMoving = false;
        }
    }
}

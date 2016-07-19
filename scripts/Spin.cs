using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // rotate at 90 degrees per second
        //transform.Rotate(Vector3.up * Time.deltaTime * 45);
        //bool up = true;
        //transform.Translate(Vector3.forward * Time.deltaTime);

        if (transform.position.y > 2){
            //up = false;
            //transform.tag = "false";
        } else if (transform.position.y < 0.5){
            //up = true;
            //transform.tag = "true";
        }
        var epochStart = new System.DateTime(1970, 1, 1, 8, 0, 0, System.DateTimeKind.Utc);
        //var timestamp = (System.DateTime.UtcNow - epochStart).TotalSeconds;
        //print(timestamp + " " + transform.name + " " + transform.position.y + " go up? " + transform.tag);
        //if (transform.tag.Contains("true")){
            //print(timestamp + " " + transform.name + " going up");
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        //} else{
            //print(timestamp + " " + transform.name + " going down");
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        //}

        //print(timestamp+" "+ transform.name+" "+transform.position.y);
        
    }
}
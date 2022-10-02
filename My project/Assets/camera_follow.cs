
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    
    
    public float panspeed = 40f;
    public float panborderthickness = 10f;
    public float scrollspeed = 15f;


    void Update(){
        Vector3 pos = transform.position;

        if (Input.mousePosition.y >= Screen.height - panborderthickness && pos.y <= 35f)
        {
            pos.y += panspeed * Time.deltaTime;
        }

        if (Input.mousePosition.y <=  panborderthickness && pos.y >= -35f)
        {
            pos.y -= panspeed * Time.deltaTime;
        }

        if (Input.mousePosition.x >= Screen.width - panborderthickness && pos.x <= 75f)
        {
            pos.x += panspeed * Time.deltaTime;
        }

        if (Input.mousePosition.x <=  panborderthickness && pos.x >= -75f)
        {
            pos.x -= panspeed * Time.deltaTime;
        }



        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.orthographicSize -= scroll*scrollspeed;
        
        






        transform.position = pos;
    }

}

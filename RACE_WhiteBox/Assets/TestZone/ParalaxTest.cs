using UnityEngine;
using System.Collections;

public class ParalaxTest : MonoBehaviour {
    //Current camera speed
    public float cameraSpeed;
    //Movement direction true = right
    [Tooltip("Movement to right")]
    public bool forward = true;
    public bool Yparallax;

    public GameObject BackGround;
    float backSpeedX;
    float backSpeedY;

    void Start(){
        backSpeedX = cameraSpeed / 2f;
        backSpeedY = cameraSpeed / 3f;
    }

    void Update()
    {
        if (forward){
            transform.Translate(new Vector3(cameraSpeed, 0, 0) * Time.deltaTime);
            BackGround.transform.Translate(new Vector3(backSpeedX, 0, 0) * Time.deltaTime);
            if(Yparallax)
                BackGround.transform.Translate(new Vector3(0, -backSpeedY, 0) * Time.deltaTime);
        }
        else{
            transform.Translate(new Vector3(-cameraSpeed, 0, 0) * Time.deltaTime);
            BackGround.transform.Translate(new Vector3(-backSpeedX, 0, 0) * Time.deltaTime);
            if (Yparallax)
                BackGround.transform.Translate(new Vector3(0, backSpeedY, 0) * Time.deltaTime);
        }
    }

    //collision check for 2D project
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bound")
            forward = !forward;
    }
}

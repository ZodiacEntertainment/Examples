using UnityEngine;
using System.Collections;

public class CamMove : MonoBehaviour{
    //Current camera speed
    public float cameraSpeed;
    //Movement direction true = right
    [Tooltip("Movement to right")]
    public bool forward = true;

    void Start(){
    }

    void Update(){
        if (forward)
            transform.Translate(new Vector3(cameraSpeed, 0, 0) * Time.deltaTime);
        else
            transform.Translate(new Vector3(-cameraSpeed, 0, 0) * Time.deltaTime);
    }

    //collision check for 2D project
    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Bound")
            forward = !forward;
    }
}

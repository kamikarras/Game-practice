using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float VerticalInput;
    private float HorizontalInput;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.Rotate(new Vector3(12,0,0));
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime *VerticalInput * 5);
        transform.Rotate(Vector3.up * Time.deltaTime * HorizontalInput *50);
    }
    void LateUpdate(){
        camera.transform.position = transform.position + new Vector3(0,3,-5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public GameObject player;

    public float rotationSpeed = 5f;
    float offset;

    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 0f;
    private float rotX;
    
    
    public bool invertMouse, autoLockCursor;

    private Camera playerCamera;

    void Start()
    {
        offset = Vector3.Distance(transform.position, player.transform.position);
    }

    void Awake()
    {
        playerCamera = this.gameObject.GetComponent<Camera>();
        Cursor.lockState = (autoLockCursor)?CursorLockMode.Locked:CursorLockMode.None;
    }

    void LateUpdate()
    {

        

        float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;
        float vertical = Input.GetAxis("Mouse Y") * rotationSpeed;
       
        player.transform.Rotate(new Vector3( 0, horizontal, 0), Space.Self);
        transform.RotateAround(player.transform.position, player.transform.right, -vertical);
       
        // float y = Input.GetAxis("Mouse X") * rotationSpeed;
        // rotX += Input.GetAxis("Mouse Y") * rotationSpeed;
        // player.transform.Rotate(0, rotX, 0);

        // rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        // transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
        // transform.position = player.transform.position - (transform.forward * offset);


        
        // player.transform.Rotate(0, horizontal, 0);
        // float desiredYAngle = player.transform.eulerAngles.y;
        
        // Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        // transform.position = player.transform.position - (rotation * offset);
        // transform.LookAt(player.transform);
     }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
        
        
        
        
        
        
        
        
        // float speed = (moveSpeed + (Input.GetAxis("Fire3") * shiftAdditionalSpeed));
        // this.gameObject.transform.Translate(Vector3.forward * speed * Input.GetAxis("Vertical"));
        // this.gameObject.transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal"));
        // this.gameObject.transform.Translate(Vector3.up * speed * (Input.GetAxis("Jump") + Input.GetAxis("Fire1") * -1));
        // this.gameObject.transform.Rotate(Input.GetAxis("Mouse Y") * sensitivity * ((invertMouse) ? 1 : -1), Input.GetAxis("Mouse X") * sensitivity *((invertMouse) ? -1 : 1), 0);
        // this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x,this.gameObject.transform.localEulerAngles.y, 0);


        if(Cursor.lockState == CursorLockMode.None && Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (Cursor.lockState == CursorLockMode.Locked && Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }


    }
}

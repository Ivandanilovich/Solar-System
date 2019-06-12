using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject myCamera;
    public Transform target;
    public Vector3 offset;
    public float c = 3;
    public float zoomC = 0.25f;
    private float X, Y;
    private float limit = 89;

    void Start()
    {
        myCamera.transform.position = offset;
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoomC;
            else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoomC;
            X = myCamera.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * c;
            Y += Input.GetAxis("Mouse Y") * c;
            Y = Mathf.Clamp(Y, -limit, limit);
            myCamera.transform.localEulerAngles = new Vector3(-Y, X, 0);
            myCamera.transform.position = myCamera.transform.localRotation * offset + target.position;
        }
    }
}
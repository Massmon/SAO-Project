
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speedy = 0.125f;
    void LateUpdate ()
    {
        transform.position = target.position;
    }
}

using UnityEngine;

public class Cameras: MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smooth;
    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetpos = target.position + offset;
        Vector3 smoothedpos = Vector3.Lerp(transform.position, targetpos, smooth * Time.fixedDeltaTime);
        transform.position = smoothedpos;
    }

}
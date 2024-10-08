using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{

    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;

    // Use this for initialization
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            // Increase the interpVelocity multiplier for a faster response
            interpVelocity = targetDirection.magnitude * 10f;  // Increased from 5f to 10f for faster movement

            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            // Increase the Lerp factor for faster interpolation
            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.5f);  // Increased from 0.25f to 0.5f
        }
    }
}
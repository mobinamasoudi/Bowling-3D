using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera_Two : MonoBehaviour
{
    public Transform target;

<<<<<<< HEAD
    
=======
<<<<<<< HEAD
    
=======

>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    public Vector3 offset = new Vector3(0, 5, -10);

    
    public float followSpeed = 5f;

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target is not assigned to FollowCamera script.");
            return;
        }

        
        Vector3 desiredPosition = target.position + offset;

   
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
       
        transform.LookAt(target);
    }




}

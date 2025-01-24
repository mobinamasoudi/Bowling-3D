using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, Time.deltaTime * 20f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
<<<<<<< HEAD
            transform.Rotate(Vector3.up, Time.deltaTime * 230f);
=======
<<<<<<< HEAD
            transform.Rotate(Vector3.up, Time.deltaTime * 230f);
=======
            transform.Rotate(Vector3.up, Time.deltaTime * 20f);
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
        }
       

    }
}

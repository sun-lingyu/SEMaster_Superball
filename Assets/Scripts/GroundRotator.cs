using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRotator : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveVertical , 0.0f , -moveHorizontal );
        //transform.eulerAngles = (movement * speed);

        //限制z轴左右旋转15度
        if(transform.eulerAngles[2]>=15 && transform.eulerAngles[2] <= 16 && movement[2]>0)
        { movement[2] = 0;  }
        else if (transform.eulerAngles[2] <= 345 && transform.eulerAngles[2] >=344 && movement[2] < 0)
        { movement[2] = 0;  }
        //限制x轴前后旋转15度
        if (transform.eulerAngles[0] >= 15 && transform.eulerAngles[0] <= 16 && movement[0] > 0)
        { movement[0] = 0;  }
        else if (transform.eulerAngles[0] <= 345 && transform.eulerAngles[0] >= 344 && movement[0] < 0)
        { movement[0] = 0;  }

        transform.Rotate(movement * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float CamMoveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamMoving();
    }
    void CamMoving()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.parent.Translate(-new Vector3(h, 0, v) * CamMoveSpeed * Time.deltaTime);
    }
}

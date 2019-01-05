using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    float horizontalPos = 0f;
    float verticalPos = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalPos += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        verticalPos += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.position = new Vector3(horizontalPos, verticalPos, 0f);

    }
}

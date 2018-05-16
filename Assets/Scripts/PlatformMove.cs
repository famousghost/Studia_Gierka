using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

    [SerializeField]
    private GameObject platformObject;

    [SerializeField]
    private float timer = 0.2f;

    [SerializeField]
    private bool isRight = true;

    [SerializeField]
    private float speed = 1.4f;

	// Update is called once per frame
	void FixedUpdate () {
        Move();
	}

    void Move()
    {
        float Move = speed * Time.deltaTime;
        if (timer <= 0.0f) 
        {
            isRight = !isRight;
            timer = 0.2f;
        }
        if (isRight)
            platformObject.transform.position += (Vector3.right * Move);
        else
            platformObject.transform.position += (-Vector3.right * Move);
        timer -= 0.1f * Time.deltaTime;
    }
}

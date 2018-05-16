using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlatforms : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D playerbody;

	// Use this for initialization
	void Start () {
        playerbody = GetComponent<Rigidbody2D>();
	}

    void OnCollisionStay2D(Collision2D collisionObj)
    {
        if (collisionObj.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            playerbody.transform.parent = collisionObj.transform;
        }
    }

    void OnCollisionExit2d(Collision2D collisionObj)
    {
        playerbody.transform.parent = null;
    }
}

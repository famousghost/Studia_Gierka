using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    [SerializeField]
    private GameObject objectToThrow;

    private GameObject throwObjectTemp;

    [SerializeField]
    private float throwingSpeed = 0.3f;

    [SerializeField]
    private float lifeTime = 1.5f;

    public void Throw(Rigidbody2D player,bool isRight)
    {
        throwObjectTemp = GameObject.Instantiate(objectToThrow,player.transform);

    }
}

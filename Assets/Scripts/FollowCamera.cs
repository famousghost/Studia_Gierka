using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAction
{

    public class FollowCamera : MonoBehaviour
    {

        [SerializeField]
        private Rigidbody2D player;

        [SerializeField]
        private Camera mainCamera;

        [SerializeField]
        private float smoothSpeed = 0.5f;

        private Vector3 cameraPos;

        private Vector3 playerPos;

        // Update is called once per frame
        void Update()
        {
            UpdateCamera();
        }

        private void UpdateCamera()
        {
            cameraPos = Camera.main.transform.position;
            playerPos = player.transform.position;
            Vector3 smoothStep = Vector3.Lerp(cameraPos.x * Vector3.right, playerPos.x * Vector3.right, smoothSpeed * Time.deltaTime);
            mainCamera.transform.position = new Vector3(smoothStep.x, cameraPos.y, cameraPos.z);
        }
    }
}


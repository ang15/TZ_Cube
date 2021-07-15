using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Script
{
    public class Cube : MonoBehaviour
    {
        private float MoveVertical;
        private float MoveHorizantal;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Quaternion quaternion = Quaternion.AngleAxis(1, new Vector3(MoveVertical, 0, MoveHorizantal));
            transform.rotation *= quaternion;
        }

        public void Right()
        {
            MoveHorizantal = -0.1f;
        }

        public void Left()
        {
            MoveHorizantal = 0.1f;
        }

        public void Up()
        {
            MoveVertical = 0.1f;
        }

        public void Down()
        {
            MoveVertical =-0.1f;
        }
    }
}
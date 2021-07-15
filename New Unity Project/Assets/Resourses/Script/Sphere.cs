using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script {
    public class Sphere : MonoBehaviour
    {
        public Text los;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "GameCollider")
            {
                los.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
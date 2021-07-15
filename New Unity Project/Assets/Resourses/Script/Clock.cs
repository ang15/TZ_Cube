using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class Clock : MonoBehaviour
    {

        public Text clock;
        [SerializeField]
        private float minutes;
        private int voidMinuts;
        [SerializeField]
        private int hours = 0;
        private float speed = 25f;


        void Update()
        {
            minutes += Time.deltaTime*speed;
            if (minutes >= 60)
            {
                minutes = 0;
                if (hours < 24)
                    hours++;
                else
                    hours = 0;
            }

            if (minutes < 10 && hours < 10)
            {
                voidMinuts = (int)minutes;
                clock.text = "0" + hours.ToString() + ":0" + voidMinuts.ToString();

            }
            else if (minutes < 10 && hours >= 10)
            {
                voidMinuts = (int)minutes;
                clock.text = hours.ToString() + ":0" + voidMinuts.ToString();

            }
            else if (minutes >= 10 && hours < 10)
            {
                voidMinuts = (int)minutes;
                clock.text = "0" + hours.ToString() + ":" + voidMinuts.ToString();

            }
            else if (minutes >= 10 && hours >= 10)
            {
                voidMinuts = (int)minutes;
                clock.text = hours.ToString() + ":" + voidMinuts.ToString();

            }

        }
    }
}
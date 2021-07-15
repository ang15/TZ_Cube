using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

namespace Script
{
    public class UIPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        Vector2 pos;
        public Cube Cube;

        public void OnPointerUp(PointerEventData e)
        {

            float right = pos.x - e.position.x;// - right
            float up = pos.y - e.position.y;// - up

            if (Math.Abs(right) - Math.Abs(up) > 0)
            {

                if (right < 0)
                    Cube.Right();
                else
                    Cube.Left();

            }

            else
            {

                if (up < 0)
                    Cube.Up();
                else
                    Cube.Down();

            }


        }

        public void OnPointerDown(PointerEventData e)
        {
            pos = e.position;
        }
    }
}
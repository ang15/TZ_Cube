using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Script
{
    public class GameController : MonoBehaviour
    {
       
        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 0;
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void ExitGame()
        {
            Debug.Log("Игра закончилась");
            Application.Quit();
        }
        public void Restart()
        {
            SceneManager.LoadScene("SampleScene");
        }

        public void Starts()
        {
            Time.timeScale = 0.5f;
        }
       
    }
}
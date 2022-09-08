using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Maze : MonoBehaviour {
    public Transform Player_Transform, Target_Transform;
    public float speed;
    public GameObject Win, lose;
    public float Time_game=60;
    public Text mytext;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Vector3.Distance(Player_Transform.transform.position, Target_Transform.transform.position) <0.3f)
        {
            Time.timeScale = 0;
            Win.SetActive(true);
        }
        if (Time_game > 0)
        {
            Time_game -= 1 * Time.deltaTime;

        }
        if (Time_game <= 0)
        {
            Time.timeScale = 0;
           lose.SetActive(true);
        }
        mytext.text = Time_game.ToString("00");
		
	}
    public void Click_Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Click_Exit()
    {
        Application.Quit();
    }
}

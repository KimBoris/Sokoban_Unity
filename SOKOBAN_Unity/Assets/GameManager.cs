using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;

    public ItemBox[] itemBoxes;

    public bool isGameOver;

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }

        if (isGameOver == true) //ItemBox 'isOveraped' 3개가 모두 참이면
        {
            return;
        }
        
        
        int count = 0; 
        for (int i = 0; i < 3; i++)
        {
            if (itemBoxes[i].isOveraped == true)
            {
                count++;
            }
        }



        if(count>=3)
        {
            Debug.Log("게임승리");
            isGameOver = true;
            winUI.SetActive(true);
        }

    }
}


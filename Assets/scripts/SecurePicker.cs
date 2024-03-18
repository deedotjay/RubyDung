using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Diagnostics;

public class SecurePicker : MonoBehaviour
{

    int selectionNum = 0;
    public TextMeshProUGUI textbox;

    void Update()
    {
        if (selectionNum == 0)
        {
            textbox.text = (">");
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }

        if (selectionNum == 1)
        {
            textbox.text = ("                    >");

            if (Input.GetKeyDown(KeyCode.Return))
            {
                UnityEngine.Application.Quit();
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            selectionNum -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            selectionNum += 1;
        }
    }
}

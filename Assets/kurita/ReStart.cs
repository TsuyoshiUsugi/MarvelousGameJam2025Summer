using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    // Update is called once per frame
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("inGame");


    }



}

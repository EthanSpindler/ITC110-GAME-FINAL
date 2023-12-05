using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    string[] character = {"travis","uzi","x","carti"};
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectSkin = 0;
    public GameObject player;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    // public void Travis()
    // {
    //     player
    // }
}

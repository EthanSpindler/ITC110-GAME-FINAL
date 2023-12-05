using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChampSelect : MonoBehaviour
{
    public static string[] characters = {"",""};
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectSkin = 0;
    public GameObject player;
    public int currentPlayer = 0;
    public string p1 = "";
    public string p2 = "";

    public void SelectCharacter(string name)
    {
        if (currentPlayer == 0) {
            p1 = name;
            Debug.Log("player " + currentPlayer + ": " + p1);
            characters[0] = p1;
            currentPlayer += 1;
        }
        else {
            p2 = name;
            Debug.Log("player " + currentPlayer + ": " + p2);
            currentPlayer += 1;
            characters[1] = p2;
            Debug.Log(characters[0] + " and " + characters[1]);
            PlayGame();
            // SetCharacters();
        }
    }

    public void PlayGame()
    {

      // Load the next scene
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
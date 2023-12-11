using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject lil;
    public GameObject playboi;
    public GameObject tent;
    public GameObject scott;
    private string p1;
    private string p2;
    
    // Start is called before the first frame update
    void Start()
    {
        p1 = ChampSelect.characters[0];
        p2 = ChampSelect.characters[1];

        // GameObject.Find("Player1Win").SetActive(false);
        // GameObject.Find("Player2Win").SetActive(false);

        PickCharacter();
    }

    void PickCharacter()
    {
        if(p1 == "XXX")
        {
            tent.tag = "Player1";
            tent.GetComponent<XHealth>().healthBar = GameObject.Find("Player1Health").GetComponent<HealthBar>();;
            Instantiate(tent, new Vector3(-7, -1, 0), Quaternion.identity);
        }
        else if(p1 == "Uzi")
        {
            lil.tag = "Player1";
            lil.GetComponent<UziHealth>().healthBar = GameObject.Find("Player1Health").GetComponent<HealthBar>();;
            Instantiate(lil, new Vector3(-7, -1, 0), Quaternion.identity);
        }
        else if(p1 == "Travis")
        {
            scott.tag = "Player1";
            scott.GetComponent<TravisHealth>().healthBar = GameObject.Find("Player1Health").GetComponent<HealthBar>();;
            Instantiate(scott, new Vector3(-7, -1, 0), Quaternion.identity);
        }
        else if(p1 == "Carti")
        {
            playboi.tag = "Player1";
            playboi.GetComponent<CartiHealth>().healthBar = GameObject.Find("Player1Health").GetComponent<HealthBar>();;
            Instantiate(playboi, new Vector3(-7, -1, 0), Quaternion.identity); 
        }


        if(p2 == "XXX")
        {  
            tent.tag = "Player2";
            tent.GetComponent<XHealth>().healthBar = GameObject.Find("Player2Health").GetComponent<HealthBar>();
            tent.transform.localScale = new Vector3((float)-1.5,(float)1.5,(float) 1.5);
            Instantiate(tent, new Vector3(7, -1, 0), Quaternion.identity); 
            // tent.transform.localScale = new Vector3(-1.5,1.5,1.5)
        }
        else if(p2 == "Uzi")
        {
            lil.tag = "Player2";
            lil.GetComponent<UziHealth>().healthBar = GameObject.Find("Player2Health").GetComponent<HealthBar>();
            lil.transform.localScale = new Vector3((float)-0.1406604,(float)0.1406604,(float)0.1406604);
            Instantiate(lil, new Vector3(7, -1, 0), Quaternion.identity); 
        }
        else if(p2 == "Travis")
        {
            scott.tag = "Player2";
            scott.GetComponent<TravisHealth>().healthBar = GameObject.Find("Player2Health").GetComponent<HealthBar>();
            scott.transform.localScale = new Vector3((float)-1.5,(float)1.5,(float) 1.5);
            Instantiate(scott, new Vector3(7, -1, 0), Quaternion.identity); 
        }
        else if(p2 == "Carti")
        {
            playboi.tag = "Player2";
            playboi.GetComponent<CartiHealth>().healthBar = GameObject.Find("Player2Health").GetComponent<HealthBar>();
            playboi.transform.localScale = new Vector3((float)-0.27315,(float)0.27315,(float) 0.27315);
            Instantiate(playboi, new Vector3(7, -1, 0), Quaternion.identity); 
        }
    }
}

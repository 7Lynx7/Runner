using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public bool IsMainMenu;
    public bool IsPauseMenu;

    public GameObject StartButton;
    public GameObject ContinueButton;
    public GameObject SetActiveObject;
    public GameObject Player;
    public GameObject ModelPlayer;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject ColesoSansari;
    public GameObject Tropinka;
    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Stolb;
    public GameObject Stena;

    public void StartGame()
    {
        IsPauseMenu = false;
        IsMainMenu = false;
        SetActiveObject.SetActive(false);
        ContinueButton.SetActive(true);
        StartButton.SetActive(false);
        Player.GetComponent<Controls>().enabled = true;
        
        Player.GetComponent<PlayerPassive>().enabled = false;
        ColesoSansari.GetComponent<Spawn>().TimeToSpawn = 200;
        Player.GetComponent<BoxCollider>().enabled = true;
        Player.GetComponent<CapsuleCollider>().enabled = true;
    }

    public void PlayerDeath()
    {
        IsMainMenu = true;
        SetActiveObject.SetActive(true);
        ContinueButton.SetActive(false);
        StartButton.SetActive(true);
        Player.GetComponent<PlayerPassive>().enabled = true;
        ModelPlayer.SetActive(true);
    }

    public void MenuPause()
    {
        IsPauseMenu = true;
        SetActiveObject.SetActive(true);
        StartButton.SetActive(false);
        ContinueButton.SetActive(true);
        ColesoSansari.GetComponent<Spawn>().enabled = false;
        Player.GetComponent<Controls>().enabled = false;
        Player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Player.GetComponent<PlayerOnPause>().enabled = true;
        Tropinka.GetComponent<RotateTropinka>().enabled = false;
        Sphere1.GetComponent<RotateSphere>().enabled = false;
        Sphere2.GetComponent<RotateSphere>().enabled = false;
        Enemy1.GetComponent<EnemyBehavior>().enabled = false;
        Enemy1.GetComponent<Enemy1Behavior2>().enabled = false;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = false;
        Enemy1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Enemy2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
    public void ContinueGame()
    {
        IsPauseMenu = false;
        SetActiveObject.SetActive(false);
        ColesoSansari.GetComponent<Spawn>().enabled = true;
        Player.GetComponent<Controls>().enabled = true;
        Player.GetComponent<PlayerOnPause>().enabled = false;
        Tropinka.GetComponent<RotateTropinka>().enabled = true;
        Sphere1.GetComponent<RotateSphere>().enabled = true;
        Sphere2.GetComponent<RotateSphere>().enabled = true;
        Enemy1.GetComponent<EnemyBehavior>().enabled = true;
        Enemy1.GetComponent<Enemy1Behavior2>().enabled = true;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsMainMenu) Exit();
            else
            {
                if (IsPauseMenu) ContinueGame(); 
                else MenuPause();
            }
                
        }
	}
}

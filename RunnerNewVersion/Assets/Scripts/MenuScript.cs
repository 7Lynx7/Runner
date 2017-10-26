using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class MenuScript : MonoBehaviour {

    public bool IsMainMenu;
    public bool IsPauseMenu, IsGame, timerInvulnerability;

    public GameObject StartButton;
    public GameObject ContinueButton;
    public GameObject SetActiveObject;
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject ColesoSansari;
    public GameObject RotateObs, Sph, Sph1, Sph2, Sph3, Sph4, Sph5, Sph6;
    public GameObject Particle2;
    public GameObject ScoreText;
    public float Score;

    public void StartGame()
    {
        TimeForInvulnerabiliry = 0f;
        IsPauseMenu = false;
        IsMainMenu = false;
        Score = 0;
        timerInvulnerability = true;
        SetActiveObject.SetActive(false);
        ContinueButton.SetActive(true);
        StartButton.SetActive(false);
        Player.GetComponent<Controls>().enabled = true;
        Player.GetComponent<PlayerPassive>().enabled = false;
        ColesoSansari.GetComponent<Spawn>().TimeToSpawn = 200;
        Player.GetComponent<MeshCollider>().enabled = true;
        Player.GetComponent<Controls>().Controlled = true;
        Camera.main.GetComponent<PostProcessingBehaviour>().profile.depthOfField.enabled = false;
    }

    public float TimeForInvulnerabiliry;

    public void TimerInvulnerability()
    {
        if (timerInvulnerability)
        {
            TimeForInvulnerabiliry += Time.deltaTime;
            if (TimeForInvulnerabiliry > 2)
            {
                IsGame = true;
                timerInvulnerability = false;
            }
        }
    }

    public void PlayerDeath()
    {
        IsMainMenu = true;
        IsGame = false;
        SetActiveObject.SetActive(true);
        ContinueButton.SetActive(false);
        StartButton.SetActive(true);
        Player.GetComponent<PlayerPassive>().enabled = true;
        Player.GetComponent<MeshRenderer>().enabled = true;
        Particle2.SetActive(false);
        Player.GetComponent<Controls>().Controlled = false;
        Camera.main.GetComponent<PostProcessingBehaviour>().profile.depthOfField.enabled = true;
    }

    public void MenuPause()
    {
        IsPauseMenu = true;
        IsGame = false;
        SetActiveObject.SetActive(true);
        StartButton.SetActive(false);
        ContinueButton.SetActive(true);
        ColesoSansari.GetComponent<Spawn>().enabled = false;
        Player.GetComponent<Controls>().Controlled = false;
        Player.transform.position = Player.transform.position;
        Player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        RotateObs.GetComponent<RotateTropinka>().enabled = false;
        Sph.GetComponent<RotateTropinka>().enabled = false;
        Sph1.GetComponent<RotateTropinka>().enabled = false;
        Sph2.GetComponent<RotateTropinka>().enabled = false;
        Sph3.GetComponent<RotateTropinka>().enabled = false;
        Sph4.GetComponent<RotateTropinka>().enabled = false;
        Sph5.GetComponent<RotateTropinka>().enabled = false;
        Sph6.GetComponent<RotateTropinka>().enabled = false;
        Enemy1.GetComponent<EnemyBehavior>().enabled = false;
        Enemy1.GetComponent<Enemy1Behavior2>().enabled = false;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = false;
        Enemy1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Enemy2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Camera.main.GetComponent<PostProcessingBehaviour>().profile.depthOfField.enabled = true;
    }
    public void ContinueGame()
    {
        IsGame = true;
        IsPauseMenu = false;
        SetActiveObject.SetActive(false);
        ColesoSansari.GetComponent<Spawn>().enabled = true;
        Player.GetComponent<Controls>().Controlled = true;
        RotateObs.GetComponent<RotateTropinka>().enabled = true;
        Sph.GetComponent<RotateTropinka>().enabled = true;
        Sph1.GetComponent<RotateTropinka>().enabled = true;
        Sph2.GetComponent<RotateTropinka>().enabled = true;
        Sph3.GetComponent<RotateTropinka>().enabled = true;
        Sph4.GetComponent<RotateTropinka>().enabled = true;
        Sph5.GetComponent<RotateTropinka>().enabled = true;
        Sph6.GetComponent<RotateTropinka>().enabled = true;
        Enemy1.GetComponent<EnemyBehavior>().enabled = true;
        Enemy1.GetComponent<Enemy1Behavior2>().enabled = true;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = true;
        Camera.main.GetComponent<PostProcessingBehaviour>().profile.depthOfField.enabled = false;
    }

    public void ScoresCounter()
    {
        if (IsGame)
        {
            Score += Time.deltaTime;
        }
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
        TimerInvulnerability();
        ScoresCounter();
        ScoreText.GetComponent<Text>().text = "Score: " + Mathf.Round(Score); 
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class MenuScript : MonoBehaviour {

    public bool IsMainMenu, IsDopMenu;
    public bool IsPauseMenu, IsGame, IsGame2, timerInvulnerability, GameStageTwo, AlreadyDead;

    public GameObject StartButton;
    public GameObject ContinueButton;
    public GameObject SetActiveObject;
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject ColesoSansari;
    public GameObject RotateObs, Sph, Sph1, Sph2, Sph3, Sph4, Sph5, Sph6, Fon, BackButton;
    public GameObject Particle2;
    public GameObject ScoreText, AS;
    public float Score, SFXvol, MusicVol;
    public int SOUND;
    public int[] Scores = new int[10];
    public Toggle SoundToggle;
    public Slider SFXslider, MusicSlider;
    public AudioSource GameAudioSource, MenuAudioSource;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Zahodil_V_Nastroyki") == 1)
        {
            if(PlayerPrefs.GetInt("SoundOnOff") == 1)
                SoundToggle.isOn = true;
            else
                SoundToggle.isOn = true;

            SOUND = PlayerPrefs.GetInt("SoundOnOff");
            SFXvol = PlayerPrefs.GetFloat("SFXvol");
            MusicVol = PlayerPrefs.GetFloat("MusicVol");
            MusicSlider.value = MusicVol;
            SFXslider.value = SFXvol;
        }
        else
        {
            SOUND = 1;
            SFXvol = 0.4f;
            MusicVol = 0.4f;
            MusicSlider.value = MusicVol;
            SFXslider.value = SFXvol;
        }
        
    }

    public void StartGame()
    {
        Fon.SetActive(false);
        Cursor.visible = false;
        TimeForInvulnerabiliry = 0f;
        IsPauseMenu = false;
        IsMainMenu = false;
        Score = 0;
        timerInvulnerability = true;
        SetActiveObject.SetActive(false);
        SetActiveScoresLayer.SetActive(false);
        ContinueButton.GetComponent<Button>().interactable = true;
        StartButton.GetComponent<Button>().interactable = false;
        Player.GetComponent<PlayerPassive>().enabled = false;
        ColesoSansari.GetComponent<Spawn>().TimeToSpawn = 100;
        Player.GetComponent<MeshCollider>().enabled = true;
        Player.GetComponent<Controls>().Controlled = true;
        Camera.main.GetComponent<PostProcessingBehaviour>().profile.depthOfField.enabled = false;
        AS.GetComponent<AudioSource>().Play();
        IsGame2 = true;
        Enemy1.GetComponent<EnemyBehavior>().enabled = true;
        Enemy1.GetComponent<Enemy1Behavior2>().enabled = true;
        Enemy2.GetComponent<Enemy2Behavior>().enabled = true;
        RotateObs.GetComponent<RotateTropinka>().enabled = true;
        ColesoSansari.GetComponent<Spawn>().enabled = true;
        GameAudioSource.Play();
        MenuAudioSource.Stop();
    }

    public float TimeForInvulnerabiliry;

    public void TimerInvulnerability()
    {
        if (timerInvulnerability && IsGame2)
        {
            TimeForInvulnerabiliry += Time.deltaTime;
            if (TimeForInvulnerabiliry > 2)
            {
                IsGame = true;
                timerInvulnerability = false;
                GameStageTwo = true;
            }
        }
    }

    public void PlayerDeath()
    {
        Fon.SetActive(true);
        Cursor.visible = true;
        IsMainMenu = true;
        SetActiveObject.SetActive(true);
        ContinueButton.GetComponent<Button>().interactable = false;
        StartButton.GetComponent<Button>().interactable = true;
        Player.GetComponent<PlayerPassive>().enabled = true;
        Player.GetComponent<MeshRenderer>().enabled = true;
        Particle2.SetActive(true);
        Player.GetComponent<Controls>().Controlled = false;
        Camera.main.GetComponent<PostProcessingBehaviour>().profile.depthOfField.enabled = true;
        GameStageTwo = false;
        IsGame2 = false;
        IsGame = false;
        IsPauseMenu = false;
        GameAudioSource.Stop();
        MenuAudioSource.Play();
        //for (int i = 0; i < 10; i++)
        //{
        //    Scores[i] = PlayerPrefs.GetInt("Scores" + i.ToString());
        //}
        for (int i = 0; i < 10; i++)
        {
            Scores[i] = PlayerPrefs.GetInt("Scores" + i.ToString());
            if (Score > Scores[i])
            {
                for (int j = 8; j > i-1; j--)
                {
                    Scores[j + 1] = Scores[j];
                    PlayerPrefs.SetInt("Scores" + (j + 1).ToString(), Scores[j + 1]);
                }
                Scores[i] = (int)Mathf.Round(Score);
                PlayerPrefs.SetInt("Scores" + i.ToString(), Scores[i]);
                break;
            }
        }
    }

    public void MenuPause()
    {
        Fon.SetActive(true);
        IsPauseMenu = true;
        IsGame = false;
        IsGame2 = false;
        Cursor.visible = true;
        SetActiveObject.SetActive(true);
        ContinueButton.GetComponent<Button>().interactable = true;
        StartButton.GetComponent<Button>().interactable = false;
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
        AS.GetComponent<AudioSource>().Play();
        MusicVol = MusicVol * 0.65f;
    }

    public void ContinueGame()
    {
        Fon.SetActive(false);
        Cursor.visible = false;
        if (GameStageTwo) { IsGame = true; IsGame2 = true; }
        else IsGame2 = true;
        IsPauseMenu = false;
        SetActiveObject.SetActive(false);
        SetActiveScoresLayer.SetActive(false);
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
        AS.GetComponent<AudioSource>().Play();
        MusicVol = MusicSlider.value;
    }

    public void ScoresCounter()
    {
        if (IsGame)
        {
            Score += Time.deltaTime*0.4f;
        }
    }
    public void Exit()
    {
        Application.Quit();
        AS.GetComponent<AudioSource>().Play();
    }

    public GameObject SetActiveScoresLayer, SetActiveSettingsLayer;
    public GameObject[] TextTopScores = new GameObject[10];
    public void ScoresButton()
    {
        SetActiveScoresLayer.SetActive(true);
        SetActiveObject.SetActive(false);
        AS.GetComponent<AudioSource>().Play();
        BackButton.SetActive(true);
        IsDopMenu = true;
        for (int i = 0; i < 10; i++)
        {
            Scores[i] = PlayerPrefs.GetInt("Scores" + i.ToString());
            TextTopScores[i].GetComponent<Text>().text = "You:      " + Scores[i];
        }
    }

    public void SettingsButton()
    {
        SetActiveSettingsLayer.SetActive(true);
        SetActiveObject.SetActive(false);
        AS.GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Zahodil_V_Nastroyki", 1);
        BackButton.SetActive(true);
        IsDopMenu = true;
    }

    public void ResetScore()
    {
        AS.GetComponent<AudioSource>().Play();
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("Scores" + i.ToString(), 0);
            Scores[i] = PlayerPrefs.GetInt("Scores" + i.ToString());
            TextTopScores[i].GetComponent<Text>().text = "You:      " + Scores[i];
        }
    }

    public void Back()
    {
  
        SetActiveObject.SetActive(true);
        SetActiveScoresLayer.SetActive(false);
        SetActiveSettingsLayer.SetActive(false);
        BackButton.SetActive(false);
        AS.GetComponent<AudioSource>().Play();
        IsDopMenu = false;
    }

    public void Settings()
    {
        if (SoundToggle.isOn == false)
        {
            SOUND = 0;
            PlayerPrefs.SetInt("SoundOnOff", SOUND);
        }
        if (SoundToggle.isOn)
        {
            SOUND = 1;
            SFXvol = SFXslider.value;
            MusicVol = MusicSlider.value;
            PlayerPrefs.SetFloat("SFXvol",SFXvol);
            PlayerPrefs.SetFloat("MusicVol", MusicVol);
            PlayerPrefs.SetInt("SoundOnOff", SOUND);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsDopMenu) Back();
            else
            {
                if (IsPauseMenu) ContinueGame();
                else if (IsGame2)MenuPause();
            }
          if  (AlreadyDead) Player.GetComponent<PlayerDeth>().ToMenu();
        }
        TimerInvulnerability();
        ScoresCounter();
        ScoreText.GetComponent<Text>().text = "Score: " + Mathf.Round(Score);
        if (Input.GetKeyDown(KeyCode.Space) && IsGame == false && IsMainMenu == false && IsPauseMenu == false)
        {
            Player.GetComponent<PlayerDeth>().ToMenu();
            StartGame();
        }
        if(IsDopMenu)
        Settings();
    }
}

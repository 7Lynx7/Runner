using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class MenuScript : MonoBehaviour {

    public bool IsMainMenu, IsDopMenu;
    public bool IsPauseMenu, IsGame, IsGame2, timerInvulnerability, GameStageTwo, AlreadyDead;

    public GameObject SetActiveObject;
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject ColesoSansari;
    public GameObject RotateObs, Sph, Sph1, Sph2, Sph3, Sph4, Sph5, Sph6, Fon, BackButton;
    public GameObject Particle2;
    public GameObject ScoreText, AS;
    [SerializeField]
    GameObject RotateMainCamera, BGLanguage, SwitchLangButton;
    public float Score, SFXvol, MusicVol;
    public float MaxCameraAngleX, MaxCameraAngleY;
    public int SOUND;
    public int[] Scores = new int[10];
    public Toggle SoundToggle, AOToggle, MotionBlurToggle, GrainToggle;
    public Slider SFXslider, MusicSlider, CamAngYSlider, CamAngXSlider;
    public AudioSource GameAudioSource, MenuAudioSource;
    [SerializeField]
    public bool LangBGisShowed, SpaceIsPressed, IsActiveRestartFromPressedSpace, DelayAfterDeth;
    [SerializeField]
    float  TimerDelayAfterDeth;



    [SerializeField]
    GameObject StartButtonText, ContinueButtonText, SettingsButtonText, RecordsButtonText, ExitButtonText, ResetButtonText;
    [SerializeField]
    GameObject StartButtonImage, ContinueButtonImage, SettingsButtonImage, RecordsButtonImage, ExitButtonImage;
    [SerializeField]
    string NameForRecods, ScoreTextName;
    [SerializeField]
    Text LabelAO, LabelSound, LabelMusic, LabelSFX, LabelMB, LabelGrain, LabelCamAngX, LabelCamAngY, LabelButtonResetCamAng, SelectedLangName, LangTXT;
    [SerializeField]
    Image YouLoseEng, YouLoseRus, YouLoseCh;

    public void RusLocal()
    {
        StartButtonImage.SetActive(false);
        ContinueButtonImage.SetActive(false);
        SettingsButtonImage.SetActive(false);
        RecordsButtonImage.SetActive(false);
        ExitButtonImage.SetActive(false);

        StartButtonText.SetActive(true);
        ContinueButtonText.SetActive(true);
        SettingsButtonText.SetActive(true);
        RecordsButtonText.SetActive(true);
        ExitButtonText.SetActive(true);

        StartButtonText.GetComponent<Text>().text = "Начать";
        ContinueButtonText.GetComponent<Text>().text = "Продолжить";
        SettingsButtonText.GetComponent<Text>().text = "Настройки";
        RecordsButtonText.GetComponent<Text>().text = "Рекорды";
        ExitButtonText.GetComponent<Text>().text = "Выход";
        ResetButtonText.GetComponent<Text>().text = "Сброс";

        NameForRecods = "Вы";
        ScoreTextName = "Очки";

        LabelAO.text = "Глобальное затемнение";
        LabelSound.text = "Звук";
        LabelMusic.text = "Громкость музыки";
        LabelSFX.text = "Громкость эффектов";
        LabelMB.text = "Размытость (Motion Blur)";
        LabelGrain.text = "Зернистость";
        LabelCamAngX.text = "Ракурс по X";
        LabelCamAngY.text = "Ракурс по Y";
        LabelButtonResetCamAng.text = "Вернуть стандартный ракурс";
        

        BackButton.GetComponent<Text>().text = "Назад";

        YouLoseEng.enabled = false;
        YouLoseCh.enabled = false;
        YouLoseRus.enabled = true;

        SelectedLangName.text = "Русский";
        LangTXT.text = "Язык";
        PlayerPrefs.SetString("SelectedLang", "Rus");
    }
    public void ChLocal()
    {
        StartButtonImage.SetActive(false);
        ContinueButtonImage.SetActive(false);
        SettingsButtonImage.SetActive(false);
        RecordsButtonImage.SetActive(false);
        ExitButtonImage.SetActive(false);

        StartButtonText.SetActive(true);
        ContinueButtonText.SetActive(true);
        SettingsButtonText.SetActive(true);
        RecordsButtonText.SetActive(true);
        ExitButtonText.SetActive(true);

        StartButtonText.GetComponent<Text>().text = "开始";
        ContinueButtonText.GetComponent<Text>().text = "继续";
        SettingsButtonText.GetComponent<Text>().text = "设置";
        RecordsButtonText.GetComponent<Text>().text = "记录";
        ExitButtonText.GetComponent<Text>().text = "出口";
        ResetButtonText.GetComponent<Text>().text = "重启";

        NameForRecods = "你是";
        ScoreTextName = "得分了";

        LabelAO.text = "环境光遮蔽";
        LabelSound.text = "声音";
        LabelMusic.text = "音乐的音量";
        LabelSFX.text = "音量效果";
        LabelMB.text = "运动模糊";
        LabelGrain.text = "颗粒感";
        LabelCamAngX.text = "相机角度X";
        LabelCamAngY.text = "摄像机角度由Y";
        LabelButtonResetCamAng.text = "重置摄像机角度";

        BackButton.GetComponent<Text>().text = "前";

        YouLoseEng.enabled = false;
        YouLoseRus.enabled = false;
        YouLoseCh.enabled = true;

        SelectedLangName.text = "中国";
        LangTXT.text = "语言";
        PlayerPrefs.SetString("SelectedLang", "Ch");
    }
    public void EngLocal()
    {
        StartButtonImage.SetActive(true);
        ContinueButtonImage.SetActive(true);
        SettingsButtonImage.SetActive(true);
        RecordsButtonImage.SetActive(true);
        ExitButtonImage.SetActive(true);

        ResetButtonText.GetComponent<Text>().text = "Reset";

        StartButtonText.SetActive(false);
        ContinueButtonText.SetActive(false);
        SettingsButtonText.SetActive(false);
        RecordsButtonText.SetActive(false);
        ExitButtonText.SetActive(false);

        NameForRecods = "You";
        ScoreTextName = "Score";

        LabelAO.text = "Ambient Occlusion";
        LabelSound.text = "Sound";
        LabelMusic.text = "Music Volume";
        LabelSFX.text = "SFX";
        LabelMB.text = "Motion Blur";
        LabelGrain.text = "Grain";
        LabelCamAngX.text = "Camera angle X";
        LabelCamAngY.text = "Camera angle Y";
        LabelButtonResetCamAng.text = "Reset camera angle";

        BackButton.GetComponent<Text>().text = "Back";

        YouLoseEng.enabled = true;
        YouLoseRus.enabled = false;
        YouLoseCh.enabled = false;

        SelectedLangName.text = "English";
        LangTXT.text = "Language";
        PlayerPrefs.SetString("SelectedLang", "Eng" +
            "");
    }

    private void Start()
    {
        if (PlayerPrefs.GetString("SelectedLang") == "Eng" || PlayerPrefs.GetString("SelectedLang") == "Ch" || PlayerPrefs.GetString("SelectedLang") == "Rus")
        {
            switch(PlayerPrefs.GetString("SelectedLang"))
            {
                case "Eng":
                    {
                        EngLocal();
                    }
                break;
                case "Rus":
                    {
                        RusLocal();
                    }
                    break;
                case "Ch":
                    {
                        ChLocal();
                    }
                    break;
            }
        }
        else
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                RusLocal();
            }
            if (Application.systemLanguage == SystemLanguage.Chinese)
            {
                ChLocal();
            }
        }
       


        if (PlayerPrefs.GetInt("Zahodil_V_Nastroyki") == 1)
        {
            if(PlayerPrefs.GetInt("SoundOnOff") == 1)
                SoundToggle.isOn = true;
            else
                SoundToggle.isOn = false;

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
        if (PlayerPrefs.GetInt("AOactive") == 1)
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.ambientOcclusion.enabled = true;
            AOToggle.isOn = true;
        }
        else
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.ambientOcclusion.enabled = false;
            AOToggle.isOn = false;
        }
        if (PlayerPrefs.GetInt("GrainActive") == 1)
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.grain.enabled = true;
            GrainToggle.isOn = true;
        }
        else
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.grain.enabled = false;
            GrainToggle.isOn = false;
        }
        if (PlayerPrefs.GetInt("MotionBlurActive") == 1)
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.motionBlur.enabled = true;
            MotionBlurToggle.isOn = true;
        }
        else
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.motionBlur.enabled = false;
            MotionBlurToggle.isOn = false;
        }

        CamAngXSlider.value = PlayerPrefs.GetFloat("CameraAngleX");
        CamAngYSlider.value = PlayerPrefs.GetFloat("CameraAngleY");
        RotateMainCamera.transform.eulerAngles = new Vector3(MaxCameraAngleX * CamAngXSlider.value, MaxCameraAngleY * CamAngYSlider.value, 0f);
    }

    public void StartGame()
    {
        ColesoSansari.GetComponent<Spawn>().GlobalTime = 0;
        ColesoSansari.GetComponent<Spawn>().time = 0;
        Fon.SetActive(false);
        Cursor.visible = false;
        TimeForInvulnerabiliry = 0f;
        IsPauseMenu = false;
        IsMainMenu = false;
        Score = 0;
        timerInvulnerability = true;
        SetActiveObject.SetActive(false);
        SetActiveScoresLayer.SetActive(false);

        ContinueButtonText.GetComponent<Button>().interactable = true;
        StartButtonText.GetComponent<Button>().interactable = false;
        ContinueButtonImage.GetComponent<Button>().interactable = true;
        StartButtonImage.GetComponent<Button>().interactable = false;

        Player.GetComponent<PlayerPassive>().enabled = false;
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
        Player.GetComponent<PlayerPassive>().Prepyatsviya[0] = 0;
        Player.GetComponent<PlayerPassive>().Prepyatsviya[1] = 0;
        Player.GetComponent<PlayerPassive>().Prepyatsviya[2] = 0;

        ScoreText.SetActive(true);
        

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
        ColesoSansari.GetComponent<Spawn>().GlobalTime = 0;
        ColesoSansari.GetComponent<Spawn>().time = 0;
        ColesoSansari.GetComponent<Spawn>().enabled = true;
        AlreadyDead = false;
        Fon.SetActive(true);
        Cursor.visible = true;
        IsMainMenu = true;
        SetActiveObject.SetActive(true);

        ContinueButtonText.GetComponent<Button>().interactable = false;
        StartButtonText.GetComponent<Button>().interactable = true;
        ContinueButtonImage.GetComponent<Button>().interactable = false;
        StartButtonImage.GetComponent<Button>().interactable = true;

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

        ScoreText.SetActive(false);

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
        ContinueButtonText.GetComponent<Button>().interactable = true;
        StartButtonText.GetComponent<Button>().interactable = false;
        ContinueButtonImage.GetComponent<Button>().interactable = true;
        StartButtonImage.GetComponent<Button>().interactable = false;
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
            TextTopScores[i].GetComponent<Text>().text = NameForRecods + ":      " + Scores[i];
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
            TextTopScores[i].GetComponent<Text>().text = NameForRecods+":      " + Scores[i];
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
        if (AOToggle.isOn)
        {
            PlayerPrefs.SetInt("AOactive", 1);
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.ambientOcclusion.enabled = true;
        }
        else
        {
            PlayerPrefs.SetInt("AOactive", 0);
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.ambientOcclusion.enabled = false;
        }
        if (GrainToggle.isOn)
        {
            PlayerPrefs.SetInt("GrainActive", 1);
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.grain.enabled = true;
        }
        else
        {
            PlayerPrefs.SetInt("GrainActive", 0);
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.grain.enabled = false;
        }
        if (MotionBlurToggle.isOn)
        {
            PlayerPrefs.SetInt("MotionBlurActive", 1);
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.motionBlur.enabled = true;
        }
        else
        {
            PlayerPrefs.SetInt("MotionBlurActive", 0);
            Camera.main.GetComponent<PostProcessingBehaviour>().profile.motionBlur.enabled = false;
        }

        RotateMainCamera.transform.eulerAngles = new Vector3(MaxCameraAngleX*CamAngXSlider.value, MaxCameraAngleY * CamAngYSlider.value, 0f);
        PlayerPrefs.SetFloat("CameraAngleX", CamAngXSlider.value);
        PlayerPrefs.SetFloat("CameraAngleY", CamAngYSlider.value);
    }

    public void ShowHideLangSwitch()
    {
        if (LangBGisShowed)
        {
            SwitchLangButton.transform.Rotate(0f, 0f, 180f);
            BGLanguage.SetActive(false);
            LangBGisShowed = false;
        }
        else
        {
            SwitchLangButton.transform.Rotate(0f, 0f, 180f);
            BGLanguage.SetActive(true);
            LangBGisShowed = true;
        }
    }


    public void ResetCameraAngle()
    {
        CamAngXSlider.value = 0f;
        CamAngYSlider.value = 0f;
        PlayerPrefs.SetFloat("CameraAngleX", 0f);
        PlayerPrefs.SetFloat("CameraAngleY", 0f);
        AS.GetComponent<AudioSource>().Play();
    }
   
    public void StartCorut()
    {
        StartCoroutine(DelayAfterDeath());
    }
    public IEnumerator DelayAfterDeath()
    {
        yield return new WaitForSeconds(0.2f);
        IsActiveRestartFromPressedSpace = true;
        Debug.Log("1");
        yield break;
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
            if (AlreadyDead)
            {
                Player.GetComponent<PlayerDeth>().ToMenu();

            }
        }
        TimerInvulnerability();
        ScoresCounter();
        ScoreText.GetComponent<Text>().text = ScoreTextName + ": " + Mathf.Round(Score);
        //if (AlreadyDead) 
        if(IsDopMenu)
        Settings();

        //if (DelayAfterDeth)
        //{
        //    TimerDelayAfterDeth += Time.deltaTime;

        //}
        //if (TimerDelayAfterDeth > 0.2f)
        //{
        //    DelayAfterDeth = false;
        //    TimerDelayAfterDeth = 0;
        //    IsActiveRestartFromPressedSpace = true;
        //}

        if (IsActiveRestartFromPressedSpace && SpaceIsPressed)
        {
            SpaceIsPressed = false;
            IsActiveRestartFromPressedSpace = false;
            Player.GetComponent<PlayerDeth>().ToMenu();
            Enemy1.GetComponent<EnemiesUlyot>().Priliot();
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.Space) &&  AlreadyDead)
        {
            SpaceIsPressed = true;
        }     

    }
}

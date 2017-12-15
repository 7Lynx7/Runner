using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Splash : MonoBehaviour {

    public List<GameObject> splashes = new List<GameObject>();
    private GameObject _canvas;
    private int _splashCounter = 0;

    [Header("Fade In Out")]
    public bool StartingScene;
    public bool EndingScene;
    public bool ended = false;

    public int NextScene;

    private Image _image;

    public float FadeSpeed;

    public bool music;

    bool _Lerping1, _Lerping2;

    [SerializeField]
    Image RusDisc, EngDisc, ChDisc;

    private void Awake()
    {
        _canvas = GameObject.FindGameObjectWithTag("Canvas");

        _image = gameObject.GetComponent<Image>();
        _image.enabled = true;
    }

    void RusLocal()
    {
        RusDisc.enabled = true;
        EngDisc.enabled = false;
    }
    void ChLocal()
    {
        ChDisc.enabled = true;
        EngDisc.enabled = false;
    }

    void Start ()
    {
        if(Application.systemLanguage == SystemLanguage.Russian)
        {
            RusLocal();
        }
        if (Application.systemLanguage == SystemLanguage.Chinese)
        {
            ChLocal();
        }
        StartCoroutine(Switcher());
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.GetInt("PlayedGame") == 1)
            if (Input.anyKeyDown)
            {
                ended = true;
            }
        if(ended == true)
        {
            Application.LoadLevel(1);
            if (PlayerPrefs.GetInt("PlayedGame") == 0)
            PlayerPrefs.SetInt("PlayedGame", 1);
        }

        if(StartingScene == true)
        {
            Starting();
        }

        if (EndingScene == true)
        {
            Ending();
        }
        if (_Lerping1) _image.color = Color.Lerp(_image.color, Color.clear, FadeSpeed * Time.deltaTime);
        if (_Lerping2) _image.color = Color.Lerp(_image.color, Color.black, FadeSpeed * Time.deltaTime);
    }

    void Starting()
    {
        //_image.color = Color.Lerp(_image.color, Color.clear, FadeSpeed /** Time.deltaTime*/);

        if (_image.color.a <= 0.01f)
        {
            _image.color = Color.clear;
            _image.enabled = false;
            StartingScene = false;
        }

        StartingScene = false;
    }

    void Ending()
    {
        _image.enabled = true;
        //_image.color = Color.Lerp(_image.color, Color.black, FadeSpeed /** Time.deltaTime*/);

        if (_image.color.a >= 0.95f)
        {
            _image.color = Color.black;
        }

        EndingScene = false;
    }

    IEnumerator Switcher()
    {
        splashes[0].SetActive(true);
        _Lerping1 = true;
        StartingScene = true;
        
        yield return new WaitForSeconds(3f);
        _Lerping1 = false;
        _Lerping2 = true;
        EndingScene = true;

        yield return new WaitForSeconds(3f);

        splashes[0].SetActive(false);
        splashes[1].SetActive(true);
        _Lerping2 = false;
        _Lerping1 = true;
        StartingScene = true;
        yield return new WaitForSeconds(3f);
        yield return new WaitForSeconds(2f);
        _Lerping1 = false;
        _Lerping2 = true;
        EndingScene = true;
        yield return new WaitForSeconds(3f);

        splashes[1].SetActive(false);
        splashes[2].SetActive(true);
        _Lerping2 = false;
        _Lerping1 = true;
        StartingScene = true;
        yield return new WaitForSeconds(3f);
        yield return new WaitForSeconds(2f);
        _Lerping1 = false;
        _Lerping2 = true;
        EndingScene = true;
        yield return new WaitForSeconds(3f);

        ended = true;

        yield break;
    }
}

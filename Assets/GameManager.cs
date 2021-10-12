using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text CoinText;
    public int CoinCount;
    public ParticleSystem coinEffect;
    public ParticleSystem coinEffect1;
    public ParticleSystem coinEffect2;

    public float startDelayTime;
    public float levelTime;
    public Text timeText;

    private float elapsedTime;
    private float levelElapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        levelElapsedTime = levelTime;
        timeText.text = "Time: " + levelElapsedTime.ToString("0.00");

        CoinCount = 0;
        CoinText.text = "Coin: " + CoinCount;

        coinEffect.Stop();
        coinEffect1.Stop();
        coinEffect2.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > startDelayTime)
        {
            levelElapsedTime += Time.deltaTime;
            timeText.text = "Timer: " + levelElapsedTime.ToString("0.00");

            if(CoinCount == 60)
            {
                SceneManager.LoadScene("GameWin");
            }
            else if (levelElapsedTime >= 30)
            {
                SceneManager.LoadScene("GameLose");

            }
            
        }
    }

    public void CoinScore()
    {
        CoinCount += 10;
        CoinText.text = "Coin: " + CoinCount;
    }
    public void coinExplosion()
    {
        coinEffect.Play();
        coinEffect1.Play();
        coinEffect2.Play();
    }
}

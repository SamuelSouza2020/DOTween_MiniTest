using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(7, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        transform.DOMoveY(5.1f, 2.8f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
    public void FimGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FiveUIManager : MonoBehaviour
{

    public static FiveUIManager instance;

    public TMP_Text damageText;

    public int damage;

    public GameObject gameFinishPanel;

    public TMP_Text bulletCountText;

    public int bulletCount;

    public GameObject gameFailPanel;

    private bool _isFail;

    private void Awake()
    {

        instance = this;

    }


    private void OnEnable()
    {

        SevenEventManager.OnGameFinish += OpenGameFinishPanel;

        SevenEventManager.OnGameFail += OpenGameFailPanel;

    }

    private void OnDisable()
    {

        SevenEventManager.OnGameFinish -= OpenGameFinishPanel;

        SevenEventManager.OnGameFail -= OpenGameFailPanel;

    }


    public void IncreaseDamage()

    {

        damage++;

        UpdateDamageText();

    }

    private void UpdateDamageText()

    {

        damageText.text = "Damage : " + damage.ToString();

    }

    private void OpenGameFinishPanel()
    {

        gameFinishPanel.SetActive(true);

    }

    public void IncreaseBulletCount()

    {
        if (_isFail) return;

        bulletCount--;

        if (bulletCount <= 0)
        {

            OpenGameFailPanel();

            _isFail = true;

        }

        UpdateBulletCountText();

    }

    private void UpdateBulletCountText()

    {

       bulletCountText.text = "Bullet : " + bulletCount.ToString();

    }

    private void OpenGameFailPanel()
    {

        gameFailPanel.SetActive(true);

    }


}

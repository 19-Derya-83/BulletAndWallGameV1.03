using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnePlayerController : MonoBehaviour
{

    [SerializeField] private GameObject[] bullets;

    [SerializeField] private float bulletRepeatDuration;

    [SerializeField] private int bulletCount;

    private bool _isGameFinish;

    private bool _isGameFail;

    private void OnEnable()
    {

        SevenEventManager.OnGameFinish += GameFinish;

        SevenEventManager.OnGameFail += GameFail;
    }

    private void OnDisable()
    {

        SevenEventManager.OnGameFinish -= GameFinish;

        SevenEventManager.OnGameFail -= GameFail;

    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0) && !_isGameFinish)
        {

            StartCoroutine(CreateBullet());

        }

    }


    private IEnumerator CreateBullet()

    {

        for (int i = 0; i < bulletCount; i++)
        {

            Instantiate(bullets[Random.Range(0, bullets.Length)]);

            yield return new WaitForSeconds(bulletRepeatDuration);

        }

    }

    private void GameFinish()

    {

        _isGameFinish = true;

    }

    private void GameFail()

    {

        _isGameFail = true;

    }


}

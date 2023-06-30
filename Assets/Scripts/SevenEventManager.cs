using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SevenEventManager : MonoBehaviour
{

    public static event UnityAction OnGameFinish;

    public static event UnityAction OnGameFail;


     public static void InvokeGameFinish()

    {

        OnGameFinish?.Invoke();

    }

    public static void InvokeGameFail()

    {

        OnGameFail?.Invoke();

    }



}

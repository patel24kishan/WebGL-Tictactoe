﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{

    public void LoadSceneType(int level)
    {
        Application.LoadLevel(level);
    }
   
}
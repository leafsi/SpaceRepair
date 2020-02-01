﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _aster_imgs_pref;
    public static int score = 0;
    public static float damage = 0f;
    public static int difficulty = 1;
    public int halfW = 50;
    public int backDist = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < (difficulty * Mathf.Pow(Mathf.PI, difficulty)); i++){
            int L_R = Random.Range(-halfW, halfW);
            GameObject aster = Instantiate(_aster_imgs_pref, Vector2.zero, Quaternion.identity);
            Vector2 pos = new Vector2(L_R, backDist);
            aster.transform.position = pos;
        }
    }
}

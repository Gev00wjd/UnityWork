using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPrefab;
    public Transform PLayerPos;
    
    [SerializeField] public Text Distance; 
    [SerializeField] public Text Speed; 
    [SerializeField] Text SpawnTime;

    private float _timer;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (SpawnTime.text.Length != 0)
        {
            
            if (_timer >= Int32.Parse(SpawnTime.text))
            {
                _timer = 0;
                GameObject Player = Instantiate(PlayerPrefab, PLayerPos.position, Quaternion.identity);
            }
        }
        
        
    }
}

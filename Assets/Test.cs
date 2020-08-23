using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Header("Testing Variable")]
    [SerializeField] float _numofLetter;

    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        _numofLetter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AddTest();
    }

    void AddTest()
    {
        if (_numofLetter >= 150)
            return;

        for (int i = 0; i < 15; i++)
        {
            _numofLetter++;
            Debug.Log("Numn: " + _numofLetter);
        }
    }
}

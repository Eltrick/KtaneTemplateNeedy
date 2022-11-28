using System;
using System.Collections;
using System.Collections.Generic;
using KModkit;
using KeepCoding;
using UnityEngine;
using Rnd = UnityEngine.Random;

public class TemplateScript : ModuleScript
{
    private KMNeedyModule _needy;
    private System.Random _rnd;

    private bool _isModuleSolved, _isSeedSet;
    private int _seed;

    // Use this for initialization
    void Start()
    {
        if (!_isSeedSet)
        {
            _seed = Rnd.Range(int.MinValue, int.MaxValue);
            Log("The seed is: " + _seed.ToString());
            _isSeedSet = true;
        }

        _rnd = new System.Random(_seed);
        // SET SEED ABOVE IN CASE OF BUGS!!
        // _rnd = new System.Random(loggedSeed);
        _needy = Get<KMNeedyModule>();
        _needy.OnNeedyActivation += ActivateNeedy;
        _needy.OnNeedyDeactivation += DeactivateNeedy;
        _needy.OnTimerExpired += OnTimerExpired;
    }

    private void ActivateNeedy()
    {
        throw new NotImplementedException();
    }

    private void DeactivateNeedy()
    {
        throw new NotImplementedException();
    }

    private void OnTimerExpired()
    {
        throw new NotImplementedException();
    }
}

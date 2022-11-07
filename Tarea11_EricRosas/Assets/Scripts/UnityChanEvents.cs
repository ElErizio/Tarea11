using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanEvents : MonoBehaviour
{
    [SerializeField] private Transform _rightHandTransform;
    [SerializeField] private Transform _leftFootTransform;
    [SerializeField] private Transform _rightFootTransform;

    [SerializeField] private GameObject _dustParticle;
    [SerializeField] private GameObject _fireworkParticle;
    [SerializeField] private GameObject _light;

    public void LightTurnOn()
    {
        _light.SetActive(true);
    }

    public void LightTurnOff()
    {
        _light.SetActive(false);
    }

    public void FireworkRightHand()
    {
        Instantiate(_fireworkParticle, _rightHandTransform);
    }

    public void DustLeftFoot()
    {
        Instantiate(_dustParticle, _leftFootTransform);
    }

    public void DustRightFoot()
    {
        Instantiate(_dustParticle, _rightFootTransform);
    }
}

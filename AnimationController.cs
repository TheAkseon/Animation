using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animation _loopingAnimation;

    private void Start()
    {
        _loopingAnimation = GetComponent<Animation>();
    }

    private void Update()
    {
        _loopingAnimation.Play();
    }
}

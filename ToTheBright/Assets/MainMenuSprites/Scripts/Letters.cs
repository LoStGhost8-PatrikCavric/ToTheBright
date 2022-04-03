using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{
    public float WaitBetween = 0.5f;
    List<Animator> animators;
    void Start()
    {
        animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(DoAnimation());
    }

    IEnumerator DoAnimation()
    {
        while (true)
        {
            foreach (var animator in animators)
            {
                animator.SetTrigger("DoAnimation");
                yield return new WaitForSeconds(WaitBetween);
            }
        }
    }
}

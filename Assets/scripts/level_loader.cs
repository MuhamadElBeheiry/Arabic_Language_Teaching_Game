using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level_loader : MonoBehaviour
{
    public Animator transition;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            load_scene();
        }
    }

    void load_scene()
    {
        StartCoroutine(load_level(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator load_level(int index)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
}

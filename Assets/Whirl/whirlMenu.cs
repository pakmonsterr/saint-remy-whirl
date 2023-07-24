using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Oculus.Interaction;

public class whirlMenu : MonoBehaviour
{
    public bool scene_active;
    public TMP_Text menu_text;

    public GameObject whirl;
    public Animator whirl_base;
    
    void Start()
    {
        menu_text.text = "Press (A) to Dream";
        whirl.SetActive(false);
    }

    void Update()
    {
        menu_text.text = scene_active ? "Press (A) to Return" : "Press (A) to Dream";

        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            // on button press, run animation and activate scene (if not already activated)
            if (!scene_active)
            {
                scene_active = true;
                menu_text.text = "Press (A) to Return";
                whirl.SetActive(true);
                whirl_base.SetTrigger("grow");
            }
            else
            {
                whirl.SetActive(false);
                scene_active = false;
                menu_text.text = "Press (A) to Dream";
            }
        }
        
    }
}

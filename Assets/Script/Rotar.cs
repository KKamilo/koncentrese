﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public nombre myType;
    public Mapeo myMapita;
    public bool show = false;
    public static bool juego= true;

    public static bool lokc;

    private void OnMouseDown()
    {
        if (!lokc)
        {
            myMapita.Rellenar(this.gameObject);
            show = true;
        }
    }
    private void Start()
    {
        myMapita = FindObjectOfType<Mapeo>();
    }
    // Update is called once per frame
    void Update()
    {
        if (show && juego == true)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));

        }
        else
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero * 180, 2 * Time.deltaTime));

    }
   
    
}

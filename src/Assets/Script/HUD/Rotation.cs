using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    private Text scoreText;
    private AerodynamicParameters aero;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<Text>();
        aero = GameManager.instance.aero;
    }

    void Update()
    {
        // Calculate rotation
        //20260928 AerodynamicParameters内でパラメーターを持つことにした
        scoreText.text = 
            "\n\n" + aero.phi.ToString("0.000") 
            + "\r\n" + aero.theta.ToString("0.000") 
            + "\r\n" + aero.psi.ToString("0.000");
    }
    
}

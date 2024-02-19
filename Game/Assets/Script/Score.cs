using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick() {
        Debug.Log("Kyky trop bg > Tom Saillard");
    }
}

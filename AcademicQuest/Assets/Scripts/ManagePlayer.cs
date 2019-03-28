using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayer : MonoBehaviour

{

    // atributos
    public int vida, energia, distancia, resistencia, agilidade, poder, pilas, elemento;
    public string tipoArma, tipoArmadura, armaEquip, armaduraEquip, amuleto1, amuleto2, nome;


    // manter entre cenas
    void Awake()
    {

        DontDestroyOnLoad(this);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // funções
    public void NovoJogo()
    {
        energia = 10;
        pilas = 0;


    }
}

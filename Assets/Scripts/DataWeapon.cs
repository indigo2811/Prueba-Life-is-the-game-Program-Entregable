using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " New Weapon Data",menuName = "weapon data")]
public class DataWeapon : ScriptableObject

{
    [SerializeField] private string descripcion;
    [SerializeField] private float  fuerzadetiro;
    [SerializeField] private float fuerzaElevación;
    [SerializeField] private int balas;
    [SerializeField] private float vidamaxima;
    [SerializeField] private bool explosionContacto;
    [SerializeField] private float velocidadrafaga;
    [SerializeField] private bool gravedad;
    [SerializeField] private float velocidadAtraccion;
    [SerializeField] private float magnetismoDistancia;

    public string Descripcion { get { return descripcion; } }
    public float Fuerzadetiro {get{ return fuerzadetiro; } }
    public float FuerzaElevación { get { return fuerzaElevación; } }
    public int Balas { get { return balas; } }
    public float Vidamaxima { get { return vidamaxima; } }
    public float Velocidadrafaga { get { return velocidadrafaga; } }

    public bool Explosioncontacto { get { return explosionContacto; } }
    public bool Gravedad { get { return gravedad; } }
    public float VelocidadAtraccion { get { return velocidadAtraccion; } }
    public float MagnetismoDistancia { get { return magnetismoDistancia; } }


}

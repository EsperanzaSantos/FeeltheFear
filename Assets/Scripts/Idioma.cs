using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
public class Idioma 
{
    //Clase que define el tipo de objeto Item
    [XmlAttribute("name")]
    public string name;
    [XmlElement("Jugar")]
    public string Jugar;
    [XmlElement("Salir")]
    public string Salir;
    [XmlElement("Opciones")]
    public string Opciones;
}


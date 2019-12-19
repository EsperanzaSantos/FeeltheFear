using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

[XmlRoot ("Languages")]


public class Languages 
{
    //Clase que define la lectura del xml
    //Para guardar datos hay que serializar
    // para cargar datos hay que deserializar
   
        //Tratamiento de XML con un array de items
    // que contiene un array de item
    [XmlArray("Idiomas")]
    [XmlArrayItem("Idioma")]
    //Lista donde almacenaremos los diferentes Item leidos desde el XML
    public List<Idioma> Idiomas = new List<Idioma>();
    //Funcion que lee el XML desrializando, completa de listas de elementos item
    public static Languages Load(string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Languages));
        //Usamos un reader para leer el archivo XML
        StreamReader theReader = new StreamReader(Application.dataPath + "/" + path);
        //Deserializamos el archivo segun el tipo de estructura definida en la clase itemContainer
        Languages Idiomas = serializer.Deserialize(theReader) as Languages;
        theReader.Close();
        return Idiomas;
    }
       
}

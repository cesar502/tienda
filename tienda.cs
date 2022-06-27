using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tienda : MonoBehaviour
{
 
 public Slider ballestas,libros,totems;
 public int maxballesta,maxlibro,maxtotem;

 int currentballesta,currentlibro,currenttotem;

    // Start is called before the first frame update
    void Start()
    {
        setdefs();
    }
 
 void setdefs()
  {
    currentlibro = PlayerPrefs.GetInt("libro",0);
    currentballesta = PlayerPrefs.GetInt("ballesta",0);
    currenttotem = PlayerPrefs.GetInt("totem",0);

    ballestas.maxValue = maxballesta;
    libros.maxValue = maxlibro;
    totems.maxValue = maxtotem;

    ballestas.value = currentballesta;
    libros.value = currentlibro;
    totems.value = currenttotem;

    }
 
 
      public void buyballesta()
    
    {
       if (currentballesta < maxballesta)
      {
         currentballesta += 10;
         PlayerPrefs.SetInt("ballesta",currentballesta);
         ballestas.value = currentballesta;
         Debug.Log("ballesta upgraded");
      }

       else
       {
           Debug.Log("ballesta full");
       }
    } 
     public void buylibro()
    
    {
       if (currentlibro < maxlibro)
      {
         currentlibro += 10;
         playerprefs.SetInt("libro",currentlibro);
         libros.value = currentlibro;
         Debug.Log("libro upgraded");
      }

       else
       {
           Debug.Log("libro full");
       }
    } 
     public void buytotem()
    
    {
       if (currenttotem < maxtotem)
      {
         currenttotem += 10;
         playerprefs.SetInt("totem",currenttotem);
         totems.value = currenttotem;
         Debug.Log("totem upgraded");
      }

       else
       {
           Debug.Log("totem full");
       }
    } 
}

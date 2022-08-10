using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour

{
   public int width;    // for screen
   public int height;   // resolution



   public void PlayGame()    // code to start the game that switch from UIscene to Gamescene
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void QuitGame ()   // code to quit and close the game
   {
    
       Application.Quit();

   }

  public void SetWidth(int newWidth){
    width = newWidth;
  }// change the width
  public void SetHeight(int newHeight){
    height = newHeight;
  }//change the height 

  public void SetRes(){
      Screen.SetResolution(width, height , false);
  }//change the resolution
}

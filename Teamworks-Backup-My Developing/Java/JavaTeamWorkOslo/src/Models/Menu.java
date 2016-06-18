package Models;

import java.awt.*;
import Graphics.Assets;

public class Menu {

    public  Rectangle playButton;
    public  Rectangle helpButton;
    public  Rectangle quitButton;
    public  Font font1;
    public  Font font2;
    public  Font font3;

   public Menu(){
       init();
   }

    public void init(){

        playButton = new Rectangle(440, 10, 195, 65);
        helpButton = new Rectangle(440, 95, 195, 65);
        quitButton = new Rectangle(440, 300, 195, 65);

    }
    public void thick(){

    }
    public void render(Graphics g) {

        g.drawImage(Assets.menuImg, 0, 0, null);

        Graphics2D g2d = (Graphics2D) g;
        g2d.draw(this.playButton);
        g2d.draw(this.helpButton);
        g2d.draw(this.quitButton);


    }





}

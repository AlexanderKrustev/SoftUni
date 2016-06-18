package Models;

import java.awt.*;
import Graphics.Assets;

public class GameOverMenu {

    public Rectangle playButton;
    public  Rectangle quitButton;

    public GameOverMenu(){
        init();
    }

    public void init(){

        playButton = new Rectangle(440, 10, 195, 65);
        quitButton = new Rectangle(440, 300, 195, 65);

    }
    public void thick(){

    }
    public void render(Graphics g) {

        g.drawImage(Assets.menuImg, 0, 0, null);

        Graphics2D g2d = (Graphics2D) g;
        g.setColor(Color.BLACK);
        g.drawString("Oslo Mario", 10, 40);
        g2d.draw(this.playButton);
        g2d.draw(this.quitButton);


    }
}

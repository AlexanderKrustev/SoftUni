package States;

import Models.GameOverMenu;
import Models.Player;
import Models.GameOverMenu;

import java.awt.*;


public class GameOverState extends State {
    private GameOverMenu gameOverMenu;

    public GameOverState(){
        init();
    }

    public void init(){
        this.gameOverMenu=new GameOverMenu();
    }


    @Override
    public void tick() {
          this.gameOverMenu.thick();
    }

    @Override
    public void render(Graphics g) {
         this.gameOverMenu.render(g);
    }

    @Override
    public Player getPlayer() {
        return null;
    }
}

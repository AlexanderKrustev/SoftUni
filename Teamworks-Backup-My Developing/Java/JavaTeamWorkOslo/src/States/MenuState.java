package States;

import Models.Menu;
import Models.Player;
import Graphics.Assets;

import java.awt.*;


public class MenuState extends State {
    private Menu menu;

    public MenuState(){
     init();
    }

    public void init(){
        this.menu=new Menu();
    }

    @Override
    public void tick() {
       this.menu.thick();
    }

    @Override
    public void render(Graphics g) {


        this.menu.render(g);

    }
    @Override
    public Player getPlayer() {
        return null;
    }


}

package States;

import Models.Player;

import java.awt.*;


public abstract class State {

    public abstract void tick();

    public abstract void render(Graphics g);

    public abstract Player getPlayer();

}

package Models;

import java.awt.*;


public class Obstacle extends Rectangle{
    private int y;
    private int x;
    private int width;
    private int height;

    public Obstacle (int x, int y, int width, int height){
        super(x, y, width, height);
        this.x=x;
        this.y=y;
        this.width=width;
        this.height=height;
    }

}

package Models;

import java.util.*;


public class CollusionManager {
    private Player player;
    private ArrayList<Obstacle> obstacles;

    public CollusionManager(Player player, ArrayList<Obstacle> obstacles) {
        this.player = player;
        this.obstacles= obstacles;
        }

    public void thick(){

        for (Obstacle ob: obstacles) {
            if(this.player.intersectTop(ob)){
                this.player.setY((int)ob.getY()-20);
            }
            if(this.player.intersectLeft(ob)){
                this.player.setX((int)ob.getX()-20);
            }
            if(this.player.getY()>300){
                this.player.setAlive(false);
                System.out.println("false");
            }
        }

    }
}



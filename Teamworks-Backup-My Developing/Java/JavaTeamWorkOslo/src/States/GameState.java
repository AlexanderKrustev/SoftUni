package States;

import java.awt.*;
import java.util.ArrayList;

import Graphics.Assets;
import Models.CollusionManager;
import Models.Obstacle;
import Models.Player;
import Graphics.SpriteSheet;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

/**
 * Created by krustev on 12-Apr-16.
 */
public class GameState extends State {
    private Player player;
    private SpriteSheet sh;
    private SpriteSheet coin1;
    private int cols=3;
    private Obstacle ground;
    private Obstacle ground2;
    private Obstacle ground3;
    private Obstacle bricksOne;
    private Obstacle bricksTwo;
    private Obstacle bricksThree;
    private Obstacle obstacleLowLeft;
    private Obstacle obstacleUpLeft;
    private Obstacle obstacleUpperLeft;
    private Obstacle obstacleTopperLeft;
    private Obstacle obstacleTopperRight;
    private Obstacle obstacleUpperRight;
    private Obstacle obstacleUpRight;
    private Obstacle obstacleLowRight;
    private CollusionManager cm;
    private ArrayList<Obstacle> obstacles;
    private int seconds = 120;

    public GameState(Player player){

        init(player);
    }

    private void init(Player player){

        this.ground=new Obstacle(0,285,334,40);
        this.ground2=new Obstacle(400,285,475,40);
        this.ground3=new Obstacle(942,285,139,40);

        this.obstacleLowLeft = new Obstacle(713,255,32,29);
        this.obstacleUpLeft = new Obstacle(746,225,32,59);
        this.obstacleUpperLeft = new Obstacle(778,195,33,89);
        this.obstacleTopperLeft = new Obstacle(811,165,65,119);
        this.obstacleTopperRight = new Obstacle(942,165,31,119);
        this.obstacleUpperRight = new Obstacle(972,195,33,89);
        this.obstacleUpRight = new Obstacle(1005,225,33,59);
        this.obstacleLowRight = new Obstacle(1039,255,32,29);
        this.player=player;
        this.coin1=new SpriteSheet(Assets.coin);
        this.obstacles=new ArrayList<>();
        this.obstacles.add(ground);
        this.obstacles.add(ground2);
        this.obstacles.add(ground3);
        this.obstacles.add(obstacleLowLeft);
        this.obstacles.add(obstacleUpLeft);
        this.obstacles.add(obstacleUpperLeft);
        this.obstacles.add(obstacleTopperLeft);
        this.obstacles.add(obstacleTopperRight);
        this.obstacles.add(obstacleUpperRight);
        this.obstacles.add(obstacleUpRight);
        this.obstacles.add(obstacleLowRight);
        this.cm=new CollusionManager(this.player,this.obstacles);
    }

    @Override
    public void tick() {
        
        this.cm.thick();
        this.player.thick();
    }

    @Override
    public void render(Graphics g) {

        g.drawImage(Assets.level_1, 0, 0, null);

        this.player.render(g);

        Font secondsFont = new Font("Comic Sans MS", Font.BOLD, 17);                                //Timer
        g.setFont(secondsFont);

        if (seconds <= 20){
            g.setColor(Color.red);
        } else {
            g.setColor(Color.white);
        }
        g.drawString(Integer.toString(seconds), 960, 30);
        seconds -= 0.001;

    }

    public Player getPlayer(){
        return this.player;
    }
}

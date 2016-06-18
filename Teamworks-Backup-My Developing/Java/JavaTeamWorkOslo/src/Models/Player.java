package Models;

import java.awt.*;

import Graphics.*;



public class Player {
    public static int WIDTH =20;
    public static int HEIGHT =40;
    public int x;
    public int y;
    public Rectangle playerBorder;
    public SpriteSheet spriteRunningR;
    public SpriteSheet spriteRunningL;
    public int cols=3;
    private boolean isMovingRight;
    private boolean isMovingLeft;
    private boolean isJumping;
    private boolean isAlive;
    private int velocity;



    public Player() {

        this.setX(75);
        this.setY(285)  ;
        this.playerBorder = new Rectangle(this.getX(), this.getY(), WIDTH, HEIGHT);
        this.spriteRunningR = new SpriteSheet(Assets.playerRight);
        this.spriteRunningL  = new SpriteSheet(Assets.playerLeft);
        this.velocity=8;
        this.setAlive(true);
    }

    public int   getX()     { return x;      }
    public int   getY()     { return y;      }
    public  void  setX(int x)     { this.x=x;     }
    public  void  setY(int y)     { this.y=y;      }
    public void setAlive(boolean alive){this.isAlive=alive;}
    public boolean getAlive(){return this.isAlive;}


    public void thick() {



        this.playerBorder.setBounds(this.x,this.y, WIDTH, HEIGHT);
        if(isMovingRight){
            this.x +=this.velocity;
            cols--;
            if(cols==0){
                cols=3;
            }
        }
        if(isMovingLeft){

            this.x -=this.velocity;
            cols--;
            if(cols==0){
                cols=3;
            }
        }

        if(isJumping){

            for (int i = 0; i <15; i=i+1) {
                this.setY(this.getY()-i);
            }

        }
       else {
            this.setY(this.getY()+velocity+10);
        }
        this.playerBorder.setBounds(this.x,this.y, WIDTH, HEIGHT);

    }
    public void render(Graphics g){

        if(!isMovingRight) {
            g.drawImage(this.spriteRunningR.crop(cols * 19, 0, 20, 39), this.x, this.y, null);
        }
        if(!isMovingLeft){
            g.drawImage(this.spriteRunningL.crop(cols * 20, 0, 20, 40), this.x, this.y, null);
        }
         Graphics2D g2=(Graphics2D)g;

        g2.draw(this.playerBorder);

    }

    public boolean intersectTop(Rectangle rect){
        if(this.getX()>= rect.getX() && this.getX()<=rect.getWidth()+rect.getX()) {
            if (this.playerBorder.intersects(rect) || this.getY() > rect.getY()) {
                return true;
            }
        }

        return false;
    }
    public boolean intersectLeft(Rectangle rect){
        if(intersectTop((rect))){
        if(this.getX()+20>rect.getX() && this.getY()>rect.getY() && this.getY()<rect.getY()+rect.getHeight()) {
           return true;
        }
        }
        return false;
    }

    public boolean getisMovingRight(){
        return this.isMovingRight;
    }
    public void setMovingRight(boolean right){
        this.isMovingRight=right;
    }

    public boolean getisJumping(){
        return this.isJumping;
    }
    public void setJumping(boolean jumping){
        this.isJumping=jumping;
    }

    public boolean getisMovingLeft(){
        return this.isMovingLeft;
    }
    public void setMovingLeft(boolean left){
        this.isMovingLeft=left;
    }


}

package Core;

import States.GameState;
import States.StateManager;
import UI.Display;
import sun.reflect.generics.reflectiveObjects.NotImplementedException;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class InputHandler implements KeyListener, MouseListener {
    private boolean isGame;
    private boolean isMenu;
    private boolean isGameOver;


    public InputHandler(Display display){

        display.getCanvas().addKeyListener(this);
        display.getCanvas().addMouseListener(this);
    }
    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {
        int key = e.getKeyCode();
        if(this.isGame==true) {
            if (key == KeyEvent.VK_RIGHT) {
                StateManager.getCurrentState().getPlayer().setMovingRight(true);
            } else if (key == KeyEvent.VK_LEFT) {
                StateManager.getCurrentState().getPlayer().setMovingLeft(true);
            } else if (key == KeyEvent.VK_SPACE) {
                StateManager.getCurrentState().getPlayer().setJumping(true);
            }
        }
    }

    @Override
    public void keyReleased(KeyEvent e) {
        int key = e.getKeyCode();
        if(isGame==true) {
            if (key == KeyEvent.VK_RIGHT) {
                StateManager.getCurrentState().getPlayer().setMovingRight(false);
            } else if (key == KeyEvent.VK_LEFT) {
                StateManager.getCurrentState().getPlayer().setMovingLeft(false);
            } else if (key == KeyEvent.VK_SPACE) {
                StateManager.getCurrentState().getPlayer().setJumping(false);
            }
        }
    }

    @Override
    public void mouseClicked(MouseEvent e) {

    }

    @Override
    public void mousePressed(MouseEvent e) {
        int mouseX = e.getX();
        int mouseY = e.getY();

        if(mouseX>=400 && mouseX<=575) {
            if(mouseY>=10 && mouseY<=75) {
                this.isGame=true;
                this.isMenu=false;
                this.isGameOver=false;
            }
            if(mouseY>=95 && mouseY<=160) {
                throw new NotImplementedException();
            }
            if(mouseY>=300 && mouseY<=365) {
                System.exit(1); //exit
            }

        }
    }

    @Override
    public void mouseReleased(MouseEvent e) {

    }

    @Override
    public void mouseEntered(MouseEvent e) {

    }

    @Override
    public void mouseExited(MouseEvent e) {

    }

    public boolean getIsMenu(){
        return this.isMenu;
    }
    public boolean getIsGame(){
        return this.isGame;
    }
    public boolean getIsGameOver(){
        return this.isGameOver;
    }
    public void setIsGameOver(boolean isGameOver){
        this.isGameOver=isGameOver;
    }
    public void setIsGame(boolean isGame){
        this.isGame=isGame;
    }
}

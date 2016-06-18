package Core;
import Models.Customization;
import States.GameOverState;
import States.GameState;
import States.MenuState;
import States.StateManager;
import UI.Display;
import java.awt.*;
import java.awt.image.BufferStrategy;
import Models.Player;
import Graphics.Assets;
import com.sun.scenario.effect.impl.sw.sse.SSEBlend_SRC_OUTPeer;

public class Engine implements Runnable {
    private boolean isRunnig;
    private Display display;
    private BufferStrategy bs;
    private Graphics g;
    private Thread thread;
    private InputHandler inputHandler;
    private GameState gameState;
    private MenuState menuState;
    private GameOverState gameOverState;
    private boolean isGame;
    private boolean isMenu;
    private Customization customization;
    private Player player;

    public Engine(){


    }

    public void init(){

        Assets.init();
        this.player=new Player();
        this.display = new Display();
        this.gameState = new GameState(this.player);
        this.menuState = new MenuState();
        this.gameOverState=new GameOverState();
        this.isMenu=true;
        this.inputHandler = new InputHandler(this.display);

        StateManager.setCurrent(menuState);

    }

    public void thick(){

        if(this.inputHandler.getIsGame()){
            StateManager.setCurrent(gameState);

        }else if(this.inputHandler.getIsMenu()){
            StateManager.setCurrent(menuState);
        }

        if(!this.player.getAlive()){
            this.inputHandler.setIsGame(false);
            StateManager.setCurrent(gameOverState);
        }
        StateManager.getCurrentState().tick();
    }

    public void render(){

        this.bs=this.display.getCanvas().getBufferStrategy();

        if(this.bs==null){
            this.display.getCanvas().createBufferStrategy(2);
            return;
        }

        this.g = this.bs.getDrawGraphics();

        StateManager.getCurrentState().render(g);

        this.g.dispose();
        this.bs.show();
    }

    @Override
    public void run() {

        this.init();

        int fps=10;
        double timePerTick= 1_000_000_000.0/fps;
        double delta=0;
        long now;
        long lastTime= System.nanoTime();


        while (isRunnig){
            now = System.nanoTime();

            delta += (now-lastTime)/timePerTick;

            lastTime=now;
            if(delta>1) {

                this.render();
                this.thick();

                delta --;
            }


        }

        this.stop();
    }

    public synchronized void start() {
        if (!isRunnig){
            this.thread = new Thread(this);
            this.thread.start();
            this.isRunnig = true;
        }
    }

    public synchronized void stop(){
        if(isRunnig) {
            try {
                this.thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            this.isRunnig = false;
        }
    }

}

package UI;

import javax.swing.*;
import java.awt.*;



public class Display extends JFrame {
    private final int WIDTH=1081;
    private final int HEIGHT=385;
    public static String version="Oslo Mario v0.0.4";
    public JFrame frame;
    public Canvas canvas;


    public Display(){
             init();

    }

    public void init(){

        this.frame = new JFrame(version);

        this.frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.frame.setSize(new Dimension(WIDTH, HEIGHT));
        this.frame.setResizable(false);
        this.frame.setLocation(20, 50);
        this.frame.setVisible(true);
        this.frame.setLocationRelativeTo(null);

        this.canvas = new Canvas();
        this.canvas.setSize(new Dimension(WIDTH, HEIGHT));
        this.canvas.setVisible(true);

        this.frame.add(canvas);
        this.frame.pack();

    }

    public Canvas getCanvas(){
        return this.canvas;
    }
}

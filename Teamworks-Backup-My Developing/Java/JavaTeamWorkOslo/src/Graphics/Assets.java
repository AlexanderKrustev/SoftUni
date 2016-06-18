package Graphics;

import java.awt.image.BufferedImage;


public class Assets {
    public static BufferedImage playerRight;
    public static BufferedImage level_1;
    public static BufferedImage coin;
    public static BufferedImage menuImg;
    public static BufferedImage playerLeft;

    public static void init(){
        playerRight=ImageLoader.loadImage("/images/right.png");
        level_1=ImageLoader.loadImage("/images/level_1.png");
        coin=ImageLoader.loadImage("/images/coin.png");
        menuImg=ImageLoader.loadImage("/images/menu.jpg");
        playerLeft=ImageLoader.loadImage("/images/left.png");


    }

}

package com.chrisgward.bukkit.bukkitpluginwriter;

import java.awt.*;
import java.awt.event.*;
import java.awt.image.BufferedImage;
import java.io.InputStream;
import javax.imageio.ImageIO;
import javax.swing.*;
/**
 * Package: com.chrisgward.bukkit.bukkitpluginwriter
 * By: chris
 * Date: 5/01/12
 * Time: 1:01 PM 5/01/12
 */
public class Splash extends JFrame
{
    JLabel programName1;
    JLabel programName2;
    JLabel developers;
    JLabel lavaBucket;
    JLabel status;
    JPanel pane;
    Container container;
    Splash()
    {
        super("Starting - Bukkit Plugin Writer");
        pane = new JPanel();
        pane.setLayout(null);
        pane.setSize(300,200);
        setBounds(100, 100, 500, 335 - 65);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        container = this.getContentPane();
        container.add(pane);
        this.setResizable(false);
        this.setUndecorated(true);

        //
        //programName1
        //
        programName1 = new JLabel();
        programName1.setText("Bukkit Plugin");
        programName1.setLocation(29, 0);
        programName1.setSize(442, 85);
        programName1.setOpaque(true);
        programName1.setFont(new Font("Trebuchet MS", Font.BOLD, 72));
        pane.add(programName1);

        //
        //programName2
        //
        programName2 = new JLabel();
        programName2.setText("Writer");
        programName2.setSize(220,60);
        programName2.setOpaque(true);
        programName2.setFont(new Font("Trebuchet MS", Font.BOLD, 72));
        programName2.setLocation(50, 95);
        pane.add(programName2);

        //
        //developers
        //If you help with the writing of this program, feel free to add yourself to this list (even if it is just a pull request
        //Just make sure you resize and reposition it so it still works. I can add you to the list if you forget, you may need to remind me xD
        //
        developers = new JLabel();
        developers.setText("Developed by Chris Ward");
        developers.setSize(150, 15);
        developers.setOpaque(true);
        developers.setFont(new Font("Trebuchet MS", Font.PLAIN, 12));
        developers.setLocation(129, 230);
        pane.add(developers);

        //
        //status
        //
        status = new JLabel();
        status.setText("What is currently loading");
        status.setLocation(29, 160);
        status.setFont(new Font("Trebuchet MS", Font.BOLD, 13));
        status.setOpaque(true);
        status.setSize(230,20);
        pane.add(status);

        //
        //lavaBucket
        //
        lavaBucket = new JLabel();
        try{
            lavaBucket.setIcon(new ImageIcon(ImageIO.read(getClass().getResourceAsStream("Lavabucket.PNG"))));
        }
        catch (Exception e)
        {
            e.printStackTrace();
            System.exit(1);
        }

        lavaBucket.setLocation(300,100);
        lavaBucket.setSize(150,150);
        pane.add(lavaBucket);

        //
        //
        //
        setVisible(true);
    }
}

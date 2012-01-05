package com.chrisgward.bukkit.bukkitpluginwriter;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
/**
 * Package: com.chrisgward.bukkit.bukkitpluginwriter
 * By: chris
 * Date: 5/01/12
 * Time: 1:01 PM 5/01/12
 */
public class Splash extends JFrame
{
    JLabel programName = new JLabel("Bukkit Plugin Writer");
    JPanel pane = new JPanel();
    Splash()
    {
        super("Starting - Bukkit Plugin Writer");
        setBounds(100,100,300,200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container container = this.getContentPane();
        container.add(pane);
        pane.add(programName);
        setVisible(true);
    }
}

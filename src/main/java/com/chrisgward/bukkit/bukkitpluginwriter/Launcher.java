package com.chrisgward.bukkit.bukkitpluginwriter;

/**
 * Package: com.chrisgward.bukkit.bukkitpluginwriter
 * By: chris
 * Date: 5/01/12
 * Time: 12:41 PM 5/01/12
 */
public class Launcher {
    public static String[] runtimeArguments;
    public static void main(String[] args)
    {
        runtimeArguments = args;
        System.out.println("Running the launcher frame");
        new Splash();
    }
}

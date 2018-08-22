package de.colinsteffen.bm_ui_android_kotlin.Helper;

import android.util.Log;

public class TimeHelper {

    private static long startTime;
    private static long endTime;

    public static void setStartTime(){
        startTime = System.nanoTime();
    }

    public static void setEndTime(){
        endTime = System.nanoTime();

        long time = (endTime - startTime) / 1000000;
        Log.d("Time: End -> ", String.valueOf(time));
    }

}

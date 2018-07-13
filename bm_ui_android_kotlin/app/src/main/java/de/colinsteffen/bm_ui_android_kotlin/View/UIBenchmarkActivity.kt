package de.colinsteffen.bm_ui_android_kotlin.View

import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import de.colinsteffen.bm_ui_android_kotlin.R

class UIBenchmarkActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        val startTime = System.nanoTime();

        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ui_benchmark)

        val endTime = System.nanoTime();
        println("Time: End -> " + ((endTime - startTime) / 1000000))
    }

}
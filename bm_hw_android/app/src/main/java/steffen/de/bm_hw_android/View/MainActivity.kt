package steffen.de.bm_hw_android.View

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import steffen.de.bm_hw_android.R

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        println("Time: Start")
        val startTime = System.nanoTime()

        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val endTime = System.nanoTime()
        println("Time: End -> " + ((endTime - startTime) / 1000000))
    }
}

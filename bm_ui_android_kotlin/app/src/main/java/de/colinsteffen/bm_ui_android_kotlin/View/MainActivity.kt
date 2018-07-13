package de.colinsteffen.bm_ui_android_kotlin.View

import android.content.DialogInterface
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import de.colinsteffen.bm_ui_android_kotlin.R
import kotlinx.android.synthetic.main.activity_main.*
import android.support.v4.content.ContextCompat.startActivity
import android.content.Intent



class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        btn_open_activity.setOnClickListener {
            val myIntent = Intent(this@MainActivity, UIBenchmarkActivity::class.java)
            this@MainActivity.startActivity(myIntent)
        }
    }
}

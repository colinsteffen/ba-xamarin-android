package steffen.de.bm_db_android.View

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import steffen.de.bm_db_android.Controller.MainActivityController
import steffen.de.bm_db_android.R

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btnInsert = findViewById<Button>(R.id.btn_insert)
        val btnReset = findViewById<Button>(R.id.btn_reset)
        val btnLoad = findViewById<Button>(R.id.btn_load)

        val controller = MainActivityController(this.application)

        btnInsert.setOnClickListener{
            controller.insertData()
        }

        btnReset.setOnClickListener{
            controller.resetList()
        }

        btnLoad.setOnClickListener{
            controller.loadData()
        }

    }
}

package steffen.de.bm_db_android_kotlin.View

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*
import steffen.de.bm_db_android_kotlin.ViewModel.MainActivityViewModel
import steffen.de.bm_db_android_kotlin.R

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val controller = MainActivityViewModel(this.getApplication())

        btn_insert.setOnClickListener{
            controller.insertData()
        }

        btn_reset.setOnClickListener{
            controller.resetList()
        }

        btn_load.setOnClickListener{
            controller.loadData()
        }

        btn_delete.setOnClickListener{
            controller.deleteData()
        }

    }
}

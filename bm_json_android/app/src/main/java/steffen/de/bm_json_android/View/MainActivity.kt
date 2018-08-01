package steffen.de.bm_json_android.View

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*
import steffen.de.bm_json_android.R
import steffen.de.bm_json_android.ViewModel.MainActivityViewModel

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val viewModel = MainActivityViewModel()

        btn_serialize.setOnClickListener{
            viewModel.serializePersons()
        }

        btn_deserialize.setOnClickListener{
            viewModel.deserializePersons()
        }
    }
}

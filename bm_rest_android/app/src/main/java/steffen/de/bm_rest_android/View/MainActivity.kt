package steffen.de.bm_rest_android.View

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*
import steffen.de.bm_rest_android.R
import steffen.de.bm_rest_android.ViewModel.MainActivityViewModel

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val viewModel = MainActivityViewModel(this)

        btn_get.setOnClickListener{
            viewModel.getPersons()
        }

        btn_post.setOnClickListener{
            viewModel.postPersons()
        }
    }
}

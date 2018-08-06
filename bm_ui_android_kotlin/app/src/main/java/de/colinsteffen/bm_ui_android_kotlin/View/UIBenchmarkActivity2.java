package de.colinsteffen.bm_ui_android_kotlin.View;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.widget.ListView;

import de.colinsteffen.bm_ui_android_kotlin.R;
import de.colinsteffen.bm_ui_android_kotlin.View.Adapter.InformationAdapter;
import de.colinsteffen.bm_ui_android_kotlin.ViewModel.UIBenchmarkViewModel;

public class UIBenchmarkActivity2 extends AppCompatActivity{
    public UIBenchmarkActivity2(){
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        long startTime = System.nanoTime();

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ui_benchmark2);

        long endTime = System.nanoTime();
        long time = (endTime - startTime) / 1000000;
        Log.d("Time: End -> ", String.valueOf(time));
    }
}
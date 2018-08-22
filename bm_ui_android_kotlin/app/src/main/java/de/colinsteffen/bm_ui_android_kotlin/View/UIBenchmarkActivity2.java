package de.colinsteffen.bm_ui_android_kotlin.View;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.widget.ListView;

import de.colinsteffen.bm_ui_android_kotlin.Helper.TimeHelper;
import de.colinsteffen.bm_ui_android_kotlin.R;
import de.colinsteffen.bm_ui_android_kotlin.View.Adapter.InformationAdapter;
import de.colinsteffen.bm_ui_android_kotlin.ViewModel.UIBenchmarkViewModel;

public class UIBenchmarkActivity2 extends AppCompatActivity{
    public UIBenchmarkActivity2(){
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ui_benchmark2);
    }

    @Override
    protected void onResume(){
        super.onResume();

        TimeHelper.setEndTime();
    }
}
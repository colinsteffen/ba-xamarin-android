package de.colinsteffen.bm_ui_android_kotlin.View;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;

import de.colinsteffen.bm_ui_android_kotlin.Helper.TimeHelper;
import de.colinsteffen.bm_ui_android_kotlin.Model.Information;
import de.colinsteffen.bm_ui_android_kotlin.R;
import de.colinsteffen.bm_ui_android_kotlin.View.Adapter.InformationAdapter;
import de.colinsteffen.bm_ui_android_kotlin.ViewModel.UIBenchmarkViewModel;

import static java.sql.DriverManager.println;

public class UIBenchmarkActivity extends AppCompatActivity{

    UIBenchmarkViewModel uIBenchmarkViewModel;

    ListView informationLV;

    public UIBenchmarkActivity(){
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        uIBenchmarkViewModel = new UIBenchmarkViewModel();

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ui_benchmark);

        informationLV = findViewById(R.id.listview_ui_benchmark);
        informationLV.setAdapter(new InformationAdapter(this, uIBenchmarkViewModel.InformationItems));
    }

    @Override
    protected void onResume(){
        super.onResume();

        TimeHelper.setEndTime();
    }
}
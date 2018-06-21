package steffen.de.bm_db_android_java.View;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import steffen.de.bm_db_android_java.Controller.MainActivityController;
import steffen.de.bm_db_android_java.R;

public class MainActivity extends AppCompatActivity {

    private Button insertBtn;
    private Button resetBtn;
    private Button loadBtn;
    private Button deleteBtn;
    private MainActivityController controller;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        insertBtn = findViewById(R.id.btn_insert);
        resetBtn = findViewById(R.id.btn_reset);
        loadBtn = findViewById(R.id.btn_load);
        deleteBtn = findViewById(R.id.btn_delete);

        controller = new MainActivityController(this.getApplicationContext());

        insertBtn.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                controller.insertData();
            }
        });

        resetBtn.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                controller.resetList();
            }
        });

        loadBtn.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                controller.loadData();
            }
        });

        deleteBtn.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                controller.deleteData();
            }
        });
    }
}

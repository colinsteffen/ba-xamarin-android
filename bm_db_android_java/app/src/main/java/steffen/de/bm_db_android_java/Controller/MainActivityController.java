package steffen.de.bm_db_android_java.Controller;

import android.content.Context;
import android.os.AsyncTask;

import java.util.ArrayList;
import java.util.List;

import steffen.de.bm_db_android_java.Database.DataDatabase;
import steffen.de.bm_db_android_java.Model.Data;

public class MainActivityController {

    private List<Data> dataList;
    private DataDatabase database;

    public MainActivityController(Context context){
        database = DataDatabase.getInstance(context);
        dataList = new ArrayList<Data>();

        for(int i = 0; i < 1000; i++){
            dataList.add(new Data());
        }
    }

    public void loadData(){
        long startTime = System.nanoTime();

        dataList = database.dataDao().getAll();

        long endTime = System.nanoTime();
        System.out.println("LoadTime:" + ((endTime - startTime) / 1000000));
    }

    public void resetList(){
        dataList = null;
    }

    public void insertData(){
        long startTime = System.nanoTime();

        for(Data d: dataList){
            database.dataDao().insert(d);
        }

        long endTime = System.nanoTime();
        System.out.println("LoadTime:" + ((endTime - startTime) / 1000000));
    }

    public void deleteData(){
        long startTime = System.nanoTime();

        for (Data d : database.dataDao().getAll()) {
            database.dataDao().delete(d);
        }

        long endTime = System.nanoTime();
        System.out.println("DeleteTime:" + ((endTime - startTime) / 1000000));

        dataList.clear();
        for(int i = 0; i < 1000; i++){
            dataList.add(new Data());
        }

        System.out.println("Delete erfolgreich.");
    }
}

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

        addDataToList();
    }

    public void loadData(){
        long startTime = System.nanoTime();

        dataList = database.dataDao().getAll();

        long endTime = System.nanoTime();
        System.out.println("Time: Load -> " + ((endTime - startTime) / 1000000));
        System.out.println("Time: Load -> " + dataList.size());
    }

    public void resetList(){
        dataList.clear();
    }

    public void insertData(){
        long startTime = System.nanoTime();

        database.dataDao().insert(dataList);

        long endTime = System.nanoTime();
        System.out.println("Time: Insert -> " + ((endTime - startTime) / 1000000));
        System.out.println("Time: Insert -> " + database.dataDao().getAll().size());
    }

    public void deleteData(){
        long startTime = System.nanoTime();

        for (Data d : database.dataDao().getAll()) {
            database.dataDao().delete(d);
        }

        long endTime = System.nanoTime();
        System.out.println("Time: Delete -> " + ((endTime - startTime) / 1000000));
        System.out.println("Time: Delete -> " + database.dataDao().getAll().size());

        dataList.clear();
        addDataToList();
    }

    public void addDataToList()
    {
        for(int i = 0; i < 1000; i++){
            dataList.add(new Data());
        }
    }
}

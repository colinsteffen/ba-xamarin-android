package steffen.de.bm_db_android_kotlin.ViewModel

import android.app.Application
import kotlinx.coroutines.experimental.launch
import kotlinx.coroutines.experimental.runBlocking
import steffen.de.bm_db_android_kotlin.Model.Data
import steffen.de.bm_db_android_kotlin.Database.DataDatabase
import kotlin.system.measureTimeMillis

class MainActivityViewModel(application: Application, private var database: DataDatabase = DataDatabase.getDatabase(application)){

    private var dataList: MutableList<Data>? = mutableListOf<Data>()

    init {
        addDataToList()
    }

    fun loadData() = runBlocking{
        val startTime = System.nanoTime();

        val job = launch{
            dataList = database.dataDao().all
        }
        job.join()

        val endTime = System.nanoTime();
        println("Time: Load -> " + ((endTime - startTime) / 1000000))
        println("Time: Load -> " + dataList!!.count())
    }

    fun resetList(){
        dataList!!.clear()
    }

    fun insertData() = runBlocking{
        val startTime = System.nanoTime();

        val job = launch {
            database.dataDao().insert(dataList!!)
        }
        job.join()

        val endTime = System.nanoTime();
        println("Time: Insert -> " + ((endTime - startTime) / 1000000))
        println("Time: Insert -> " + dataList!!.count())
    }

    fun deleteData() = runBlocking{
        val startTime = System.nanoTime();

        val job = launch {
                database.dataDao().delete(dataList!!)
        }
        job.join()

        val endTime = System.nanoTime();
        println("Time: Delete -> " + ((endTime - startTime) / 1000000))

        val jobPrint = launch {
            println("Time: Delete -> " + database.dataDao().all.count())
        }
        jobPrint.join()

        dataList!!.clear()
        addDataToList()
    }

    fun addDataToList(){
        for(i in 1..10000)
            dataList!!.add(Data())
    }
}
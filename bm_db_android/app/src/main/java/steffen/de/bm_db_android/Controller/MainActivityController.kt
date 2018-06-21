package steffen.de.bm_db_android.Controller

import android.app.Application
import kotlinx.coroutines.experimental.awaitAll
import kotlinx.coroutines.experimental.launch
import kotlinx.coroutines.experimental.runBlocking
import steffen.de.bm_db_android.Database.DataDatabase
import steffen.de.bm_db_android.Model.Data
import java.util.*
import kotlin.concurrent.thread
import kotlin.system.measureTimeMillis

class MainActivityController(application: Application){

    private var dataList: MutableList<Data>? = mutableListOf<Data>()
    private val database = DataDatabase.getDatabase(application)

    init {
        for(i in 1..1000){
            dataList!!.add(Data())
        }
    }

    fun loadData() = runBlocking{

        val timer = measureTimeMillis {
            val job = launch{
                dataList = database.dataDao().all
            }
            job.join()
        }

        println("LoadTime:" + timer)
        println("Datansatz:" + dataList!!.count())
    }

    fun resetList(){
        dataList = null;
    }

    fun insertData() = runBlocking{
        val timer = measureTimeMillis {
            val job = launch {
                for (d in dataList!!) {
                    database.dataDao().insert(d)
                }
            }
            job.join()
        }

        println("InsertTime: " + timer)
    }

}

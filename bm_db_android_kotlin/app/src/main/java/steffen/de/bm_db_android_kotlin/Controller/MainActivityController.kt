package steffen.de.bm_db_android_kotlin.Controller

import android.app.Application
import kotlinx.coroutines.experimental.launch
import kotlinx.coroutines.experimental.runBlocking
import steffen.de.bm_db_android_kotlin.Model.Data
import steffen.de.bm_db_android_kotlin.Database.DataDatabase
import kotlin.system.measureTimeMillis

class MainActivityController(application: Application, private var database: DataDatabase = DataDatabase.getDatabase(application)){

    private var dataList: MutableList<Data>? = mutableListOf<Data>()

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
        dataList = null
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

    fun deleteData() = runBlocking{
        val timer = measureTimeMillis {
            val job = launch {
                for (d in database.dataDao().all) {
                    database.dataDao().delete(d)
                }
            }
            job.join()
        }

        println("DeleteTime: ")

        dataList!!.clear()
        for(i in 1..1000){
            dataList!!.add(Data())
        }


        println("Delete erfolgreich.")
    }

}
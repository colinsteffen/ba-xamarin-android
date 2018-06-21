package steffen.de.bm_db_android.Controller

import kotlinx.coroutines.experimental.launch
import kotlinx.coroutines.experimental.runBlocking
import steffen.de.bm_db_android.Database.DataDatabase
import steffen.de.bm_db_android.Model.Data
import kotlin.system.measureTimeMillis

class MainActivityController(context: Context, private var database: DataDatabase = DataDatabase.getDatabase(context)){

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
        val job = launch {
            for(d in database.dataDao().all){
                database.dataDao().delete(d)
            }
        }
        job.join()

        dataList!!.clear()
        for(i in 1..1000){
            dataList!!.add(Data())
        }

        println("Delete erfolgreich.")
    }

}

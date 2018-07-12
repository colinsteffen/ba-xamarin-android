package steffen.de.bm_db_android_kotlin.Database

import android.arch.persistence.room.Dao
import android.arch.persistence.room.Delete
import android.arch.persistence.room.Insert
import android.arch.persistence.room.Query
import steffen.de.bm_db_android_kotlin.Model.Data

@Dao
interface DataDao {

    @get:Query("SELECT * FROM data")
    val all: MutableList<Data>

    @Insert
    fun insert(dataList: MutableList<Data>)

    @Delete
    fun delete(dataList: MutableList<Data>)
}
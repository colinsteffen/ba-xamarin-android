package steffen.de.bm_db_android_kotlin.Database

import android.arch.persistence.room.Database
import android.arch.persistence.room.Room
import android.arch.persistence.room.RoomDatabase
import android.content.Context
import steffen.de.bm_db_android_kotlin.Model.Data

@Database(entities = arrayOf(Data::class), version = 1, exportSchema = false)
abstract class DataDatabase : RoomDatabase() {

    abstract fun dataDao(): DataDao

    companion object {

        private var sInstance: DataDatabase? = null

        @Synchronized
        fun getDatabase(context: Context): DataDatabase {
            if (sInstance == null) {
                sInstance = Room
                        .databaseBuilder(context, DataDatabase::class.java, "data_db")
                        .build()
            }
            return sInstance as DataDatabase
        }
    }
}
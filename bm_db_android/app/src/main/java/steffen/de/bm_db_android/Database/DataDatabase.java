package steffen.de.bm_db_android.Database;

import android.arch.persistence.room.Database;
import android.arch.persistence.room.Room;
import android.arch.persistence.room.RoomDatabase;
import android.content.Context;

import steffen.de.bm_db_android.Model.Data;

@Database(entities = {Data.class}, version = 1, exportSchema = false)
public abstract class DataDatabase extends RoomDatabase {

    @SuppressWarnings("WeakerAccess")
    public abstract DataDao dataDao();

    private static DataDatabase sInstance;

    public static synchronized DataDatabase getDatabase(Context context) {
        if (sInstance == null) {
            sInstance = Room
                    .databaseBuilder(context.getApplicationContext(), DataDatabase.class, "data_db")
                    .build();
        }
        return sInstance;
    }
}

package steffen.de.bm_db_android_java.Database;

import android.arch.persistence.room.Dao;
import android.arch.persistence.room.Delete;
import android.arch.persistence.room.Insert;
import android.arch.persistence.room.Query;

import java.util.List;

import steffen.de.bm_db_android_java.Model.Data;

@Dao
public interface DataDao {

    @Query("SELECT * FROM data")
    List<Data> getAll();

    @Insert
    void insert(List<Data> dataList);

    @Delete
    void delete(Data data);
}

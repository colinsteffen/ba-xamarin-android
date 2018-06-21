package steffen.de.bm_db_android.Database;

import android.arch.persistence.room.Dao;
import android.arch.persistence.room.Insert;
import android.arch.persistence.room.Query;

import java.util.List;

import steffen.de.bm_db_android.Model.Data;

@Dao
public interface DataDao {

    @Query("SELECT * FROM data")
    List<Data> getAll();

    @Insert
    void insert(Data data);
}

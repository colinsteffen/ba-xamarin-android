package steffen.de.bm_db_android_kotlin.Model

import android.arch.persistence.room.ColumnInfo
import android.arch.persistence.room.Entity
import android.arch.persistence.room.PrimaryKey

@Entity
class Data {

    @PrimaryKey(autoGenerate = true)
    var id: Int = 0

    @ColumnInfo(name = "data_string")
    var dataString: String? = null

    @ColumnInfo(name = "data_int")
    var dataInt: Int = 0

    @ColumnInfo(name = "data_boolean")
    var dataBoolean: Boolean? = null

    @ColumnInfo(name = "data_double")
    var dataDouble: Double? = null

    init {
        dataString = "JustSomeData"
        dataInt = 123456789
        dataBoolean = true
        dataDouble = 4.0
    }

}
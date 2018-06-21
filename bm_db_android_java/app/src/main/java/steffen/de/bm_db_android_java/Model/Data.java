package steffen.de.bm_db_android_java.Model;

import android.arch.persistence.room.ColumnInfo;
import android.arch.persistence.room.Entity;
import android.arch.persistence.room.PrimaryKey;

@Entity
public class Data {

    @PrimaryKey(autoGenerate = true)
    private int ID;

    @ColumnInfo(name = "data_string")
    private String dataString;

    @ColumnInfo(name = "data_int")
    private int dataInt;

    @ColumnInfo(name = "data_boolean")
    private Boolean dataBoolean;

    @ColumnInfo(name = "data_double")
    private Double dataDouble;

    public Data(){
        dataString = "JustSomeData";
        dataInt = 123456789;
        dataBoolean = true;
        dataDouble = 4.0;
    }

    public int getID() {
        return ID;
    }

    public String getDataString() {
        return dataString;
    }

    public int getDataInt() {
        return dataInt;
    }

    public Boolean getDataBoolean() {
        return dataBoolean;
    }

    public Double getDataDouble() {
        return dataDouble;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public void setDataString(String dataString) {
        this.dataString = dataString;
    }

    public void setDataInt(int dataInt) {
        this.dataInt = dataInt;
    }

    public void setDataBoolean(Boolean dataBoolean) {
        this.dataBoolean = dataBoolean;
    }

    public void setDataDouble(Double dataDouble) {
        this.dataDouble = dataDouble;
    }
}

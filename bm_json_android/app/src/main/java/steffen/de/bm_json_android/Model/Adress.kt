package steffen.de.bm_json_android.Model

import android.R.attr.name



data class Adress(
    var city: String = "Berlin",
    var zipCode: Int = 10179,
    var street: String = "Bahnhofstrasse",
    var number: String = "10a"
){
    override fun toString(): String {
        return String
                .format("%s %s %s %s]",
                        city, zipCode, street, number)
    }
}
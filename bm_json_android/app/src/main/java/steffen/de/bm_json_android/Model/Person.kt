package steffen.de.bm_json_android.Model

import android.R.attr.name



data class Person (    val country: String = "Germany",
                       val birthday: String = "13.08.1985",
                       val phonenumber: String = "+490154868686",
                       val location: Adress = Adress(),
                       val surname: String = "Mustermann",
                       val forename: String = "Max"){
    override fun toString(): String {

        return String
                .format("Person: [Country: %s, Birthday: %s, Phonenumber: %s, Location: %s, Surname: %s, Forename: %s]",
                        country, birthday, phonenumber, location, surname, forename)
    }
}
package steffen.de.bm_json_android.ViewModel;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;

import steffen.de.bm_json_android.Model.Person;

public class MainActivityViewModel {

    public MainActivityViewModel(){
        for (int i = 0; i < 10000; i++)
        {
            personList.add(new Person());
        }
    }

    private ArrayList<Person> personList = new ArrayList<Person>();
    private String jsonString;

    public void serializePersons(){
        long startTime = System.nanoTime();

        ObjectMapper mapper = new ObjectMapper();
        try {
            jsonString = mapper.writeValueAsString(personList);
        } catch (JsonProcessingException e) {
            System.out.println("Error bei der Serialization");
        }

        long endTime = System.nanoTime();
        System.out.println("Time: Serialization -> " + ((endTime - startTime) / 1000000));
    }

    public void deserializePersons(){
        long startTime = System.nanoTime();

        ObjectMapper mapper = new ObjectMapper();
        Person[] persons = null;
        try {
            persons = mapper.readValue(jsonString, Person[].class);
        } catch (JsonProcessingException e) {
            System.out.println("Error bei der Deserialization");
        } catch (IOException e) {
            System.out.println("Error bei der Deserialization");
        }
        personList = new ArrayList<>(Arrays.asList(persons));

        long endTime = System.nanoTime();
        System.out.println("Time: Deserialization -> " + ((endTime - startTime) / 1000000));
        System.out.println("Time: Deserialization -> " + personList.size());
    }

}

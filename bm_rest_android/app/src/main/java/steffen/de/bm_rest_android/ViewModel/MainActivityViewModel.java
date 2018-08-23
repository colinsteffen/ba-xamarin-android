package steffen.de.bm_rest_android.ViewModel;

import android.content.Context;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.util.ArrayList;
import java.util.List;

import steffen.de.bm_rest_android.Model.Person;
import steffen.de.bm_rest_android.Services.RestService;

public class MainActivityViewModel {
    private List<Person> personList;
    private RestService restService;

    public MainActivityViewModel(Context context){
        restService = new RestService(context);

        personList = new ArrayList<Person>();
        for(int i = 0; i < 1000; i++)
            personList.add(new Person("Mustermann", "Max", 22));
    }

    public void getPersons(){
        restService.GetPersonsJson();
    }

    public void postPersons(){
        ObjectMapper mapper = new ObjectMapper();
        String content = null;
        try {
            content = mapper.writeValueAsString(personList);
        } catch (JsonProcessingException e) {
            e.printStackTrace();
            System.out.println("Error bei der Serialization");
        }

        restService.postPersons(content);
    }

}

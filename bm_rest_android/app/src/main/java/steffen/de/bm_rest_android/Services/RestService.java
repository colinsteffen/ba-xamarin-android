package steffen.de.bm_rest_android.Services;

import android.app.Application;
import android.content.Context;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.util.HashMap;
import java.util.Map;

public class RestService {
    String serveradresse = "http://172.20.10.3:5000/api/person/";
    Context context;

    public RestService(Context context){
        this.context = context;
    }

    public void GetPersonsJson(){
        final long startTime = System.nanoTime();
        RequestQueue queue = Volley.newRequestQueue(context);

        StringRequest stringRequest = new StringRequest(Request.Method.GET, serveradresse, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                long endTime = System.nanoTime();
                System.out.println("Time: Serialization -> " + ((endTime - startTime) / 1000000));
                System.out.println("Content: " + response.substring(0));
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                System.out.println(error);
            }
        });
        queue.add(stringRequest);
    }

    public void postPersons(final String personsJson){
        final long startTime = System.nanoTime();
        RequestQueue queue = Volley.newRequestQueue(context);

        StringRequest postRequest = new StringRequest(Request.Method.POST, serveradresse,
                new Response.Listener<String>()
                {
                    @Override
                    public void onResponse(String response) {
                        long endTime = System.nanoTime();
                        System.out.println("Time: Serialization -> " + ((endTime - startTime) / 1000000));
                        System.out.println("Content: " + response.substring(0));
                    }
                },
                new Response.ErrorListener()
                {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        System.out.println(error);
                    }
                }
        ) {
            @Override
            protected Map<String, String> getParams() {
                Map<String, String> params = new HashMap<String, String>();
                params.put("content", personsJson);

                return params;
            }
        };
        queue.add(postRequest);
    }
}

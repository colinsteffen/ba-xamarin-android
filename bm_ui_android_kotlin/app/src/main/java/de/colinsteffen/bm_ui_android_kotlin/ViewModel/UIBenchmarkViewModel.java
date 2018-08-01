package de.colinsteffen.bm_ui_android_kotlin.ViewModel;

import android.arch.lifecycle.ViewModel;
import android.databinding.ObservableList;
import android.support.annotation.NonNull;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.ListIterator;

import de.colinsteffen.bm_ui_android_kotlin.Model.Information;

public class UIBenchmarkViewModel extends ViewModel {

    public ArrayList<Information> InformationItems = new ArrayList<>();

    public UIBenchmarkViewModel(){

        for(int i = 0; i < 1000; i++){
            InformationItems.add(new Information("Paderborn", "Bielefeld"));
        }

    }
}

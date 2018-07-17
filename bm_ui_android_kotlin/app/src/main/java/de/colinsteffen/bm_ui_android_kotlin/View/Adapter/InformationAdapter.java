package de.colinsteffen.bm_ui_android_kotlin.View.Adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.BaseAdapter;
import android.widget.TextView;
import android.widget.TwoLineListItem;

import java.util.ArrayList;
import java.util.List;

import de.colinsteffen.bm_ui_android_kotlin.Model.Information;
import de.colinsteffen.bm_ui_android_kotlin.R;

public class InformationAdapter extends BaseAdapter {

    private Context context;
    private ArrayList<Information> informationList;

    public InformationAdapter(Context context, ArrayList<Information> informationList){
        this.informationList = informationList;
        this.context = context;
    }

    @Override
    public int getCount() {
        return informationList.size();
    }

    @Override
    public Object getItem(int position) {
        return informationList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        TwoLineListItem twoLineListItem;

        if(convertView == null){
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            twoLineListItem = (TwoLineListItem) inflater.inflate(android.R.layout.simple_list_item_2, null);
        } else {
            twoLineListItem = (TwoLineListItem) convertView;
        }

        TextView text1 = twoLineListItem.getText1();
        TextView text2 = twoLineListItem.getText2();

        text1.setText("Start: " + informationList.get(position).getStart());
        text2.setText("End: " + informationList.get(position).getEnd());

        return twoLineListItem;
    }
}

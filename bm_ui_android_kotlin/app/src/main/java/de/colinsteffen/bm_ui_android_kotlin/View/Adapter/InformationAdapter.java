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

public class InformationAdapter extends ArrayAdapter<Information> {

    public InformationAdapter(Context context, ArrayList<Information> informationList){
        super(context, 0, informationList);
    }

    @Override

    public View getView(int position, View convertView, ViewGroup parent) {
        Information information = getItem(position);

        if (convertView == null)
            convertView = LayoutInflater.from(getContext()).inflate(android.R.layout.simple_list_item_2, parent, false);

        TextView tvStart = (TextView) convertView.findViewById(android.R.id.text1);
        TextView tvEnd = (TextView) convertView.findViewById(android.R.id.text2);

        tvStart.setText(information.getStart());
        tvEnd.setText(information.getEnd());

        return convertView;
    }
}

package com.tcc.transportadora;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class localizacao extends Activity {
	public void onCreate (Bundle savedInstanceState){
		super.onCreate(savedInstanceState);
		setContentView(R.layout.localizacao1);}
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
		public boolean onMenuItemSelected(int featureId, MenuItem item){
			switch (item.getItemId()){
			case R.id.Tela1:
				startActivity(new Intent(this, CalculeFrete.class));
				break;
			case R.id.Tela2:
				startActivity(new Intent(this, FalarConosco.class));
				break;
				case R.id.Tela3:
					startActivity(new Intent(this, localizacao.class));
				break;
				case R.id.Tela4:
				startActivity(new Intent(this, empresa.class));
				break;
			}
			return super.onMenuItemSelected(featureId, item);
			
	}

}
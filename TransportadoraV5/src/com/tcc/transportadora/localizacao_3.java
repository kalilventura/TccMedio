package com.tcc.transportadora;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;

public class localizacao_3 extends Activity{
	Button btnenviar;
	public void onCreate (Bundle savedInstanceState){
		super.onCreate(savedInstanceState);
		setContentView(R.layout.localizacao_3);
		MontaLocalizacao();}
	
	public void MontaLocalizacao() {
		setContentView(R.layout.localizacao_3);
		btnenviar = (Button) findViewById(R.id.btnenviar);
		
		btnenviar.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent emailIntent = new Intent(Intent.ACTION_SEND);
				
				emailIntent.putExtra(Intent.EXTRA_EMAIL, new String[]{"email@provedor.com"});
				emailIntent.putExtra(Intent.EXTRA_CC, new String[] {"teste@provedor.com"});
				
				emailIntent.putExtra(Intent.EXTRA_SUBJECT,"Subject");
				emailIntent.putExtra(Intent.EXTRA_TEXT, "Body");
				
				emailIntent.setType("Message/rcf822");
				startActivity(Intent.createChooser(emailIntent, "Chose email client..."));
				
			}

		});	
		}
		
	
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
					startActivity(new Intent(this, localizacao_3.class));
				break;
				case R.id.Tela4:
				startActivity(new Intent(this, empresa.class));
				break;
			}
			return super.onMenuItemSelected(featureId, item);
			
	}
	
}
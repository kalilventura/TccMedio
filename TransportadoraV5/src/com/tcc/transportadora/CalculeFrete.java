package com.tcc.transportadora;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class CalculeFrete extends Activity {
	Button calcular,limpar;
	//TextView TextView8,TextView9, TextView11;
	EditText edtPeso;
	EditText edtQuantidade, edtValor;
	EditText edtAltura;
	EditText edtComprimento;
	EditText edtLargura;
	Double edtPeso1,edtQuantidade1,edtValor1,edtAltura1,edtComprimento1,edtLargura1;
	final Context context = this;	
	
	private String[] TipodeCarga = new String[] {
			"Refrigerado","Não refrigerado"
		};
	
		private Spinner sp;
		
		/*private String[] TipodeCaminhão = new String[] {
				"Carreta","Truck","Báu"
				};
			
				private Spinner sp1;*/
	
		public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.frete1);
		MontarTelaFrete();
	}
		
	
		public void MontarTelaFrete(){
			//onde começei a mudar de lugar
		setContentView(R.layout.frete1);
		//sms = (EditText)findViewById(R.id.editText1);
		/*TextView8 = (TextView) findViewById(R.id.TextView8);
		TextView9 = (TextView) findViewById(R.id.TextView9);
		TextView11 = (TextView) findViewById(R.id.TextView11);*/
		calcular = (Button) findViewById(R.id.btnCalcular);
		edtPeso = (EditText) findViewById(R.id.edtPeso);
		edtQuantidade = (EditText) findViewById(R.id.edtQuantidade);
		edtAltura = (EditText) findViewById(R.id.edtAltura);
		edtComprimento = (EditText) findViewById(R.id.edtComprimento);
		edtLargura = (EditText) findViewById(R.id.edtLargura);
		edtValor = (EditText) findViewById(R.id.edtValor);
		
		ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, TipodeCarga);
		adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);//opcional, funciona sem
		
		sp = (Spinner) findViewById(R.id.spinner1);
		sp.setAdapter(adapter);
		
		//ArrayAdapter<String> adapter1 = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item);
		//adapter1.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);//opcional, funciona sem
		/*sp1 = (Spinner) findViewById(R.id.spinner2);
		sp1.setAdapter(adapter1);
		
			sp1.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {

		//@Override
			public void onItemSelected(AdapterView<?> parent, View view,int position, long id) {
				 //TODO Auto-generated method stub
				
			}

			//@Override
				public void onNothingSelected(AdapterView<?> arg0) {
				// TODO Auto-generated method stub
				
		}
			public void cliqueSp(View view){
				String nome = (String) sp.getSelectedItem();
				long id = sp.getSelectedItemId();
				int position = sp.getSelectedItemPosition();
				
				//Toast.makeText(this, "Tipo de carga " +nome+ " ->Id " +id+ " -> Posição "+position, Toast.LENGTH_LONG).show();
			}
				});
			
			sp1.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {

				//@Override
					public void onItemSelected(AdapterView<?> parent, View view,int position, long id) {
						 int index = sp1.getSelectedItemPosition();
						
					}

					//@Override
						public void onNothingSelected(AdapterView<?> arg0) {
						// TODO Auto-generated method stub
						
				}
			});
						if (sp1.equals("Carreta")){
							edtComprimento.setText("6");
							edtAltura.setText("2");
							edtLargura.setText("2");}
						
					/*	else if (sp1.equals("Truck")){
							edtComprimento.setText(" ");
							edtAltura.setText(" ");
							edtLargura.setText(" ");
							
							TextView8.setText("14");
							TextView9.setText("2");
							TextView11.setText("3");}
						else { 
						//if(sp1.equals("Báu")) {
							edtComprimento.setText("14");
							edtAltura.setText("2");
							edtLargura.setText("3");
								}
		}
			
					public void cliqueSp(View view){
						String nome = (String) sp1.getSelectedItem();
						long id = sp1.getSelectedItemId();
						int position = sp1.getSelectedItemPosition();*/
		
	
	calcular = (Button)findViewById(R.id.btnCalcular);
	calcular.setOnClickListener(new View.OnClickListener() {
		public void onClick(View arg0) {
		String quant,alt,compri,larg,peso2,valor1;
		quant = (edtQuantidade.getText().toString());
		alt = (edtAltura.getText().toString());
		compri = (edtComprimento.getText().toString());
		larg = (edtLargura.getText().toString());
		peso2 = (edtPeso.getText().toString());
		valor1 = (edtValor.getText().toString());
		if ((quant.isEmpty() || alt.isEmpty() || compri.isEmpty() || 
				 larg.isEmpty() || peso2.isEmpty() || valor1.isEmpty())){
			AlertDialog.Builder mensagem = new AlertDialog.Builder(context);
			mensagem.setTitle("Mensagem");
			mensagem.setMessage("Preeencha os campos corretamente");//mensagem.setMessage("Total= "+ cubagem);
			mensagem.setNeutralButton("OK",null);
			mensagem.show();
			
			}
		else{
			Double peso,peso1,imposto,valor,quantidade,altura,comprimento,largura,cubagem,Valortot;
			quantidade = Double.parseDouble(quant);
			altura = Double.parseDouble(alt);
			comprimento = Double.parseDouble(compri);
			largura = Double.parseDouble(larg);
			peso = Double.parseDouble(peso2);
			valor = Double.parseDouble(valor1);
			cubagem =  altura * comprimento * largura * quantidade;
				imposto = peso + valor ;
				peso1 = peso * 0.35;
				valor = valor * 0.005;
				//codigo para calcular frete
				if (cubagem > peso)  {
					Valortot= (cubagem + peso1 + valor)/2;
				}
				else { 
					Valortot = (peso + peso1 + valor)/2;
				}
				 if (quantidade == 0 || altura == 0 || comprimento == 0 ||
						largura == 0 || peso == 0 || valor == 0 ){
						
					AlertDialog.Builder mensagem = new AlertDialog.Builder(context);
					mensagem.setTitle("Mensagem");
					mensagem.setMessage("Preeencha os campos corretamente");//mensagem.setMessage("Total= "+ cubagem);
					mensagem.setNeutralButton("OK",null);
					mensagem.show();
					}
				 else{
					 
				AlertDialog.Builder mensagem = new AlertDialog.Builder(context);
				mensagem.setTitle("Mensagem");
				mensagem.setMessage("Mensagem enviada com sucesso, o valor de seu frete por Km é R$ "+Valortot);//mensagem.setMessage("Total= "+ cubagem);
				mensagem.setNeutralButton("OK",null);
				mensagem.show();
				
				//mensagem de SMS para o celular do cliente
				
				//String number = sms.getText().toString();
				
				//SmsManager manager=SmsManager.getDefault();
				//manager.sendTextMessage(number, null, , sentIntent, null);
				
				
				 }
		}
		
		/*Double peso,peso1,imposto,valor,quantidade,altura,comprimento,largura,cubagem,Valortot;
		quantidade = Double.parseDouble(quant);
		altura = Double.parseDouble(alt);
		comprimento = Double.parseDouble(compri);
		largura = Double.parseDouble(larg);
		peso = Double.parseDouble(peso2);
		valor = Double.parseDouble(valor1);
		cubagem =  altura * comprimento * largura * quantidade;
			imposto = peso + valor ;
			peso1 = peso * 0.35;
			valor = valor * 0.005;
			//codigo para calcular frete
			if (cubagem > peso)  {
			Valortot= (cubagem + peso1 + valor)/2;
			}
			else { 
			Valortot = (peso + peso1 + valor)/2;
			}*/
			//parte que ta dando erro, (validação de campos vazios);
			
			/*if ((quantidade.equals(null) && altura.equals(null) && comprimento.equals(null) 
			&& largura.equals(null) && peso.equals(null) && valor.equals(null))){
				
			
			AlertDialog.Builder mensagem = new AlertDialog.Builder(context);
			mensagem.setTitle("Mensagem");
			mensagem.setMessage("Preeencha os campos corretamente");//mensagem.setMessage("Total= "+ cubagem);
			mensagem.setNeutralButton("OK",null);
			mensagem.show(); 
			}*/
			/*if (quantidade == 0 || altura == 0 || comprimento == 0 ||
			largura == 0 || peso == 0 || valor == 0 ){
			
		AlertDialog.Builder mensagem = new AlertDialog.Builder(context);
		mensagem.setTitle("Mensagem");
		mensagem.setMessage("Preeencha os campos corretamente");//mensagem.setMessage("Total= "+ cubagem);
		mensagem.setNeutralButton("OK",null);
		mensagem.show();
		}
		else{
				AlertDialog.Builder mensagem = new AlertDialog.Builder(context);
				mensagem.setTitle("Mensagem");
				mensagem.setMessage("Mensagem enviada com sucesso, o valor de seu frete é " +Valortot);//+Valortot//mensagem.setMessage("Total= "+ cubagem);
				mensagem.setNeutralButton("OK",null);
				mensagem.show();
		}*/
		//}
		}
	});
		limpar = (Button)findViewById(R.id.btnenviar);
		limpar.setOnClickListener(new View.OnClickListener() {

		@Override
		public void onClick(View v) {
			// TODO Auto-generated method stub
			edtPeso.setText(" ");
			edtValor.setText(" ");
			edtQuantidade.setText(" ");
			edtComprimento.setText(" ");
			edtAltura.setText(" ");
			edtLargura.setText(" ");
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
				startActivity(new Intent(this, localizacao.class));
				break;
				case R.id.Tela4:
				startActivity(new Intent(this, empresa.class));
				break;
			}
			return super.onMenuItemSelected(featureId, item);
			
	}
	}
	


package com.tcc.transportadora;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class FalarConosco extends Activity {
	Button Btnenv;
	Button button1;
	EditText Nome,Empresa,email,tel,Mensagem,SobreNome;
	EditText EdtNome, EdtEmpresa;
	EditText Edtemail;
	EditText Edtel;
	EditText EdtMensagem, edtSobreNome;
	final Context context = this;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.contato1);
		MontarTelaContato();
	}

	
	public void MontarTelaContato() {
		setContentView(R.layout.contato1);
		EdtNome = (EditText) findViewById(R.id.EdtNome);
		EdtEmpresa = (EditText) findViewById(R.id.EdtEmpresa);
		Edtemail = (EditText) findViewById(R.id.Edtemail);
		Edtel = (EditText) findViewById(R.id.EdTel);
		EdtMensagem = (EditText) findViewById(R.id.EdtMensagem);
		edtSobreNome = (EditText) findViewById(R.id.edtSobreNome);
		
		
		
		Btnenv = (Button) findViewById(R.id.BtnEnviar);
		Btnenv.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View v) {
				String nome, email, mensagem, empresa, telefone, SobreNome;
				Intent emailIntent = new Intent(Intent.ACTION_SEND);

				nome = (EdtNome.getText().toString());
				email = (Edtemail.getText().toString());
				telefone = (Edtel.getText().toString());
				mensagem = (EdtMensagem.getText().toString());
				SobreNome = (edtSobreNome.getText().toString());
				empresa = (EdtEmpresa.getText().toString());
				//validação de campos
				if (nome.isEmpty() || email.isEmpty() || mensagem.isEmpty()
						|| telefone.isEmpty() || SobreNome.isEmpty()
						|| empresa.isEmpty()) {
					AlertDialog.Builder mensage = new AlertDialog.Builder(
							context);
					mensage.setTitle("Mensagem");
					mensage.setMessage("Campos Inválidos, preencha-os corretamente!");
					mensage.setNeutralButton("Ok", null);
					mensage.show();

				} else if (!email.contains("@") || (!email.contains(".com")) && (!email.contains(".net")))  {
					AlertDialog.Builder mensage = new AlertDialog.Builder(
							context);
					mensage.setTitle("Mensagem");
					mensage.setMessage("Email inválido, por favor preencha corretamente o campo.");
					mensage.setNeutralButton("Ok", null);
					mensage.show();
				}

				else {
					AlertDialog.Builder mensagem1 = new AlertDialog.Builder(
							context);
					mensagem1.setTitle("Cálculo");
					mensagem1.setMessage("Mensagem enviada com sucesso!");
					mensagem1.setNeutralButton("OK", null);
					mensagem1.show();
					
					emailIntent.putExtra(email, true);
					
					
					String Limpar = " ";
					EdtNome.setText(Limpar);
					Edtemail.setText(Limpar);
					Edtel.setText(Limpar);
					EdtMensagem.setText(Limpar);
					edtSobreNome.setText(Limpar);
					EdtEmpresa.setText(Limpar);
					
					
				}
			}
		});
		button1 = (Button) findViewById(R.id.btnenviar);
		button1.setOnClickListener(new View.OnClickListener() {

			public void onClick(View v) {
				
				String Limpar = " ";
				Nome.setText(Limpar);
				email.setText(Limpar);
				tel.setText(Limpar);
				Mensagem.setText(Limpar);
				SobreNome.setText(Limpar);
				Empresa.setText(Limpar);
					
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
